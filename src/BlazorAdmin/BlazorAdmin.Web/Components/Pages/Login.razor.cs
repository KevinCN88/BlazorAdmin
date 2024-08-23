﻿using BlazorAdmin.Core.Helper;
using BlazorAdmin.Core.Resources;
using BlazorAdmin.Data;
using BlazorAdmin.Data.Constants;
using BlazorAdmin.Data.Entities.Log;
using Microsoft.JSInterop;
using MudBlazor;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace BlazorAdmin.Web.Components.Pages
{
    public partial class Login
    {
        private Dictionary<string, object> InputAttributes { get; set; } =
            new Dictionary<string, object>()
                {
                   { "autocomplete", "new-password2" },
                };

        private bool ShowContent;

        private bool IsLoading = false;

        private LoginModel _loginModel = new();

        protected override void OnInitialized()
        {
            base.OnInitialized();

        }

        protected override async Task OnInitializedAsync()
        {
            var state = await _stateProvider.GetAuthenticationStateAsync();
            if (state.User.Identity != null && state.User.Identity.IsAuthenticated)
            {
                _navManager.NavigateTo("/");
            }
            else
            {
                ShowContent = true;
            }
        }

        private async Task LoginSubmit()
        {
            IsLoading = true;
            using var context = await _dbFactory.CreateDbContextAsync();
            var user = context.Users.FirstOrDefault(u => u.Name == _loginModel.UserName &&
                u.IsEnabled && !u.IsDeleted && !u.IsSpecial);
            if (user == null || !HashHelper.VerifyPassword(user.PasswordHash, _loginModel!.Password!))
            {
                _snackbarService.Add("用户名或密码错误！", Severity.Error);
                RecordLogin(_loginModel.UserName!, false, context);
                IsLoading = false;
                return;
            }

            var token = _jwtHelper.GenerateJwtToken(new List<Claim>() {
                new Claim(ClaimConstant.UserId,user.Id.ToString()),
                new Claim(ClaimConstant.UserName,user.Name)
            });
            var cookieUtil = await _jsRuntime.InvokeAsync<IJSObjectReference>("import", "./js/cookieUtil.js");
            await cookieUtil.InvokeVoidAsync("setCookie", CommonConstant.UserToken, token);

            _authService.SetCurrentUser(token);
            RecordLogin(_loginModel.UserName!, true, context);
            _navManager.NavigateTo("/");
        }

        private void RecordLogin(string userName, bool isSucceed,
            BlazorAdminDbContext context)
        {
            context.LoginLogs.Add(new LoginLog
            {
                UserName = userName,
                IsSuccessd = isSucceed,
                Time = DateTime.Now,
                Ip = _httpAccessor.HttpContext?.Connection.RemoteIpAddress?.ToString(),
                Agent = _httpAccessor.HttpContext?.Request.Headers["User-Agent"]
            });
            context.SaveChanges();
        }

        private record LoginModel
        {
            [Required(ErrorMessageResourceName = "Login_UserNameHelpText",
                ErrorMessageResourceType = typeof(CusCulture))]
            public string? UserName { get; set; }

            [Required(ErrorMessageResourceName = "Login_PasswordHelpText",
                ErrorMessageResourceType = typeof(CusCulture))]
            public string? Password { get; set; }
        }
    }
}

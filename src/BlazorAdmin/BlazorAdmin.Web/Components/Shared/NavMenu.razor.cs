﻿using BlazorAdmin.Data.Entities.Rbac;
using Microsoft.AspNetCore.Components;
using static BlazorAdmin.Rbac.Components.NavItemMenu;

namespace BlazorAdmin.Web.Components.Shared
{
    public partial class NavMenu
    {
        [Parameter] public EventCallback<NavMenuItem> NavTo { get; set; }

        private List<Menu> MenuList = new();

        public HashSet<NavMenuItem> NavMenuItems { get; set; } = new();

        protected override async Task OnInitializedAsync()
        {
            using var context = await _dbFactory.CreateDbContextAsync();
            MenuList = context.Menus.Where(m => m.Type == 1).ToList();

            var canAccessedMenus = await _accessService.GetCanAccessedMenus();
            MenuList = MenuList.Where(m => canAccessedMenus.Contains(m.Id)).ToList();

            NavMenuItems = AppendMenuItems(null, MenuList);
        }

        private HashSet<NavMenuItem> AppendMenuItems(int? parentId, List<Menu> menus)
        {
            return menus.Where(m => m.ParentId == parentId).OrderBy(m => m.Order)
                .Select(m => new NavMenuItem
                {
                    MenuIcon = m.Icon,
                    MenuName = m.Name,
                    Route = m.Route,
                    Childs = AppendMenuItems(m.Id, menus)
                }).ToHashSet();
        }
    }
}

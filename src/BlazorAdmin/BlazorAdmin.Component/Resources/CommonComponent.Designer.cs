﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlazorAdmin.Component.Resources {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class CommonComponent {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal CommonComponent() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("BlazorAdmin.Component.Resources.CommonComponent", typeof(CommonComponent).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   重写当前线程的 CurrentUICulture 属性，对
        ///   使用此强类型资源类的所有资源查找执行重写。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 确定 的本地化字符串。
        /// </summary>
        public static string CommonDeleteDialogConfirmButtonText {
            get {
                return ResourceManager.GetString("CommonDeleteDialogConfirmButtonText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 是否删除此项目？ 的本地化字符串。
        /// </summary>
        public static string CommonDeleteDialogTitle {
            get {
                return ResourceManager.GetString("CommonDeleteDialogTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 请输入您的密码。 的本地化字符串。
        /// </summary>
        public static string ConfirmInputPassword {
            get {
                return ResourceManager.GetString("ConfirmInputPassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 确认 的本地化字符串。
        /// </summary>
        public static string ConfirmInputPasswordButtonText {
            get {
                return ResourceManager.GetString("ConfirmInputPasswordButtonText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 未找到当前登录用户信息！ 的本地化字符串。
        /// </summary>
        public static string NotFindUser {
            get {
                return ResourceManager.GetString("NotFindUser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 清理选中 的本地化字符串。
        /// </summary>
        public static string OrganizationTreeSelect_ClearBtnText {
            get {
                return ResourceManager.GetString("OrganizationTreeSelect_ClearBtnText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 所属组织选择 的本地化字符串。
        /// </summary>
        public static string OrganizationTreeSelect_Title {
            get {
                return ResourceManager.GetString("OrganizationTreeSelect_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 请选择 的本地化字符串。
        /// </summary>
        public static string OrganizationTreeSelect_TitleText {
            get {
                return ResourceManager.GetString("OrganizationTreeSelect_TitleText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 请输入您的密码 的本地化字符串。
        /// </summary>
        public static string PasswordHelpText {
            get {
                return ResourceManager.GetString("PasswordHelpText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 密码验证失败！ 的本地化字符串。
        /// </summary>
        public static string PasswordValidFail {
            get {
                return ResourceManager.GetString("PasswordValidFail", resourceCulture);
            }
        }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _03_Localization {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class UI {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal UI() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("_03_Localization.UI", typeof(UI).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Giriş.
        /// </summary>
        internal static string btnLogin {
            get {
                return ResourceManager.GetString("btnLogin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Dil.
        /// </summary>
        internal static string lblLanguage {
            get {
                return ResourceManager.GetString("lblLanguage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Şifre.
        /// </summary>
        internal static string lblPassword {
            get {
                return ResourceManager.GetString("lblPassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Kullanıcı Adı.
        /// </summary>
        internal static string lblUsername {
            get {
                return ResourceManager.GetString("lblUsername", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Kullanıcı adı ya da şifre hatalı!.
        /// </summary>
        internal static string loginErrorMessage {
            get {
                return ResourceManager.GetString("loginErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Giriş işlemi başarılı, anasayfaya yönlendiriliyorsunuz....
        /// </summary>
        internal static string loginSuccessMessage {
            get {
                return ResourceManager.GetString("loginSuccessMessage", resourceCulture);
            }
        }
    }
}

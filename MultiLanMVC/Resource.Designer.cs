﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MultiLanMVC {
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
    public class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MultiLanMVC.Resource", typeof(Resource).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Nombre del país.
        /// </summary>
        public static string Country {
            get {
                return ResourceManager.GetString("Country", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Nombre del país es requerido.
        /// </summary>
        public static string CountryNameRequired {
            get {
                return ResourceManager.GetString("CountryNameRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Correo electrónico.
        /// </summary>
        public static string Email {
            get {
                return ResourceManager.GetString("Email", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Correo es requerido.
        /// </summary>
        public static string EmailRequired {
            get {
                return ResourceManager.GetString("EmailRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Nombre.
        /// </summary>
        public static string FirstName {
            get {
                return ResourceManager.GetString("FirstName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Nombre es requerido.
        /// </summary>
        public static string FirstNameRequired {
            get {
                return ResourceManager.GetString("FirstNameRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Apellido.
        /// </summary>
        public static string LastName {
            get {
                return ResourceManager.GetString("LastName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Apellido es requerido.
        /// </summary>
        public static string LastNameRequired {
            get {
                return ResourceManager.GetString("LastNameRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Registro.
        /// </summary>
        public static string Register {
            get {
                return ResourceManager.GetString("Register", resourceCulture);
            }
        }
    }
}

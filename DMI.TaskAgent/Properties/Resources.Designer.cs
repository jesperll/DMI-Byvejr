﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.468
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DMI.TaskAgent.Properties {
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
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DMI.TaskAgent.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Latest ({0:HH&apos;:&apos;mm}).
        /// </summary>
        public static string LatestTitle {
            get {
                return ResourceManager.GetString("LatestTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Afternoon ({0:HH&apos;:&apos;mm}).
        /// </summary>
        public static string Tile_Afternoon {
            get {
                return ResourceManager.GetString("Tile_Afternoon", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Evening ({0:HH&apos;:&apos;mm}).
        /// </summary>
        public static string Tile_Evening {
            get {
                return ResourceManager.GetString("Tile_Evening", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Morning ({0:HH&apos;:&apos;mm}).
        /// </summary>
        public static string Tile_Morning {
            get {
                return ResourceManager.GetString("Tile_Morning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Night ({0:HH&apos;:&apos;mm}).
        /// </summary>
        public static string Tile_Night {
            get {
                return ResourceManager.GetString("Tile_Night", resourceCulture);
            }
        }
    }
}

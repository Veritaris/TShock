﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TShock.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TShock.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Exception occurred while executing command..
        /// </summary>
        internal static string CommandInvoke_Exception {
            get {
                return ResourceManager.GetString("CommandInvoke_Exception", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid hyphenated argument..
        /// </summary>
        internal static string CommandParse_InvalidHyphenatedArg {
            get {
                return ResourceManager.GetString("CommandParse_InvalidHyphenatedArg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Missing argument &quot;{0}&quot;..
        /// </summary>
        internal static string CommandParse_MissingArg {
            get {
                return ResourceManager.GetString("CommandParse_MissingArg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Too many arguments were provided..
        /// </summary>
        internal static string CommandParse_TooManyArgs {
            get {
                return ResourceManager.GetString("CommandParse_TooManyArgs", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Argument type &quot;{0}&quot; not recognized..
        /// </summary>
        internal static string CommandParse_UnrecognizedArgType {
            get {
                return ResourceManager.GetString("CommandParse_UnrecognizedArgType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Long flag &quot;--{0}&quot; not recognized..
        /// </summary>
        internal static string CommandParse_UnrecognizedLongFlag {
            get {
                return ResourceManager.GetString("CommandParse_UnrecognizedLongFlag", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Optional argument &quot;{0}&quot; not recognized..
        /// </summary>
        internal static string CommandParse_UnrecognizedOptional {
            get {
                return ResourceManager.GetString("CommandParse_UnrecognizedOptional", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Short flag &quot;-{0}&quot; not recognized..
        /// </summary>
        internal static string CommandParse_UnrecognizedShortFlag {
            get {
                return ResourceManager.GetString("CommandParse_UnrecognizedShortFlag", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &quot;{0}&quot; is a number that is out of range of an integer..
        /// </summary>
        internal static string Int32Parser_IntegerOutOfRange {
            get {
                return ResourceManager.GetString("Int32Parser_IntegerOutOfRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &quot;{0}&quot; is an invalid integer..
        /// </summary>
        internal static string Int32Parser_InvalidInteger {
            get {
                return ResourceManager.GetString("Int32Parser_InvalidInteger", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid backslash..
        /// </summary>
        internal static string StringParser_InvalidBackslash {
            get {
                return ResourceManager.GetString("StringParser_InvalidBackslash", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Escape character &quot;\{0}&quot; not recognized..
        /// </summary>
        internal static string StringParser_UnrecognizedEscape {
            get {
                return ResourceManager.GetString("StringParser_UnrecognizedEscape", resourceCulture);
            }
        }
    }
}

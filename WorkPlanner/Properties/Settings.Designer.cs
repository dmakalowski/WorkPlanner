﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WorkPlanner.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.8.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=C:\\USERS\\NATUR\\SOURCE\\REPOS\\WO" +
            "RKPLANNER\\WORKPLANNER\\DATABASE1.MDF;Integrated Security=True;Connect Timeout=30;" +
            "Encrypt=False;TrustServerCertificate=False")]
        public string C__USERS_NATUR_SOURCE_REPOS_WORKPLANNER_WORKPLANNER_DATABASE1_MDFConnectionString {
            get {
                return ((string)(this["C__USERS_NATUR_SOURCE_REPOS_WORKPLANNER_WORKPLANNER_DATABASE1_MDFConnectionString" +
                    ""]));
            }
        }
    }
}

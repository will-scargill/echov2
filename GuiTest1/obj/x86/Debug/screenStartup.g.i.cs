﻿#pragma checksum "..\..\..\screenStartup.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8871F7BCD4DE269DDDD97A5254C2B0E572574A35082A7247F262D1D3091EF35E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using GuiTest1;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace EMessenger {
    
    
    /// <summary>
    /// screenStartup
    /// </summary>
    public partial class screenStartup : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\screenStartup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bStartupSettings;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\screenStartup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bStartupConn;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\screenStartup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bStartupExit;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\screenStartup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lbStartupServers;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\screenStartup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbStartupUsername;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\screenStartup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox tbStartupPassword;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\screenStartup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lStartupUsername;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\screenStartup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lStartupPassword;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\screenStartup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lStartupEcho;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\screenStartup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbRememberUser;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/EMessenger;component/screenstartup.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\screenStartup.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.bStartupSettings = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\screenStartup.xaml"
            this.bStartupSettings.Click += new System.Windows.RoutedEventHandler(this.bStartupSettings_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.bStartupConn = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\screenStartup.xaml"
            this.bStartupConn.Click += new System.Windows.RoutedEventHandler(this.bStartupConn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.bStartupExit = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\screenStartup.xaml"
            this.bStartupExit.Click += new System.Windows.RoutedEventHandler(this.bStartupExit_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.lbStartupServers = ((System.Windows.Controls.ListBox)(target));
            
            #line 21 "..\..\..\screenStartup.xaml"
            this.lbStartupServers.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lbStartupServers_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.tbStartupUsername = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.tbStartupPassword = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 7:
            this.lStartupUsername = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.lStartupPassword = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.lStartupEcho = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.cbRememberUser = ((System.Windows.Controls.CheckBox)(target));
            
            #line 27 "..\..\..\screenStartup.xaml"
            this.cbRememberUser.Click += new System.Windows.RoutedEventHandler(this.cbRememberUser_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

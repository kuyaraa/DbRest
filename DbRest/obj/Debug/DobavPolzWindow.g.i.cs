﻿#pragma checksum "..\..\DobavPolzWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9E9BB543752B4B08E133F5BC2EFE4C3FDC4078FF2AB69F0EB7C47E6034FB3AFA"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using DbRest;
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


namespace DbRest {
    
    
    /// <summary>
    /// DobavPolzWindow
    /// </summary>
    public partial class DobavPolzWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\DobavPolzWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxPassword;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\DobavPolzWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxLogin;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\DobavPolzWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxTelefon;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\DobavPolzWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxName;
        
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
            System.Uri resourceLocater = new System.Uri("/DbRest;component/dobavpolzwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\DobavPolzWindow.xaml"
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
            
            #line 15 "..\..\DobavPolzWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TextBoxPassword = ((System.Windows.Controls.TextBox)(target));
            
            #line 16 "..\..\DobavPolzWindow.xaml"
            this.TextBoxPassword.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBoxPassword_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TextBoxLogin = ((System.Windows.Controls.TextBox)(target));
            
            #line 17 "..\..\DobavPolzWindow.xaml"
            this.TextBoxLogin.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBoxLogin_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TextBoxTelefon = ((System.Windows.Controls.TextBox)(target));
            
            #line 18 "..\..\DobavPolzWindow.xaml"
            this.TextBoxTelefon.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBoxTelefon_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.TextBoxName = ((System.Windows.Controls.TextBox)(target));
            
            #line 19 "..\..\DobavPolzWindow.xaml"
            this.TextBoxName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBoxName_TextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


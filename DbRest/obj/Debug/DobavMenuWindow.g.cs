﻿#pragma checksum "..\..\DobavMenuWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FBA71CA018DD69FAD4CD3DE4E3D18F09120D1CC24B023D101EF93BB65E506AC5"
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
    /// DobavMenuWindow
    /// </summary>
    public partial class DobavMenuWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\DobavMenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxKategoriya;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\DobavMenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxName;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\DobavMenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxIngredient;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\DobavMenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxCena;
        
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
            System.Uri resourceLocater = new System.Uri("/DbRest;component/dobavmenuwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\DobavMenuWindow.xaml"
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
            this.TextBoxKategoriya = ((System.Windows.Controls.TextBox)(target));
            
            #line 14 "..\..\DobavMenuWindow.xaml"
            this.TextBoxKategoriya.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBoxKategoriya_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TextBoxName = ((System.Windows.Controls.TextBox)(target));
            
            #line 15 "..\..\DobavMenuWindow.xaml"
            this.TextBoxName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBoxName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TextBoxIngredient = ((System.Windows.Controls.TextBox)(target));
            
            #line 16 "..\..\DobavMenuWindow.xaml"
            this.TextBoxIngredient.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBoxIngredient_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TextBoxCena = ((System.Windows.Controls.TextBox)(target));
            
            #line 17 "..\..\DobavMenuWindow.xaml"
            this.TextBoxCena.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBoxCena_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 18 "..\..\DobavMenuWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


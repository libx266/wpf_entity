#pragma checksum "..\..\..\Pages\SelectServicePage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "919CB69F5D2C251D7A0F2E9D82152A0AD554D14D37B53651F9A248482790A119"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LearnSchool.Components;
using LearnSchool.Pages;
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


namespace LearnSchool.Pages {
    
    
    /// <summary>
    /// SelectServicePage
    /// </summary>
    public partial class SelectServicePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\Pages\SelectServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer MainContainer;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Pages\SelectServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal LearnSchool.Components.ServiceControl ServiceInfo;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Pages\SelectServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CbClients;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Pages\SelectServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DpServiceDate;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Pages\SelectServicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbTime;
        
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
            System.Uri resourceLocater = new System.Uri("/LearnSchool;component/pages/selectservicepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\SelectServicePage.xaml"
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
            this.MainContainer = ((System.Windows.Controls.ScrollViewer)(target));
            return;
            case 2:
            this.ServiceInfo = ((LearnSchool.Components.ServiceControl)(target));
            return;
            case 3:
            this.CbClients = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.DpServiceDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.TbTime = ((System.Windows.Controls.TextBox)(target));
            
            #line 27 "..\..\..\Pages\SelectServicePage.xaml"
            this.TbTime.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TbTimeChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 28 "..\..\..\Pages\SelectServicePage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OrderService);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


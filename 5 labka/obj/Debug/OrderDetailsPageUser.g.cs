﻿#pragma checksum "..\..\OrderDetailsPageUser.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "47F8CD96010B75CE1420FCAD64EEA140DEFD8C96098162E1927E904019060344"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using _5_labka;


namespace _5_labka {
    
    
    /// <summary>
    /// OrderDetailsPageUser
    /// </summary>
    public partial class OrderDetailsPageUser : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\OrderDetailsPageUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid OrderDetailsDgr;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\OrderDetailsPageUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button dobav;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\OrderDetailsPageUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Tbx;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\OrderDetailsPageUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Cbx2;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\OrderDetailsPageUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Cbx3;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\OrderDetailsPageUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Cbx4;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\OrderDetailsPageUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Tbx2;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\OrderDetailsPageUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Tbx3;
        
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
            System.Uri resourceLocater = new System.Uri("/5 labka;component/orderdetailspageuser.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\OrderDetailsPageUser.xaml"
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
            this.OrderDetailsDgr = ((System.Windows.Controls.DataGrid)(target));
            
            #line 28 "..\..\OrderDetailsPageUser.xaml"
            this.OrderDetailsDgr.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.OrderDetailsDgr_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.dobav = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\OrderDetailsPageUser.xaml"
            this.dobav.Click += new System.Windows.RoutedEventHandler(this.dobav_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Tbx = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Cbx2 = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.Cbx3 = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.Cbx4 = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.Tbx2 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.Tbx3 = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


﻿#pragma checksum "..\..\..\Pages\OrderPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A44C085A5AA331FCCBDE02A76920572752A4BC50E0214048743FB93F6DBD1734"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using FinalCock.Pages;
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


namespace FinalCock.Pages {
    
    
    /// <summary>
    /// OrderPage
    /// </summary>
    public partial class OrderPage : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\Pages\OrderPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DgProduct;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Pages\OrderPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CmbPP;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Pages\OrderPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtCostOrder;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Pages\OrderPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtSaleOrder;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Pages\OrderPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtDateOrder;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Pages\OrderPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtDateDel;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Pages\OrderPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnRegOrder;
        
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
            System.Uri resourceLocater = new System.Uri("/FinalCock;component/pages/orderpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\OrderPage.xaml"
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
            this.DgProduct = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            
            #line 25 "..\..\..\Pages\OrderPage.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.CmbPP = ((System.Windows.Controls.ComboBox)(target));
            
            #line 34 "..\..\..\Pages\OrderPage.xaml"
            this.CmbPP.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CmbPP_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtCostOrder = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.txtSaleOrder = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.txtDateOrder = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.txtDateDel = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.BtnRegOrder = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\Pages\OrderPage.xaml"
            this.BtnRegOrder.Click += new System.Windows.RoutedEventHandler(this.BtnRegOrder_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


﻿#pragma checksum "..\..\..\Windows\AddProductWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "405E9708CE33373134C26446C524682BC01535CE7BB00CA8EB3C7C01CFBA3021"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using STP.Windows;
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


namespace STP.Windows {
    
    
    /// <summary>
    /// AddProductWindow
    /// </summary>
    public partial class AddProductWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 56 "..\..\..\Windows\AddProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_nameProduct;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\Windows\AddProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_priceProduct;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\Windows\AddProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cb_typeProduct;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\..\Windows\AddProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_subTerm;
        
        #line default
        #line hidden
        
        
        #line 138 "..\..\..\Windows\AddProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_AddProduct;
        
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
            System.Uri resourceLocater = new System.Uri("/STP;component/windows/addproductwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\AddProductWindow.xaml"
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
            this.tb_nameProduct = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.tb_priceProduct = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.cb_typeProduct = ((System.Windows.Controls.ComboBox)(target));
            
            #line 102 "..\..\..\Windows\AddProductWindow.xaml"
            this.cb_typeProduct.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cb_typeProduct_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.tb_subTerm = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.btn_AddProduct = ((System.Windows.Controls.Button)(target));
            
            #line 139 "..\..\..\Windows\AddProductWindow.xaml"
            this.btn_AddProduct.Click += new System.Windows.RoutedEventHandler(this.btn_AddProduct_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

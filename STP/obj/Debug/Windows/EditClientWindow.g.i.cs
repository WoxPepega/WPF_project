﻿#pragma checksum "..\..\..\Windows\EditClientWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C1B384AAD8C8050DF29E56C0DA9B02561BE9B2A53D713E8C5181F760ADEC70D8"
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
    /// EditClientWindow
    /// </summary>
    public partial class EditClientWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 42 "..\..\..\Windows\EditClientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cb_Status;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Windows\EditClientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cb_Manager;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\Windows\EditClientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_nameClient;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\Windows\EditClientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_AddClient;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\Windows\EditClientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lv_ClientProducts;
        
        #line default
        #line hidden
        
        
        #line 126 "..\..\..\Windows\EditClientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_addProduct;
        
        #line default
        #line hidden
        
        
        #line 135 "..\..\..\Windows\EditClientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_delProduct;
        
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
            System.Uri resourceLocater = new System.Uri("/STP;component/windows/editclientwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\EditClientWindow.xaml"
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
            this.cb_Status = ((System.Windows.Controls.ComboBox)(target));
            
            #line 43 "..\..\..\Windows\EditClientWindow.xaml"
            this.cb_Status.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cb_Status_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cb_Manager = ((System.Windows.Controls.ComboBox)(target));
            
            #line 52 "..\..\..\Windows\EditClientWindow.xaml"
            this.cb_Manager.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cb_Manager_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.tb_nameClient = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.btn_AddClient = ((System.Windows.Controls.Button)(target));
            
            #line 87 "..\..\..\Windows\EditClientWindow.xaml"
            this.btn_AddClient.Click += new System.Windows.RoutedEventHandler(this.btn_AddClient_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.lv_ClientProducts = ((System.Windows.Controls.ListView)(target));
            return;
            case 6:
            this.btn_addProduct = ((System.Windows.Controls.Button)(target));
            
            #line 127 "..\..\..\Windows\EditClientWindow.xaml"
            this.btn_addProduct.Click += new System.Windows.RoutedEventHandler(this.btn_addProduct_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btn_delProduct = ((System.Windows.Controls.Button)(target));
            
            #line 136 "..\..\..\Windows\EditClientWindow.xaml"
            this.btn_delProduct.Click += new System.Windows.RoutedEventHandler(this.btn_delProduct_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


﻿#pragma checksum "..\..\..\..\..\Views\Window\AutorizationWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94D6BCAAB9D439CA91BA491E7CCE6506346CC072"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using StockShop.Views.Window;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace StockShop.Views.Window {
    
    
    /// <summary>
    /// AutorizationWindow
    /// </summary>
    public partial class AutorizationWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\..\..\Views\Window\AutorizationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnDashWndw;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\..\Views\Window\AutorizationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnMaxWndw;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\..\Views\Window\AutorizationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnExtWndw;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\..\Views\Window\AutorizationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxbLog;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\..\Views\Window\AutorizationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox TxbPass;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\..\Views\Window\AutorizationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAuto;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\..\..\Views\Window\AutorizationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnReg;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.12.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/StockShop;component/views/window/autorizationwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\Window\AutorizationWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.12.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 9 "..\..\..\..\..\Views\Window\AutorizationWindow.xaml"
            ((StockShop.Views.Window.AutorizationWindow)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BtnDashWndw = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\..\..\Views\Window\AutorizationWindow.xaml"
            this.BtnDashWndw.Click += new System.Windows.RoutedEventHandler(this.BtnDashWndw_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnMaxWndw = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\..\..\Views\Window\AutorizationWindow.xaml"
            this.BtnMaxWndw.Click += new System.Windows.RoutedEventHandler(this.BtnMaxWndw_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BtnExtWndw = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\..\..\Views\Window\AutorizationWindow.xaml"
            this.BtnExtWndw.Click += new System.Windows.RoutedEventHandler(this.BtnExtWndw_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.TxbLog = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.TxbPass = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 7:
            this.BtnAuto = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\..\..\Views\Window\AutorizationWindow.xaml"
            this.BtnAuto.Click += new System.Windows.RoutedEventHandler(this.BtnAuto_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.BtnReg = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\..\..\..\Views\Window\AutorizationWindow.xaml"
            this.BtnReg.Click += new System.Windows.RoutedEventHandler(this.BtnReg_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


﻿#pragma checksum "..\..\..\..\..\Views\Pages\MainPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17C431FDE9E1936A2C76E9870BE00733E74871F7"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using StockShop.Views.Pages;
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


namespace StockShop.Views.Pages {
    
    
    /// <summary>
    /// MainPage
    /// </summary>
    public partial class MainPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\..\..\..\Views\Pages\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnMain;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\..\Views\Pages\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnIndicators;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\..\Views\Pages\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnProduct;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\..\Views\Pages\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnRep;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\..\Views\Pages\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnSupplier;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\..\Views\Pages\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnUsers;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\..\Views\Pages\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame FrmMainPage;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.13.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/StockShop;component/views/pages/mainpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\Pages\MainPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.13.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.BtnMain = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\..\..\Views\Pages\MainPage.xaml"
            this.BtnMain.Click += new System.Windows.RoutedEventHandler(this.BtnMain_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BtnIndicators = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\..\..\Views\Pages\MainPage.xaml"
            this.BtnIndicators.Click += new System.Windows.RoutedEventHandler(this.BtnIndicators_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnProduct = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\..\..\Views\Pages\MainPage.xaml"
            this.BtnProduct.Click += new System.Windows.RoutedEventHandler(this.BtnProduct_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BtnRep = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.BtnSupplier = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.BtnUsers = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\..\..\Views\Pages\MainPage.xaml"
            this.BtnUsers.Click += new System.Windows.RoutedEventHandler(this.BtnUsers_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.FrmMainPage = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


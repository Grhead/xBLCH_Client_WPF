﻿#pragma checksum "..\..\..\..\Pages\AuthStartView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C88C5DADECF4DBAC696278A7696A5D3462A51307"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Client_BLCHxVote_WPF.Views;
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


namespace Client_BLCHxVote_WPF.Views {
    
    
    /// <summary>
    /// AuthStartView
    /// </summary>
    public partial class AuthStartView : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\..\Pages\AuthStartView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TitleAddress;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\Pages\AuthStartView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BlockAdress;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\Pages\AuthStartView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TitlePass;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\Pages\AuthStartView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BlockPass;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\..\Pages\AuthStartView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TitleCode;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\..\Pages\AuthStartView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BlockCode;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\..\Pages\AuthStartView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonSubmit;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\..\..\Pages\AuthStartView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonRepeat;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Client_BLCHxVote_WPF;component/pages/authstartview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\AuthStartView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.TitleAddress = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.BlockAdress = ((System.Windows.Controls.TextBox)(target));
            
            #line 42 "..\..\..\..\Pages\AuthStartView.xaml"
            this.BlockAdress.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.BlockAdress_PreviewKeyDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TitlePass = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.BlockPass = ((System.Windows.Controls.TextBox)(target));
            
            #line 64 "..\..\..\..\Pages\AuthStartView.xaml"
            this.BlockPass.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.BlockAdress_PreviewKeyDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.TitleCode = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.BlockCode = ((System.Windows.Controls.TextBox)(target));
            
            #line 86 "..\..\..\..\Pages\AuthStartView.xaml"
            this.BlockCode.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.BlockAdress_PreviewKeyDown);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ButtonSubmit = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.ButtonRepeat = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

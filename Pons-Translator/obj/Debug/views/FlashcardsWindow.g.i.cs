﻿#pragma checksum "..\..\..\views\FlashcardsWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A01BE8B3E7B9D1D03ABAC658D8A03FC8669C7661"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using Pons_Translator.views;
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


namespace Pons_Translator.views {
    
    
    /// <summary>
    /// FlashcardsWindow
    /// </summary>
    public partial class FlashcardsWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\views\FlashcardsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbCategories;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\views\FlashcardsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblCardContent;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\views\FlashcardsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnFlip;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\views\FlashcardsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCorrect;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\views\FlashcardsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnWrong;
        
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
            System.Uri resourceLocater = new System.Uri("/Pons-Translator;component/views/flashcardswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\views\FlashcardsWindow.xaml"
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
            this.cbCategories = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.lblCardContent = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.btnFlip = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\views\FlashcardsWindow.xaml"
            this.btnFlip.Click += new System.Windows.RoutedEventHandler(this.btnFlip_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnCorrect = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\views\FlashcardsWindow.xaml"
            this.btnCorrect.Click += new System.Windows.RoutedEventHandler(this.btnCorrect_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnWrong = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\views\FlashcardsWindow.xaml"
            this.btnWrong.Click += new System.Windows.RoutedEventHandler(this.btnWrong_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


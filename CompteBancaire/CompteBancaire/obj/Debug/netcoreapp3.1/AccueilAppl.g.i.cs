﻿#pragma checksum "..\..\..\AccueilAppl.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85725E77796080B0E4710D319F47B9DA763C1EB3"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using CompteBancaire;
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


namespace CompteBancaire {
    
    
    /// <summary>
    /// AccueilAppl
    /// </summary>
    public partial class AccueilAppl : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\AccueilAppl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabIdent;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\AccueilAppl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame FrameNavigation;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/CompteBancaire;component/accueilappl.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AccueilAppl.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\..\AccueilAppl.xaml"
            ((CompteBancaire.AccueilAppl)(target)).Loaded += new System.Windows.RoutedEventHandler(this.onLoad);
            
            #line default
            #line hidden
            return;
            case 2:
            this.LabIdent = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            
            #line 24 "..\..\..\AccueilAppl.xaml"
            ((System.Windows.Controls.ListViewItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.ListViewItem_Selected_3);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 31 "..\..\..\AccueilAppl.xaml"
            ((System.Windows.Controls.ListViewItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.ListViewItem_Selected);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 37 "..\..\..\AccueilAppl.xaml"
            ((System.Windows.Controls.ListViewItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.ListViewItem_Selected_1);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 43 "..\..\..\AccueilAppl.xaml"
            ((System.Windows.Controls.ListViewItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.ListViewItem_Selected_2);
            
            #line default
            #line hidden
            return;
            case 7:
            this.FrameNavigation = ((System.Windows.Controls.Frame)(target));
            
            #line 62 "..\..\..\AccueilAppl.xaml"
            this.FrameNavigation.Navigating += new System.Windows.Navigation.NavigatingCancelEventHandler(this.FrameNavigation_OnNavigating);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

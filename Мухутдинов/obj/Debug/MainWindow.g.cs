﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "681D4ED9AC6BEB4E85DCCF1C1D286D0E4BD8102FE38624FF15B95A5A797D83BA"
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
using Мухутдинов;


namespace Мухутдинов {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid panelHearder;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid sidePanel;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListViewItem HearderMenu;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListViewItem HearderAvtory;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListViewItem HearderKnigi;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListViewItem HearderIzdatelstvo;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListViewItem Exit;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame Main;
        
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
            System.Uri resourceLocater = new System.Uri("/Мухутдинов;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.panelHearder = ((System.Windows.Controls.Grid)(target));
            
            #line 10 "..\..\MainWindow.xaml"
            this.panelHearder.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.panelHearder_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.sidePanel = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            
            #line 19 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.HearderMenu = ((System.Windows.Controls.ListViewItem)(target));
            
            #line 34 "..\..\MainWindow.xaml"
            this.HearderMenu.Selected += new System.Windows.RoutedEventHandler(this.HearderMenu_Selected);
            
            #line default
            #line hidden
            return;
            case 5:
            this.HearderAvtory = ((System.Windows.Controls.ListViewItem)(target));
            
            #line 42 "..\..\MainWindow.xaml"
            this.HearderAvtory.Selected += new System.Windows.RoutedEventHandler(this.HearderAvtory_Selected);
            
            #line default
            #line hidden
            return;
            case 6:
            this.HearderKnigi = ((System.Windows.Controls.ListViewItem)(target));
            
            #line 51 "..\..\MainWindow.xaml"
            this.HearderKnigi.Selected += new System.Windows.RoutedEventHandler(this.HearderKnigi_Selected);
            
            #line default
            #line hidden
            return;
            case 7:
            this.HearderIzdatelstvo = ((System.Windows.Controls.ListViewItem)(target));
            
            #line 59 "..\..\MainWindow.xaml"
            this.HearderIzdatelstvo.Selected += new System.Windows.RoutedEventHandler(this.HearderIzdatelstvo_Selected);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 67 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.ListViewItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.ListViewItem_Selected_1);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 75 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.ListViewItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.ListViewItem_Selected);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 83 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.ListViewItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.ListViewItem_Selected_2);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 99 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.ListViewItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.ListViewItem_Selected_3);
            
            #line default
            #line hidden
            return;
            case 12:
            this.Exit = ((System.Windows.Controls.ListViewItem)(target));
            
            #line 107 "..\..\MainWindow.xaml"
            this.Exit.Selected += new System.Windows.RoutedEventHandler(this.Exit_Selected);
            
            #line default
            #line hidden
            return;
            case 13:
            this.Main = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


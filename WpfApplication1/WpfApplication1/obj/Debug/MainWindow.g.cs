﻿#pragma checksum "..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "CB273F38D853EA70374774CF222A039819B02068"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
using WpfApplication1;


namespace WpfApplication1 {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WpfApplication1.MainWindow mainWindow;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement mePlayer;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image image1;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkBox;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApplication1;component/mainwindow.xaml", System.UriKind.Relative);
            
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
            this.mainWindow = ((WpfApplication1.MainWindow)(target));
            return;
            case 2:
            this.mePlayer = ((System.Windows.Controls.MediaElement)(target));
            return;
            case 3:
            
            #line 15 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Slider)(target)).ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.ValueChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.image1 = ((System.Windows.Controls.Image)(target));
            
            #line 19 "..\..\MainWindow.xaml"
            this.image1.MouseLeave += new System.Windows.Input.MouseEventHandler(this.image1_MouseLeave);
            
            #line default
            #line hidden
            
            #line 19 "..\..\MainWindow.xaml"
            this.image1.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.image1_MouseDown);
            
            #line default
            #line hidden
            
            #line 19 "..\..\MainWindow.xaml"
            this.image1.MouseEnter += new System.Windows.Input.MouseEventHandler(this.image1_MouseEnter);
            
            #line default
            #line hidden
            return;
            case 5:
            this.checkBox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 24 "..\..\MainWindow.xaml"
            this.checkBox.Checked += new System.Windows.RoutedEventHandler(this.checkBox_Checked);
            
            #line default
            #line hidden
            
            #line 24 "..\..\MainWindow.xaml"
            this.checkBox.Unchecked += new System.Windows.RoutedEventHandler(this.checkBox_Unchecked);
            
            #line default
            #line hidden
            
            #line 25 "..\..\MainWindow.xaml"
            this.checkBox.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.checkBox_MouseDown);
            
            #line default
            #line hidden
            
            #line 25 "..\..\MainWindow.xaml"
            this.checkBox.MouseEnter += new System.Windows.Input.MouseEventHandler(this.checkBox_MouseEnter);
            
            #line default
            #line hidden
            
            #line 25 "..\..\MainWindow.xaml"
            this.checkBox.MouseLeave += new System.Windows.Input.MouseEventHandler(this.checkBox_MouseLeave);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


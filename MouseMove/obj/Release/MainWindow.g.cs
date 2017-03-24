﻿#pragma checksum "..\..\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "684B751817B1C78D6B02031EBF24DEA8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MouseMove;
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


namespace MouseMove {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 68 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel TimerStackPanel;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TimerLabelHours;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TimerLabelMinutes;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TimerLabelSeconds;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GroupBox OptionsGroupBox;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NumberOfActionsMinValueTextBox;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NumberOfActionsMaxValueTextBox;
        
        #line default
        #line hidden
        
        
        #line 126 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox IntervalTextBox;
        
        #line default
        #line hidden
        
        
        #line 136 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GroupBox KeyboardGroupbox;
        
        #line default
        #line hidden
        
        
        #line 138 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox IsKeyboardIncluded;
        
        #line default
        #line hidden
        
        
        #line 156 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox KeyboardInputTextBox;
        
        #line default
        #line hidden
        
        
        #line 168 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button StartButton;
        
        #line default
        #line hidden
        
        
        #line 172 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button StopButton;
        
        #line default
        #line hidden
        
        
        #line 178 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar TimeProgressBar;
        
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
            System.Uri resourceLocater = new System.Uri("/InactivityPreventer;component/mainwindow.xaml", System.UriKind.Relative);
            
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
            this.TimerStackPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            this.TimerLabelHours = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.TimerLabelMinutes = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.TimerLabelSeconds = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.OptionsGroupBox = ((System.Windows.Controls.GroupBox)(target));
            return;
            case 6:
            this.NumberOfActionsMinValueTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 107 "..\..\MainWindow.xaml"
            this.NumberOfActionsMinValueTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.NumberOfActionsMinValueTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.NumberOfActionsMaxValueTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 113 "..\..\MainWindow.xaml"
            this.NumberOfActionsMaxValueTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.NumericTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.IntervalTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 125 "..\..\MainWindow.xaml"
            this.IntervalTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.NumericTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.KeyboardGroupbox = ((System.Windows.Controls.GroupBox)(target));
            return;
            case 10:
            this.IsKeyboardIncluded = ((System.Windows.Controls.CheckBox)(target));
            
            #line 139 "..\..\MainWindow.xaml"
            this.IsKeyboardIncluded.Checked += new System.Windows.RoutedEventHandler(this.IsKeyboardIncluded_Checked);
            
            #line default
            #line hidden
            
            #line 140 "..\..\MainWindow.xaml"
            this.IsKeyboardIncluded.Unchecked += new System.Windows.RoutedEventHandler(this.IsKeyboardIncluded_Unchecked);
            
            #line default
            #line hidden
            return;
            case 11:
            this.KeyboardInputTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.StartButton = ((System.Windows.Controls.Button)(target));
            
            #line 169 "..\..\MainWindow.xaml"
            this.StartButton.Click += new System.Windows.RoutedEventHandler(this.StartButton_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.StopButton = ((System.Windows.Controls.Button)(target));
            
            #line 173 "..\..\MainWindow.xaml"
            this.StopButton.Click += new System.Windows.RoutedEventHandler(this.StopButton_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.TimeProgressBar = ((System.Windows.Controls.ProgressBar)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


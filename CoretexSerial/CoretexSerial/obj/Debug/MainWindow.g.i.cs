﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "09177654CBF6BD9BB514F0239CEE11D46EF2161BE5368B5ED6BE446C23CAA513"
//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     런타임 버전:4.0.30319.42000
//
//     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
//     이러한 변경 내용이 손실됩니다.
// </auto-generated>
//------------------------------------------------------------------------------

using CoretexSerial;
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


namespace CoretexSerial {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComPortComboBox;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox BaudLateComboBox;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Connect_Button;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton HexButton;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton AsciiButton;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox SendStringNoti;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox RecieveStringNoti;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border TextBlockBorder;
        
        #line default
        #line hidden
        
        
        #line 115 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock SerialResultBlock;
        
        #line default
        #line hidden
        
        
        #line 122 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MainTextBox;
        
        #line default
        #line hidden
        
        
        #line 138 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Transmit_box;
        
        #line default
        #line hidden
        
        
        #line 143 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Send_Button;
        
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
            System.Uri resourceLocater = new System.Uri("/CoretexSerial;component/mainwindow.xaml", System.UriKind.Relative);
            
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
            this.ComPortComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 33 "..\..\MainWindow.xaml"
            this.ComPortComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComPortComboBox_SelectionChanged);
            
            #line default
            #line hidden
            
            #line 34 "..\..\MainWindow.xaml"
            this.ComPortComboBox.DropDownOpened += new System.EventHandler(this.ComPortComboBox_DropDownOpened);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BaudLateComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 45 "..\..\MainWindow.xaml"
            this.BaudLateComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.BaudLateComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Connect_Button = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\MainWindow.xaml"
            this.Connect_Button.Click += new System.Windows.RoutedEventHandler(this.Connect_Button_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.HexButton = ((System.Windows.Controls.RadioButton)(target));
            
            #line 73 "..\..\MainWindow.xaml"
            this.HexButton.Checked += new System.Windows.RoutedEventHandler(this.HexButton_Checked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.AsciiButton = ((System.Windows.Controls.RadioButton)(target));
            
            #line 81 "..\..\MainWindow.xaml"
            this.AsciiButton.Checked += new System.Windows.RoutedEventHandler(this.AsciiButton_Checked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.SendStringNoti = ((System.Windows.Controls.CheckBox)(target));
            
            #line 92 "..\..\MainWindow.xaml"
            this.SendStringNoti.Checked += new System.Windows.RoutedEventHandler(this.SendStringNoti_Checked);
            
            #line default
            #line hidden
            
            #line 93 "..\..\MainWindow.xaml"
            this.SendStringNoti.Unchecked += new System.Windows.RoutedEventHandler(this.SendStringNoti_Unchecked);
            
            #line default
            #line hidden
            return;
            case 7:
            this.RecieveStringNoti = ((System.Windows.Controls.CheckBox)(target));
            
            #line 100 "..\..\MainWindow.xaml"
            this.RecieveStringNoti.Checked += new System.Windows.RoutedEventHandler(this.RecieveStringNoti_Checked);
            
            #line default
            #line hidden
            
            #line 101 "..\..\MainWindow.xaml"
            this.RecieveStringNoti.Unchecked += new System.Windows.RoutedEventHandler(this.RecieveStringNoti_Unchecked);
            
            #line default
            #line hidden
            return;
            case 8:
            this.TextBlockBorder = ((System.Windows.Controls.Border)(target));
            return;
            case 9:
            this.SerialResultBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.MainTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.Transmit_box = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.Send_Button = ((System.Windows.Controls.Button)(target));
            
            #line 146 "..\..\MainWindow.xaml"
            this.Send_Button.Click += new System.Windows.RoutedEventHandler(this.Send_Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


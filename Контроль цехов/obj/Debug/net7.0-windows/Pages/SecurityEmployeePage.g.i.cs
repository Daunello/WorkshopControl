﻿#pragma checksum "..\..\..\..\Pages\SecurityEmployeePage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D765A150B06068C4F0EE5220F95A7DAE832E1864"
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
using УППО_Пропуски.Pages;


namespace УППО_Пропуски.Pages {
    
    
    /// <summary>
    /// SecurityEmployeePage
    /// </summary>
    public partial class SecurityEmployeePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\..\..\Pages\SecurityEmployeePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid EmployeesDataGrid;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\..\Pages\SecurityEmployeePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CanVisitOtherWorkshops;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\..\Pages\SecurityEmployeePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PasswordEmployeeTextBox;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\..\Pages\SecurityEmployeePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox DivisionEmployeeComboBox;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\..\Pages\SecurityEmployeePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox StatusEmployeeTextBox;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\..\Pages\SecurityEmployeePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveChangesButton;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\..\Pages\SecurityEmployeePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CancelChangesButton;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\..\Pages\SecurityEmployeePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox EmployeesListBox;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\..\Pages\SecurityEmployeePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchTextBox;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\..\Pages\SecurityEmployeePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock SearchTextBlock;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\..\..\Pages\SecurityEmployeePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button QuitButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Контроль цехов;V1.0.0.0;component/pages/securityemployeepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\SecurityEmployeePage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 9 "..\..\..\..\Pages\SecurityEmployeePage.xaml"
            ((УППО_Пропуски.Pages.SecurityEmployeePage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.EmployeesDataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 34 "..\..\..\..\Pages\SecurityEmployeePage.xaml"
            this.EmployeesDataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.EmployeesDataGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.CanVisitOtherWorkshops = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 4:
            this.PasswordEmployeeTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.DivisionEmployeeComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.StatusEmployeeTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.SaveChangesButton = ((System.Windows.Controls.Button)(target));
            
            #line 87 "..\..\..\..\Pages\SecurityEmployeePage.xaml"
            this.SaveChangesButton.Click += new System.Windows.RoutedEventHandler(this.SaveChangesButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.CancelChangesButton = ((System.Windows.Controls.Button)(target));
            
            #line 90 "..\..\..\..\Pages\SecurityEmployeePage.xaml"
            this.CancelChangesButton.Click += new System.Windows.RoutedEventHandler(this.CancelChangesButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.EmployeesListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 10:
            this.SearchTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 105 "..\..\..\..\Pages\SecurityEmployeePage.xaml"
            this.SearchTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.SearchTextBox_TextChanged);
            
            #line default
            #line hidden
            
            #line 105 "..\..\..\..\Pages\SecurityEmployeePage.xaml"
            this.SearchTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.SearchTextBlock_GotFocus);
            
            #line default
            #line hidden
            
            #line 105 "..\..\..\..\Pages\SecurityEmployeePage.xaml"
            this.SearchTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.SearchTextBlock_LostFocus);
            
            #line default
            #line hidden
            return;
            case 11:
            this.SearchTextBlock = ((System.Windows.Controls.TextBlock)(target));
            
            #line 106 "..\..\..\..\Pages\SecurityEmployeePage.xaml"
            this.SearchTextBlock.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.SearchTextBlock_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 12:
            this.QuitButton = ((System.Windows.Controls.Button)(target));
            
            #line 108 "..\..\..\..\Pages\SecurityEmployeePage.xaml"
            this.QuitButton.Click += new System.Windows.RoutedEventHandler(this.QuitButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


﻿#pragma checksum "..\..\ThemMoi.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4AB5AA48A8D422C32AC151429DC21C2E53D059F6C82D578BB4B1BD6C83237448"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using QL_Nhanvien_2;
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


namespace QL_Nhanvien_2 {
    
    
    /// <summary>
    /// ThemMoi
    /// </summary>
    public partial class ThemMoi : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\ThemMoi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtMaNhanVien;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\ThemMoi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtHoTen;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\ThemMoi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTienLuongNgay;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\ThemMoi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSoNgayLamViec;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\ThemMoi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton radNam;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\ThemMoi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton radNu;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\ThemMoi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpkNgaySinh;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\ThemMoi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDongForm;
        
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
            System.Uri resourceLocater = new System.Uri("/QL_Nhanvien_2;component/themmoi.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ThemMoi.xaml"
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
            this.txtMaNhanVien = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtHoTen = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtTienLuongNgay = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtSoNgayLamViec = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.radNam = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 6:
            this.radNu = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 7:
            this.dpkNgaySinh = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 8:
            this.btnDongForm = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\ThemMoi.xaml"
            this.btnDongForm.Click += new System.Windows.RoutedEventHandler(this.btnDongForm_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

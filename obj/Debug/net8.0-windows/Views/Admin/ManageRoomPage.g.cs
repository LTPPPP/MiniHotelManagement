﻿#pragma checksum "..\..\..\..\..\Views\Admin\ManageRoomPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92F4F18B05DC71549ACC94302E81F29F2FFA9B55"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Assignment02.Utilities;
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


namespace Assignment02.Views.Admin {
    
    
    /// <summary>
    /// ManageRoomPage
    /// </summary>
    public partial class ManageRoomPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 50 "..\..\..\..\..\Views\Admin\ManageRoomPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox idTxt;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\..\..\Views\Admin\ManageRoomPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox roomNumberTxt;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\..\..\Views\Admin\ManageRoomPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox descriptionTxt;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\..\..\Views\Admin\ManageRoomPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox capacityTxt;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\..\..\Views\Admin\ManageRoomPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox priceTxt;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\..\..\Views\Admin\ManageRoomPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox statusComboBox;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\..\..\Views\Admin\ManageRoomPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addBtn;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\..\..\Views\Admin\ManageRoomPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button updateBtn;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\..\..\Views\Admin\ManageRoomPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button deleteBtn;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.10.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Assignment02;component/views/admin/manageroompage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\Admin\ManageRoomPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.10.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.idTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.roomNumberTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.descriptionTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.capacityTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.priceTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.statusComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.addBtn = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.updateBtn = ((System.Windows.Controls.Button)(target));
            return;
            case 9:
            this.deleteBtn = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


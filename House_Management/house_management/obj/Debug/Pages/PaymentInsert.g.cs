﻿#pragma checksum "..\..\..\Pages\PaymentInsert.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "90AA3D4CEFE28D7B33DD8AA15F789E72128470BBDD769915570BAE963D03C573"
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
using house_management.Pages;


namespace house_management.Pages {
    
    
    /// <summary>
    /// PaymentInsert
    /// </summary>
    public partial class PaymentInsert : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\Pages\PaymentInsert.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Insert;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Pages\PaymentInsert.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Back;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Pages\PaymentInsert.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox TypeOfPaymentcmb;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Pages\PaymentInsert.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbSquarePrice;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Pages\PaymentInsert.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbLodgersPrice;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\Pages\PaymentInsert.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbPaymentAmount;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\Pages\PaymentInsert.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dtSupposedDatePayment;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\Pages\PaymentInsert.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dtDateOfPayment;
        
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
            System.Uri resourceLocater = new System.Uri("/house_management;component/pages/paymentinsert.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\PaymentInsert.xaml"
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
            this.Insert = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\Pages\PaymentInsert.xaml"
            this.Insert.Click += new System.Windows.RoutedEventHandler(this.Insert_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Back = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\Pages\PaymentInsert.xaml"
            this.Back.Click += new System.Windows.RoutedEventHandler(this.Back_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TypeOfPaymentcmb = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.txbSquarePrice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txbLodgersPrice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txbPaymentAmount = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.dtSupposedDatePayment = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 8:
            this.dtDateOfPayment = ((System.Windows.Controls.DatePicker)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


#pragma checksum "..\..\..\..\Views\ClothesView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D03259C45ADE9FAA73100A2EDC2A858CD6D24D71"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MulitipleViews.Views;
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


namespace MulitipleViews.Views {
    
    
    /// <summary>
    /// ClothesView
    /// </summary>
    public partial class ClothesView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\..\Views\ClothesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox LeftListBox;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\Views\ClothesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox articleTypeCb;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\Views\ClothesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox articlesizeCb;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\Views\ClothesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox genderCb;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\Views\ClothesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbox1;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\..\Views\ClothesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbox2;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\Views\ClothesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbox3;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\Views\ClothesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button savebtn;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MulitipleViews;component/views/clothesview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\ClothesView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.LeftListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 2:
            this.articleTypeCb = ((System.Windows.Controls.ComboBox)(target));
            
            #line 30 "..\..\..\..\Views\ClothesView.xaml"
            this.articleTypeCb.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ClothType_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.articlesizeCb = ((System.Windows.Controls.ComboBox)(target));
            
            #line 36 "..\..\..\..\Views\ClothesView.xaml"
            this.articlesizeCb.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ClothSize_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.genderCb = ((System.Windows.Controls.ComboBox)(target));
            
            #line 44 "..\..\..\..\Views\ClothesView.xaml"
            this.genderCb.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Gender_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtbox1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtbox2 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txtbox3 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.savebtn = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\..\..\Views\ClothesView.xaml"
            this.savebtn.Click += new System.Windows.RoutedEventHandler(this.Savebtn_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 58 "..\..\..\..\Views\ClothesView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Donatebtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


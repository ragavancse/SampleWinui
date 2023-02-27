// Copyright (c) Microsoft Corporation and Contributors.
// Licensed under the MIT License.

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Input;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace SampleWinui.CommonControls
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PaginationControl : UserControl
    {
        public PaginationControl()
        {
            this.InitializeComponent();
        }

        #region Event Handlers

        private void btnFirst_Click(object sender, RoutedEventArgs e)
        {
            FirstPageCommand?.Execute(null);
        }

        private void btnPrev_Click(object sender, RoutedEventArgs e)
        {
            PrevPageCommand?.Execute(null);
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            NextPageCommand?.Execute(null);
        }

        private void btnLast_Click(object sender, RoutedEventArgs e)
        {
            LastPageCommand?.Execute(null);
        }

        #endregion Event Handlers

        #region Dependency Properties

        public int CurrentPage
        {
            get { return (int)GetValue(CurrentPageProperty); }
            set { SetValue(CurrentPageProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CurrentPage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CurrentPageProperty =
            DependencyProperty.Register("CurrentPage", typeof(int), typeof(PaginationControl), new PropertyMetadata(0));

        public string PageSize
        {
            get { return (string)GetValue(PageSizeProperty); }
            set { SetValue(PageSizeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CurrentPage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PageSizeProperty =
            DependencyProperty.Register("PageSize", typeof(string), typeof(PaginationControl), new PropertyMetadata(string.Empty));

        public List<string> PageSizeList
        {
            get { return (List<string>)GetValue(PageSizeListProperty); }
            set { SetValue(PageSizeListProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CurrentPage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PageSizeListProperty =
            DependencyProperty.Register("PageSizeList", typeof(List<int>), typeof(PaginationControl), new PropertyMetadata(null));

        public int TotalPage
        {
            get { return (int)GetValue(TotalPageProperty); }
            set { SetValue(TotalPageProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TotalPage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TotalPageProperty =
            DependencyProperty.Register("TotalPage", typeof(int), typeof(PaginationControl), new PropertyMetadata(0));

        public string CurrentPageStart
        {
            get { return (string)GetValue(CurrentPageStartProperty); }
            set { SetValue(CurrentPageStartProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TotalPage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CurrentPageStartProperty =
            DependencyProperty.Register("CurrentPageStart", typeof(string), typeof(PaginationControl), new PropertyMetadata(string.Empty));

        public string CurrentPageEnd
        {
            get { return (string)GetValue(CurrentPageEndProperty); }
            set { SetValue(CurrentPageEndProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TotalPage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CurrentPageEndProperty =
            DependencyProperty.Register("CurrentPageEnd", typeof(string), typeof(PaginationControl), new PropertyMetadata(string.Empty));

        public string TotalItems
        {
            get { return (string)GetValue(TotalItemsProperty); }
            set { SetValue(TotalItemsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TotalPage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TotalItemsProperty =
            DependencyProperty.Register("TotalItems", typeof(string), typeof(PaginationControl), new PropertyMetadata(string.Empty));

        public ICommand FirstPageCommand
        {
            get { return (ICommand)GetValue(FirstPageCommandProperty); }
            set { SetValue(FirstPageCommandProperty, value); }
        }

        public static readonly DependencyProperty FirstPageCommandProperty =
        DependencyProperty.Register(
        "FirstPageCommand",
        typeof(ICommand),
        typeof(PaginationControl), new PropertyMetadata(null));

        public ICommand PrevPageCommand
        {
            get { return (ICommand)GetValue(PrevPageCommandProperty); }
            set { SetValue(PrevPageCommandProperty, value); }
        }

        public static readonly DependencyProperty PrevPageCommandProperty =
        DependencyProperty.Register(
        "PrevPageCommand",
        typeof(ICommand),
        typeof(PaginationControl), new PropertyMetadata(null));

        public ICommand NextPageCommand
        {
            get { return (ICommand)GetValue(NextPageCommandProperty); }
            set { SetValue(NextPageCommandProperty, value); }
        }

        public static readonly DependencyProperty NextPageCommandProperty =
        DependencyProperty.Register(
        "NextPageCommand",
        typeof(ICommand),
        typeof(PaginationControl), new PropertyMetadata(null));

        public ICommand LastPageCommand
        {
            get { return (ICommand)GetValue(LastPageCommandProperty); }
            set { SetValue(LastPageCommandProperty, value); }
        }

        public static readonly DependencyProperty LastPageCommandProperty =
        DependencyProperty.Register(
        "LastPageCommand",
        typeof(ICommand),
        typeof(PaginationControl), new PropertyMetadata(null));

        //public bool IsFirstPageButtonEnable
        //{
        //    get { return (bool)GetValue(IsFirstPageButtonEnableProperty); }
        //    set { SetValue(IsFirstPageButtonEnableProperty, value); }
        //}

        //public static readonly DependencyProperty IsFirstPageButtonEnableProperty =
        //DependencyProperty.Register(
        //"IsFirstPageButtonEnable",
        //typeof(bool),
        //typeof(PaginationControl), new PropertyMetadata(true));

        //public bool IsPrevPageButtonEnable
        //{
        //    get { return (bool)GetValue(IsPrevPageButtonEnableProperty); }
        //    set { SetValue(IsPrevPageButtonEnableProperty, value); }
        //}

        //public static readonly DependencyProperty IsPrevPageButtonEnableProperty =
        //DependencyProperty.Register(
        //"IsPrevPageButtonEnable",
        //typeof(bool),
        //typeof(PaginationControl), new PropertyMetadata(true));

        //public bool IsNextPageButtonEnable
        //{
        //    get { return (bool)GetValue(IsNextPageButtonEnableProperty); }
        //    set { SetValue(IsNextPageButtonEnableProperty, value); }
        //}

        //public static readonly DependencyProperty IsNextPageButtonEnableProperty =
        //DependencyProperty.Register(
        //"IsNextPageButtonEnable",
        //typeof(bool),
        //typeof(PaginationControl), new PropertyMetadata(true));

        //public bool IsLastPageButtonEnable
        //{
        //    get { return (bool)GetValue(IsLastPageButtonEnableProperty); }
        //    set { SetValue(IsLastPageButtonEnableProperty, value); }
        //}

        //public static readonly DependencyProperty IsLastPageButtonEnableProperty =
        //DependencyProperty.Register(
        //"IsLastPageButtonEnable",
        //typeof(bool),
        //typeof(PaginationControl), new PropertyMetadata(true));

        #endregion Dependency Properties
    }
}

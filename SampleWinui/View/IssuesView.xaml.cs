// Copyright (c) Microsoft Corporation and Contributors.
// Licensed under the MIT License.

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using SampleWinui.ChildWindowControls;
using SampleWinui.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace SampleWinui.View
{
    public sealed partial class IssuesView : UserControl
    {
        IssuesViewModel viewModel;

        ChildWindow window = null;
        ContentDialog contentDialog = null;

        public IssuesView()
        {
            this.InitializeComponent();
            viewModel = new IssuesViewModel();
            this.DataContext = viewModel;
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            window = new ChildWindow(); 
            IssuesSubVIew issuesSubVIew = new IssuesSubVIew();
            issuesSubVIew.DataContext= viewModel;
            issuesSubVIew.YesButton1.Click += YesButton_Click;
            issuesSubVIew.NoButton1.Click += YesButton_Click;
            issuesSubVIew.text1.Text = "You have marked " + viewModel.SelectedItemsList.Count() + " selcted items are worked,are you sure?";
            window.SetContent(issuesSubVIew);
            window.SetTitle("By saving you will mark " + viewModel.SelectedItemsList.Count() + " item to as worked.Are you sure?");
            window.Activate();
        }

        private void YesButton_Click(object sender, RoutedEventArgs e)
        {
            window.Close();

        }
    }
}

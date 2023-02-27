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
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace SampleWinui.View
{
    public sealed partial class IssuesView : UserControl
    {
        public IssuesView()
        {
            this.InitializeComponent();
        }
       
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            IssuesSubVIew issue = new IssuesSubVIew();
            ContentDialog contentDialog = new ContentDialog
            {
                Content = issue,
                DataContext=issue.DataContext,
                CloseButtonText= "NO",
            };
            contentDialog.XamlRoot = this.XamlRoot;
             var result=  await contentDialog.ShowAsync();
        }
    }
}

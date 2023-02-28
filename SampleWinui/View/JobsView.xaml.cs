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
    public sealed partial class JobsView : UserControl
    {
        public JobsView()
        {
            this.InitializeComponent();
        }

        private void Grid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            var mg = MainGrid.ActualWidth;
            var tl = TaskList.ActualWidth;
            var lv = logView.ActualWidth;
           if (MainGrid.ActualWidth < 1500)
            {
                Grid.SetRow(logView, 1);
                Grid.SetColumn(logView, 0);
                Grid.SetColumnSpan(logView, 2);
                Grid.SetColumnSpan(TaskList, 2);
            }
            else
            {
                Grid.SetRow(TaskList, 0);
                Grid.SetColumn(TaskList, 0);
                Grid.SetColumnSpan(TaskList, 1);
                Grid.SetRow(logView, 0);
                Grid.SetColumn(logView, 1);
                Grid.SetColumnSpan(logView, 1);
            }
        }
    }
}

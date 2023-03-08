// Copyright (c) Microsoft Corporation and Contributors.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using SampleWinui.Model;
using SampleWinui.ViewModel;
using SampleWinui.ChildWindowControls;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace SampleWinui.View
{
    public sealed partial class ChildScheduleView : UserControl
    {
        public ChildScheduleView()
        {
            this.InitializeComponent();
            this.DataContext = new ChildSchduleViewModel();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var window = new ChildWindow();
            window.SetSize(850, 600);
            window.SetContent(new ScheduleListItems());
            window.SetTitle("Schedule");

            window.Activate();
        }
    }
}

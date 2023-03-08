using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using SampleWinui.ChildWindowControls;
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
    public sealed partial class TaskList : UserControl
    {
        public TaskList()
        {
            this.InitializeComponent();
        }


        private void ScheduleButton_Click(object sender, RoutedEventArgs e)
        {
            var window = new ChildWindow();
            window.SetSize(950, 800);
            window.SetContent(new ChildScheduleView());
            window.SetTitle("Schedule");

            window.Activate();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var window = new ChildWindow();
            window.SetSize(950, 1000);
            window.SetContent(new JobSetup());
            window.SetTitle("Schedule");

            window.Activate();
        }
    }
}

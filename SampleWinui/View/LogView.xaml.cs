using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Microsoft.VisualBasic;
using SampleWinui.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace SampleWinui.View
{
    public sealed partial class LogView : UserControl
    {
        public List<string> strings;
        public LogView()
        {
            this.InitializeComponent();
            //strings = new List<string>() { new string("01/13/2015 01:59:01 678 PM: configuration saved by [DTear]"),
            //     new string("01/13/2015 01:59:01 678 PM: configuration saved by [DTear]"),
            //    new string("01/13/2015 01:59:01 678 PM: configuration saved by [DTear]"),
            //     new string("01/13/2015 01:59:01 678 PM: configuration saved by [DTear]"),
            //     new string("01/13/2015 01:59:01 678 PM: configuration saved by [DTear]"),
            //     new string("01/13/2015 01:59:01 678 PM: configuration saved by [DTear]"),
            //     new string("01/13/2015 01:59:01 678 PM: configuration saved by [DTear]"),


            //};
            //LogViewCollection.ItemsSource = strings;
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (this.DataContext is JobsViewModel jobsViewModel)
            {
                jobsViewModel.Logs.Clear();
            }
           // LogViewCollection.ItemsSource = null;
        }
    }
}

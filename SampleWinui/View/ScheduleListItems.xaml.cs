using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using SampleWinui.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace SampleWinui.View
{
    public sealed partial class ScheduleListItems : UserControl
    {
        public ScheduleListItems()
        {
            this.InitializeComponent();
           
            this.DataContext = new ScheduleListItemsViewModel();
            
        }

        private void IncrementButton_Click(object sender, RoutedEventArgs e)
        {
            TimeSpan currentTime = MyTimePicker.Time;
            currentTime = currentTime.Add(TimeSpan.FromMinutes(1));
            MyTimePicker.Time = currentTime;

        }

        private void DecrementButton_Click(object sender, RoutedEventArgs e)
        {
            TimeSpan currentTime = MyTimePicker.Time;
            currentTime = currentTime.Subtract(TimeSpan.FromMinutes(1));
            MyTimePicker.Time = currentTime;
        }

        private void StartingAtIncrementButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void StartingAtDecrementButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EndingAtDecrementButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EndingAtIncrementButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using SampleWinui.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.ClosedCaptioning;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace SampleWinui
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            ExtendsContentIntoTitleBar = true;
            SetTitleBar(AppTitleBar);
        }

        private void Grid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (sender is Grid grid && grid.ActualWidth < 1200)
            {
                Grid.SetColumn(rightPanel, 0);
                rightPanel.Margin= new Thickness(0,50, 0, 0);
                (pivot.SelectedItem as PivotItem).Margin = new Thickness(0, 35, 0, 0);

            }
            else
            {
                Grid.SetColumn(rightPanel, 1);
                rightPanel.Margin = new Thickness(10);
                HeaderGrid.Height = double.NaN;
                (pivot.SelectedItem as PivotItem).Margin = new Thickness(0, 0, 0, 0);
            }
        }
    }
}




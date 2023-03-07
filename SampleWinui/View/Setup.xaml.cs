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
using SampleWinui.Model;
using SampleWinui.ViewModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Color = Windows.UI.Color;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace SampleWinui.View
{
    public sealed partial class Setup : UserControl
    {
        public Setup()
        {
            this.InitializeComponent();
        }
        private void btnItemControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is GridView gridView)
            {
                var item = gridView.SelectedItem as FileModel;
                var window = new ChildWindow();
                if (item.HeaderText == "Instances")
                {
                    window.SetSize(1850, 520);
                    window.SetContent(new ApplicationInstances());
                    window.SetTitle("Appliance Instances");

                }
                else if (item.HeaderText == "Service")
                {
                    window.SetSize(1080, 900);
                    window.SetContent(new ApplicationWindowServicePanel());
                    window.SetTitle("Appliance Windows Service Control Panel");

                }
                else if (item.HeaderText == "PMMS")
                {
                    window.SetSize(1075, 500);
                    window.SetContent(new PMMSSetup());
                    window.SetTitle("PMMS Setup");

                }
                else
                {
                    window.SetSize(930, 1000);
                    window.SetContent(new EmailSetup());
                    window.SetTitle("E-mail Setup");

                }
                window.Activate();
            }

            
            
           
        }


    }
}

// Copyright (c) Microsoft Corporation and Contributors.
// Licensed under the MIT License.

using ColorCode.Styling;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using SampleWinui.ChildWindowControls;
using SampleWinui.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace SampleWinui.View
{
    public sealed partial class SystemUtilities : UserControl
    {
        public SystemUtilities()
        {
            this.InitializeComponent();
        }

        private void GridView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is GridView gridView)
            {
                var item = gridView.SelectedItem as FileModel;
                var window = new ChildWindow();
               
                if (item.HeaderText == "Backup")
                {
                    window.SetSize(850, 650);
                    window.SetContent(new Backup());
                    window.SetTitle(item.HeaderText);
                }
                else if (item.HeaderText == "Show Schedule")
                {
                    window.SetSize(1080, 900);
                    window.SetContent(new ApplicationWindowServicePanel());
                    window.SetTitle("Appliance Windows Service Control Panel");
                }
                else if (item.HeaderText == "Show Status")
                {
                    window.SetSize(1075, 500);
                    window.SetContent(new PMMSSetup());
                    window.SetTitle("PMMS Setup");
                }
                else if (item.HeaderText == "Validate Modules")
                {
                    window.SetSize(350, 600);
                    window.SetContent(new Module_Validation());
                    window.SetTitle("Module Validation");
                }
                else if (item.HeaderText == "Show Objects")
                {
                    window.SetSize(750, 650);
                    window.SetContent(new Objects());
                    window.SetTitle("Objects");
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

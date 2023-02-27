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
                    
                    window.SetContent(new Backup());
                   
                }
                else if (item.HeaderText == "Show Schedule")
                {
                   
                    window.SetContent(new ApplicationWindowServicePanel());
                  
                }
                else if (item.HeaderText == "Show Status")
                {
                  
                    window.SetContent(new PMMSSetup());
               
                }
                else if (item.HeaderText == "Validate Modules")
                {
                
                    window.SetContent(new Module_Validation());
                  
                }
                else if (item.HeaderText == "Show Objects")
                {
                    window.SetContent(new Objects());
                   
                }
                else
                {
                 
                    window.SetContent(new EmailSetup());
                  
                }
                window.Activate();

            }
        }
    }
}

// Copyright (c) Microsoft Corporation and Contributors.
// Licensed under the MIT License.

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
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace SampleWinui.View
{
    public sealed partial class FileView : UserControl
    {
        private SystemUtilities systemUtilities;

        private Setup setup;
        public FileView()
        {
            this.InitializeComponent();
        }

        private void nvSample8_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            NavigationViewItem selectedItem = args.SelectedItem as NavigationViewItem;
            switch (selectedItem.Tag)
            {
                case "SystemUtilities":
                    if(systemUtilities == null)
                    {
                        ContentFrame.Content = new SystemUtilities();
                    } else
                    {
                        ContentFrame.Content = systemUtilities;
                    }
                    
                    break;
                case "Setup":
                    if(setup== null)
                    {
                        ContentFrame.Content = new Setup();
                    }
                    else
                    {
                        ContentFrame.Content = setup;
                    }
                  
                    break;
              
            }
        }
    }
}

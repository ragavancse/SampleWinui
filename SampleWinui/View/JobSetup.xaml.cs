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
using Microsoft.VisualBasic;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace SampleWinui.View
{
    public sealed partial class JobSetup : UserControl
    {
        List<string> JobsetupContent;
        public JobSetup()
        {
            this.InitializeComponent();
            JobsetupContent = new List<string>() { new string("Reporting Data Builder"),
                 new string("SQL Server Action - Intellignce Finalize"),
                new string("Start InMem Finance"),
                 new string("Backup Global Finance"),
                 new string("Replace Global Finance"),
                 new string("InMem Load"),



            };
            JobSetupCollection.ItemsSource = JobsetupContent;
        }
    }
}

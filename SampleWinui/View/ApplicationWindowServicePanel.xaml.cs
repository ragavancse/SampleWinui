// Copyright (c) Microsoft Corporation and Contributors.
// Licensed under the MIT License.

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
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
    public sealed partial class ApplicationWindowServicePanel : UserControl
    {
        public ApplicationWindowServicePanel()
        {
            this.InitializeComponent();
            List<string> LogList = new List<string>() {new string("06/11/2018 01:45:38.986 PM: date: (06/15/2018 02:00:00 AM) (Fri) - Job ID: 1053"),
            new string("06/11/2018 01:45:38.986 PM: date: (06/15/2018 02:00:00 AM) (Fri) - Job ID: 1053"),
            new string("06/11/2018 01:45:38.986 PM: date: (06/15/2018 02:00:00 AM) (Fri) - Job ID: 1053"),
            new string("06/11/2018 01:45:38.986 PM: date: (06/15/2018 02:00:00 AM) (Fri) - Job ID: 1053"),new string("06/11/2018 01:45:38.986 PM: date: (06/15/2018 02:00:00 AM) (Fri) - Job ID: 1053"),
            new string("06/11/2018 01:45:38.986 PM: date: (06/15/2018 02:00:00 AM) (Fri) - Job ID: 1053"),
            new string("06/11/2018 01:45:38.986 PM: date: (06/15/2018 02:00:00 AM) (Fri) - Job ID: 1053"),
            new string("06/11/2018 01:45:38.986 PM: date: (06/15/2018 02:00:00 AM) (Fri) - Job ID: 1053"),
            new string("06/11/2018 01:45:38.986 PM: date: (06/15/2018 02:00:00 AM) (Fri) - Job ID: 1053"),
            new string("06/11/2018 01:45:38.986 PM: date: (06/15/2018 02:00:00 AM) (Fri) - Job ID: 1053"),
            new string("06/11/2018 01:45:38.986 PM: date: (06/15/2018 02:00:00 AM) (Fri) - Job ID: 1053"),
            new string("06/11/2018 01:45:38.986 PM: date: (06/15/2018 02:00:00 AM) (Fri) - Job ID: 1053"),
            new string("06/11/2018 01:45:38.986 PM: date: (06/15/2018 02:00:00 AM) (Fri) - Job ID: 1053"),
            new string("06/11/2018 01:45:38.986 PM: date: (06/15/2018 02:00:00 AM) (Fri) - Job ID: 1053"),
            new string("06/11/2018 01:45:38.986 PM: date: (06/15/2018 02:00:00 AM) (Fri) - Job ID: 1053"),
            new string("06/11/2018 01:45:38.986 PM: date: (06/15/2018 02:00:00 AM) (Fri) - Job ID: 1053"),
            };
            LogCollection.ItemsSource= LogList;
        }


    }
}

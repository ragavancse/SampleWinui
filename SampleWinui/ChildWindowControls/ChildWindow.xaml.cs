using Microsoft.UI.Windowing;
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
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.WebUI;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace SampleWinui.ChildWindowControls
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ChildWindow : Window
    {
        public ChildWindow()
        {
            this.InitializeComponent();
            ExtendsContentIntoTitleBar = true;
            SetTitleBar(AppTitleBar);
        }

        public void SetContent(UserControl userControl)
        {
            content.Content = userControl;

            (GetAppWindow().Presenter as OverlappedPresenter).IsResizable = false;
            (GetAppWindow().Presenter as OverlappedPresenter).IsMaximizable = false;

        }

        public void SetTitle(string title)
        {
            AppTitleTextBlock.Text = title;
        }
        public void SetSize(int width, int height)
        {
            AppWindow appWindow = GetAppWindow();
            appWindow.Resize(new Windows.Graphics.SizeInt32 { Width = width, Height = height });

        }

        private AppWindow GetAppWindow()
        {
            IntPtr hWnd = WinRT.Interop.WindowNative.GetWindowHandle(this);
            var windowId = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(hWnd);
            var appWindow = Microsoft.UI.Windowing.AppWindow.GetFromWindowId(windowId);
            return appWindow;
        }
    }
}

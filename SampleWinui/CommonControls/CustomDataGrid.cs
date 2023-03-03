using CommunityToolkit.WinUI.UI.Controls;
using CommunityToolkit.WinUI.UI.Controls.Primitives;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Media;

namespace SampleWinui.CommonControls
{
    public class CustomDataGrid : DataGrid
    {
        public CustomDataGrid()
        {
            this.Loaded += CustomDataGrid_Loaded;
        }

        private void CustomDataGrid_Loaded(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
        {
            foreach (var item in this.Columns)
            {
                //var colum = item as DataGridBoundColumn;
                //if (colum != null)
                //{
                //    var headerstyle = colum.HeaderStyle == null ? new Style(typeof(DataGridColumnHeader)) : colum.HeaderStyle;
                //    headerstyle.Setters.Add(new Setter(DataGridColumnHeader.FontSizeProperty, 18));
                //    var background = Application.Current.Resources["PivotItemBackGround"] as SolidColorBrush;
                //    var fontFamily = Application.Current.Resources["Source_Sans_Pro_Bold"] as FontFamily;

                //    headerstyle.Setters.Add(new Setter(DataGridColumnHeader.BackgroundProperty, background));
                //    headerstyle.Setters.Add(new Setter(DataGridColumnHeader.FontFamilyProperty, fontFamily));
                //    colum.HeaderStyle = headerstyle;
                //}
            }
        }
    }
}

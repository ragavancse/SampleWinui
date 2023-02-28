using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleWinui.Converter
{
    public class BooleanToVisibilityConverter : IValueConverter
    {
            public object Convert(object value, Type targetType, object parameter, string language)
            {
                bool visible = false;
                if (value is bool)
                    visible = (bool)value;

                return visible ? Visibility.Visible : Visibility.Collapsed;
            }

            public object ConvertBack(object value, Type targetType, object parameter, string language)
            {
                return null;
            }
        }
    
}

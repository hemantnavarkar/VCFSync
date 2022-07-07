using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace VCFSync.Converters
{
    public class BooleanToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {   
            if((bool)value == true)
            { 
              return Visibility.Visible;
            }
            if ((bool)value == false)
            {
                return Visibility.Collapsed;
            }

            return Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return null;
        }
    }
}

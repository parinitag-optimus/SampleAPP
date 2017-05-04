using System;
using System.Globalization;
using System.Windows.Data;

namespace IPConnectionData.App.Converter
{

    /// <summary>
    /// Binding Multiple Parameters
    /// </summary>
    public class MultiBindConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            return values.Clone();
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

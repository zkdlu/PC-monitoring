using System;
using System.Globalization;
using System.Windows.Data;

namespace SystemMonitoring.Common.Converter
{
    public class BtoKBConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double b = (double)value;

            return (int)b / 1024;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return parameter;
        }
    }
}

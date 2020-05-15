using System;
using System.Globalization;
using System.Windows.Data;

namespace SystemMonitoring.Common.Converter
{
    public class BtoGBConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            long b = (long)value;

            return (long)b / 1024 / 1024 / 1024;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return parameter;
        }
    }
}

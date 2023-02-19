using System;
using System.Globalization;
using System.Windows.Data;

namespace Rosneft
{
    public class ConvertParameter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            return new Tuple<string, string, bool>((string)values[0], (string)values[1], (bool)values[2]);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
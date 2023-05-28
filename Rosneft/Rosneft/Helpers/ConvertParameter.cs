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

    public class ConvertParameterToAddRepair : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            return new Tuple<string, string, string, string, string>((string)values[0], (string)values[1], (string)values[2], (string)values[3], (string)values[4]);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
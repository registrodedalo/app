using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace RegistroDedalo.Desktop.Converters
{
    public class TextFormatterConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value.GetType() == typeof(string))
            {
                switch(parameter.ToString().ToLower())
                {
                    case "tolower":
                        return value.ToString().ToLower();
                    case "toupper":
                        return value.ToString().ToUpper();
                    default:
                        throw new NotImplementedException("parameter invalid");
                }
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}

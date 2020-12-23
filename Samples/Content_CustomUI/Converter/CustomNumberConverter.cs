using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Content_CustomUI
{
    public class CustomNumberConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var x=   double.TryParse(value.ToString(), out double number);

            if (number <= 99)
            {
                return value;
            }
            else if (number <= 999)
            {
                return "99+";
            }
            else if (number < 99999)
            {
                return (number / 1000).ToString("0.#") + "K";
            }
            else if (number < 999999)
            {
                return (number / 1000).ToString("#,0K");
            }
            else if (number < 9999999)
            {
                return (number / 1000000).ToString("0.#") + "M";
            }
            else
            {
                return (number / 1000000).ToString("#,0M");
            }
        }
           
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
using Syncfusion.Windows.Controls.Notification;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace Badge_Features
{
    public class DoubleToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }public class StringToBadgeAlignmentConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (targetType.Name == "HorizontalAlignment")
            {
                if (value.ToString() == "Left")
                {
                    return HorizontalAlignment.Left;
                }
                else if (value.ToString() == "Center")
                {
                    return HorizontalAlignment.Center;
                }
                else if (value.ToString() == "Right")
                {
                    return HorizontalAlignment.Right;
                }
                else if (value.ToString() == "Stretch")
                {
                    return HorizontalAlignment.Stretch;
                }
                else
                {
                    return HorizontalAlignment.Right;
                }
            }
            else if (targetType.Name == "VerticalAlignment")
            {
                if (value.ToString() == "Top")
                {
                    return VerticalAlignment.Top;
                }
                else if (value.ToString() == "Center")
                {
                    return VerticalAlignment.Center;
                }
                else if (value.ToString() == "Bottom")
                {
                    return VerticalAlignment.Bottom;
                }
                else if (value.ToString() == "Stretch")
                {
                    return VerticalAlignment.Stretch;
                }
                else
                {
                    return VerticalAlignment.Top;
                }
            }
            else
            {
                return null;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

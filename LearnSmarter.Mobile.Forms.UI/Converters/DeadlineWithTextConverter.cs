using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace LearnSmarter.Mobile.Forms.UI.Converters
{
    public class DeadlineWithTextConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is DateTime date))
                throw new ArgumentException("Expected DateTime type!");

            string text = parameter.ToString();
            TimeSpan daysLast = date - DateTime.Now;
            int days = daysLast.Days;
            return $"{text} {days} dni";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

using LearnSmarter.Mobile.Core.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace LearnSmarter.Mobile.Forms.UI.Converters
{
    public class PriorityToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is Priority priority))
                throw new ArgumentException("Expected Priority enumeration type!");

            switch(priority)
            {
                case Priority.Average:
                    return "#3498db";
                case Priority.Important:
                    return "#f39c12";
                case Priority.Low:
                    return "#5bb85d";
                default:
                    return "#e74c3c";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

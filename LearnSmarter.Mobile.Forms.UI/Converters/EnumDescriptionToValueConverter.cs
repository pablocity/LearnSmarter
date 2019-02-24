using LearnSmarter.Mobile.Core.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;
using LearnSmarter.Mobile.Common;

namespace LearnSmarter.Mobile.Forms.UI.Converters
{
    public class EnumDescriptionToValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!value.GetType().IsEnum)
                return "Something went wrong! This should me an enumeration!";

            Enum enumValue = value as Enum;

            return enumValue.GetEnumValueDescription();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Type t = parameter.GetType();
            return EnumHelper.DescriptionToValue(t, value.ToString());
        }
    }
}

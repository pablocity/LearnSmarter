using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Linq;

namespace LearnSmarter.Mobile.Common
{
    public static class EnumHelper
    {
        public static IList<string> GetEnumValuesDescriptionList<T>()
        {
            if (!typeof(T).IsEnum)
                throw new ArgumentException("Given type must be an enum");

            List<string> result = new List<string>();

            foreach (T val in (T[])Enum.GetValues(typeof(T)))
            {
                Type enumType = val.GetType();
                MemberInfo[] info = enumType.GetMember(val.ToString());

                if (info != null && info.Length > 0)
                {
                    var attribute = info[0].GetCustomAttribute(typeof(System.ComponentModel.DescriptionAttribute), false);
                    if (attribute != null)
                        result.Add(((System.ComponentModel.DescriptionAttribute)attribute).Description);
                }
            }

            return result;
        }

        public static T DescriptionToValue<T>(string description)
        {
            if (!typeof(T).IsEnum)
                throw new ArgumentException("Given type must be an enum");

            foreach (T item in (T[])Enum.GetValues(typeof(T)))
            {
                Enum value = item as Enum;

                if (description == value.GetEnumValueDescription())
                    return item;
            }

            throw new ArgumentException("No item with such description in this enumeration");
        }

        public static Enum DescriptionToValue<T>(T enumType, string description)
            where T : Type
        {
            if (!enumType.IsEnum)
                throw new ArgumentException("Given type must be an enum");

            foreach (Enum item in Enum.GetValues(enumType))
            {
                Enum value = item as Enum;

                if (description == value.GetEnumValueDescription())
                    return item;
            }

            throw new ArgumentException("No item with such description in this enumeration");
        }

        public static string GetEnumValueDescription(this Enum parameter)
        {
            Type enumType = parameter.GetType();
            MemberInfo[] info = enumType.GetMember(parameter.ToString());

            if (info != null && info.Length > 0)
            {
                var attribute = info[0].GetCustomAttribute(typeof(System.ComponentModel.DescriptionAttribute), false);
                if (attribute != null)
                    return((System.ComponentModel.DescriptionAttribute)attribute).Description;
            }

            return "Something went wrong!";

        }
    }
}

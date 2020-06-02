﻿using System;
using System.Globalization;
using Xamarin.Forms;

namespace XamarinCommunityToolkit.Converters
{
    /// <summary>
    /// Converts the incoming value to a boolean indicating whether or not the value is not null and not empty.
    /// </summary>
    public class IsNotNullOrEmptyConverter : IValueConverter
    {
        /// <summary>
        /// Converts the incoming value to a boolean indicating whether or not the value is not null and not empty.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <param name="targetType">The type of the binding target property.</param>
        /// <param name="parameter">Additional parameter for the converter to handle. Not implemented.</param>
        /// <param name="culture">The culture to use in the converter.</param>
        /// <returns>A boolean indicating if the incoming value is not null and not empty.</returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) =>
            value != null && ((value is string str && !string.IsNullOrWhiteSpace(str)) || !(value is string));

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

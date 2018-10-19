using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using StarWarsUniverse.Domain;
using Xamarin.Forms;

namespace StarWarsXF.Converters
{
    class RatingConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            if (value is float rating)
            {
                return (double)rating / 10;
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

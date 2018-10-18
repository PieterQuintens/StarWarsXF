using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using StarWarsUniverse.Domain;
using Xamarin.Forms;

namespace StarWarsXF.Converters
{
    class MovieTitleToImageSourceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Movie movie)
            {
                var imageFileName = System.Convert.ToString(movie.Title).ToLower();
                imageFileName = imageFileName.Replace(' ', '_') + ".jpg";
                return imageFileName;
            }

            else return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

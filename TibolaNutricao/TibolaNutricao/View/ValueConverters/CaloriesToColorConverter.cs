using System;
using System.Globalization;
using Xamarin.Forms;

namespace TibolaNutricao.View.ValueConverters
{
    public class CaloriesToColorConverter : IValueConverter
    {
        public CaloriesToColorConverter()
        {
                
        }
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double calorias = (double)value;
            return calorias < 500 ? Color.Green : Color.Red; 
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

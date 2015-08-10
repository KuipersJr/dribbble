using System;
using Windows.Data.Html;
using Windows.UI.Xaml.Data;

namespace Dribbble.WindowsPhone.Conversores
{
    public class HtmlTagConversor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return HtmlUtilities.ConvertToText(System.Convert.ToString(value));
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
using Syncfusion.ListView.XForms;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PassItemData
{
    public class CustomConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            object eventArgs = null;
            Syncfusion.ListView.XForms.ItemTappedEventArgs eventArg = null;
            if (value is Syncfusion.ListView.XForms.ItemTappedEventArgs)
            {
                eventArg = value as Syncfusion.ListView.XForms.ItemTappedEventArgs;
                eventArgs = eventArg.ItemData;
            }
           
            return eventArgs;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

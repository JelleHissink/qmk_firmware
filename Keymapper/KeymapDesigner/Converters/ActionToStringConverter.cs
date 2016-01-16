using KeymapDesigner.Commands;
using KeymapDesigner.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace KeymapDesigner.Converters
{
    public class ActionToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var action = (Model.Action)value;
            if (action == null || action is TransparentAction)
            {
                return "";
            }
            return action.CCode;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (null == value)
            {
                return Actions.Transparent;
            }
            string s = value.ToString().Trim();
            if (s == "")
            {
                return Actions.Transparent;
            }
            return Model.Action.Parse(s);
        }
    }
}

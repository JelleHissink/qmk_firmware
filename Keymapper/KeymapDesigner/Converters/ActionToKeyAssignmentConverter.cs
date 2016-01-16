using KeymapDesigner.Commands;
using KeymapDesigner.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;
using System.Globalization;

namespace KeymapDesigner.Converters
{
    public class ActionToKeyAssignmentConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var action = (values[0] as Model.Action) ?? Actions.Transparent;
            var assignment = (values[1] as Model.KeyAssignment);

            var key = assignment?.Key ?? new PhysicalKey(0.0, 0.0);
            var layer = assignment?.Layer ?? new Layer(new Ergodox(), Colors.Beige, Colors.Black, "Any", false);

            var result = new KeyAssignment(action, key, layer);
            return result;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

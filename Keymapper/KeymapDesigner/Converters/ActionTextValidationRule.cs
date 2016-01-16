using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace KeymapDesigner.Converters
{
    public class ActionTextValidationRule : ValidationRule
    {
        public ActionTextValidationRule()
        {
        }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            try
            {
                var action = Model.Action.TryParse(value?.ToString() ?? "");
                if (action == null)
                {
                    return new ValidationResult(false, "Please enter a valid action");
                }
                else
                {
                    return new ValidationResult(true, null);
                }
            }
            catch (Exception e)
            {
                return new ValidationResult(false, "Illegal characters or " + e.Message);
            }
        }
    }
}

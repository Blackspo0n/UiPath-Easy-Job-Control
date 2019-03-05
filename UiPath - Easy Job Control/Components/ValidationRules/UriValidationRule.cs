using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace UiPathEJC.Components.ValidationRules
{
    public class UriValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            var input = value as string;

            if (String.IsNullOrEmpty(input)) // Valid input, converts to null.
            {
                return new ValidationResult(true, null);
            }

            return Uri.TryCreate(input, UriKind.Absolute, out Uri outUri) ? new ValidationResult(true, null) : new ValidationResult(false, "String is not a valid URI");
        }
    }
}

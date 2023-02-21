using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PracticomProject.WebAPI.Validation
{
    public class TZValidation : ValidationAttribute
    {
        private Regex _regex = new Regex(@"[0-9]{9}");

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (_regex.IsMatch(value.ToString()))
            {
                return ValidationResult.Success;
            }

            return new ValidationResult("Solo se permite letras, numeros y puntuaciones(- _ .)");
        }
    }
}

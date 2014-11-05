using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using NHibernate.Validator.Engine;

namespace NHibernate.Validator.Specific.Pl
{
    public class PhoneValidator : IInitializableValidator<PhoneAttribute>
    {
        private Regex regex;

        public void Initialize(PhoneAttribute parameters)
        {
            regex = new Regex(@"^[2-9]\d{2}-\d{3}-\d{4}$");
        }

        public bool IsValid(object value, IConstraintValidatorContext constraintValidatorContext) 
        {
            if (value == null) return true;
            return regex.IsMatch(value.ToString());
        }
    }
}

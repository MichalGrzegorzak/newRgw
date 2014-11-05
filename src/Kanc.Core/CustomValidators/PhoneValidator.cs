using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Validator.Constraints;
using NHibernate.Validator.Engine;
using System.Text.RegularExpressions;

namespace Kanc.Core.Entities.Validation
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    [ValidatorClass(typeof(PhoneValidator))]
    public class PhoneAttribute : Attribute, IRuleArgs
    {
        private string message = "Nieprawidłowy numer telefonu";
        public string Message
        {
            get { return message; }
            set { message = value; }
        }
    }

    public class PhoneValidator : IValidator
    {
         public bool IsValid(object value, IConstraintValidatorContext constraintValidatorContext)
         {
             Regex regex = new Regex(@"^[2-9]\d{2}-\d{3}-\d{4}$");
             if (value == null) return true;
             return regex.IsMatch(value.ToString());
         }
    }


}

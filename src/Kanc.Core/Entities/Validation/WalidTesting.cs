using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Validator.Engine;

namespace Kanc.Core.Entities.Validation
{
    public class Walid : IValidator
    {
        public bool IsValid(object value, IConstraintValidatorContext constraintValidatorContext)
        {
            DateTime dt = (DateTime)value;
            return dt > DateTime.Now;
        }
    }
}

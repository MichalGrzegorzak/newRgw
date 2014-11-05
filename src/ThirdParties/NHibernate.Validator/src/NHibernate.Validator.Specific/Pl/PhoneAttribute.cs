using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using NHibernate.Validator.Engine;

namespace NHibernate.Validator.Specific.Pl
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    [ValidatorClass(typeof(PhoneValidator))]
    public class PhoneAttribute : Attribute, IRuleArgs
    {
        private string message = "Niepoprawny format numeru telefonu. Powinien byc: 00-44-444-444";
        public string Message
        {
            get { return message; }
            set { message = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Validator.Engine;

namespace NHibernate.Validator.Constraints
{
    [Serializable]
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    [ValidatorClass(typeof(OptionMinLengthValidator))]
    public class OptionMinLengthAttribute : Attribute, IRuleArgs
    {
        private string message = "the length must be greater than, or equal to, {MinLength}";

        public OptionMinLengthAttribute(int minLength)
        {
            MinLength = minLength;
        }

        public int MinLength { get; set; }

        #region IRuleArgs Members

        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using NHibernate.Validator.Cfg.Loquacious;
using NHibernate.Validator.Cfg.Loquacious.Impl;
using NHibernate.Validator.Engine;

namespace NHibernate.Validator.Constraints
{
	public static class StringConstraintsExtensions
	{
		public static IChainableConstraint<IStringConstraints> IfNotEmptyMinLength(this IStringConstraints definition,
			int minLength)
		{
			var ruleArgs = new OptionMinLengthAttribute(minLength);
			((IConstraints)definition).AddRuleArg(ruleArgs);
			return new ChainableConstraint<IStringConstraints>(definition, ruleArgs);
		}

	    public static IChainableConstraint<IStringConstraints> IfNotEmptyNumeric(this IStringConstraints definition,
	                                                                             int minLength)
	    {
	        var ruleArgs = new OptionIsNumericAttribute();
	        ((IConstraints)definition).AddRuleArg(ruleArgs);
	        return new ChainableConstraint<IStringConstraints>(definition, ruleArgs);
	    }
	}

	[Serializable]
	public class OptionMinLengthValidator : IInitializableValidator<OptionMinLengthAttribute>
	{
		public int MinLength { get; set; }

		#region Implementation of IValidator

		public void Initialize(OptionMinLengthAttribute parameters)
		{
			MinLength = parameters.MinLength;
		}

		public bool IsValid(object value, IConstraintValidatorContext context)
		{
			if (!ReferenceEquals(null, value) && !(value is string))
			{
				return false;
			}
			if (ReferenceEquals(null, value))
			{
				return true;
			}
			int realLength = ((string)value).Trim().Length;
			return realLength == 0 || realLength >= MinLength;
		}

		#endregion

	}
}

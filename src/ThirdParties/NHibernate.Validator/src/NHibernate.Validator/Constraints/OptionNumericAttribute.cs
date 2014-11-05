using System;
using System.Globalization;
using NHibernate.Validator.Cfg.Loquacious;
using NHibernate.Validator.Cfg.Loquacious.Impl;
using NHibernate.Validator.Constraints;
using NHibernate.Validator.Engine;

namespace NHibernate.Validator.Constraints
{
	/// <summary>
	/// Check if string is a number.
	/// </summary>
	[Serializable]
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class OptionIsNumericAttribute : EmbeddedRuleArgsAttribute, IRuleArgs, IValidator
	{
		public OptionIsNumericAttribute()
		{
			Message = "{validator.numeric}";
		}

		#region Implementation of IRuleArgs

		public string Message { get; set; }

		#endregion

		#region Implementation of IValidator

		public bool IsValid(object value, IConstraintValidatorContext validatorContext)
		{
			return value == null || value == string.Empty 
				|| (value is string && IsNumeric(value));
		}

		#endregion
		private static bool IsNumeric(object Expression)
		{
			double retNum;

			return double.TryParse(Convert.ToString(Expression), NumberStyles.Any, NumberFormatInfo.InvariantInfo, out retNum);
		}
	}

}


using System;
using System.ComponentModel;
using System.Windows.Forms;
using NHibernate.Validator.Binding.Controls;
using NHibernate.Validator.Engine;

namespace NHibernate.Validator.Binding
{
	public class EventValidation
	{
		private ErrorProvider errorProvider;
		private ViewValidator vvtor;
		private ValidatorEngine validatorEngine;

		public EventValidation(ViewValidator viewValidator)
		{
			this.vvtor = viewValidator;
			this.errorProvider = viewValidator.ErrorProvider;
			this.validatorEngine = viewValidator.ValidatorEngine;
		}

		public void ValidatingHandler(object sender, CancelEventArgs e)
		{
			System.Type entityType = vvtor.GetEntityType((Control)sender);

			IControlValuable controlValuable = vvtor.Resolver.GetControlValuable(sender);

			InvalidValue[] errors =
				validatorEngine.ValidatePropertyValue(entityType,GetPropertyName((Control)sender), controlValuable.GetValue((Control)sender));

            //binder oblsuguje tylko kilka typow kontrolek
		    System.Type type = sender.GetType();
		    bool ok = ResolveType(type, sender, errors);
            if(!ok) //hack, bierzemy typ bazowy, w sytuacji gdy dziedziczylismy po typie obslugiwanym 
            {
                type = type.BaseType;
                ok = ResolveType(type, sender, errors);
            }
            if(!ok)
                throw new Exception("Nie zdefiniowany typ w Binderze!");
		    
		}

        private bool ResolveType(System.Type type, object sender, InvalidValue[] errors)
        {
            if (type == typeof(MaskedTextBox))
            {
                SetError<MaskedTextBox>(sender, errors);
            }
            else if (type == typeof(TextBox))
            {
                SetError<TextBox>(sender, errors);
            }
            else
            {
                return false;
            }
            return true;
        }

        private void SetError<T>(object sender, InvalidValue[] errors)  where T : Control
        {
			if (errors.Length > 0)
				errorProvider.SetError( (T)sender, errors[0].Message);
			else
				errorProvider.SetError( (T)sender, string.Empty);
        }

		private string GetPropertyName(Control control)
		{
			return vvtor.GetPropertyName(control);
		}
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;
using Kanc.Commons;
using NHibernate.Validator.Binding;

namespace Kanc.UI.Tests
{
	public class Binder
{
	public BindingSource source;
	private SmartViewValidator smartValid;
	
	public object[] ActiveTags { get; set; }
	private bool DisableValidation;
	//private bool AddValidationEvent;
	//public Func<string, System.Type> TypeResolver;

	public Binder(BindingSource source, SmartViewValidator validator, bool disableValidation = false)
	{
		this.source = source;
		this.smartValid = validator;
		this.DisableValidation = disableValidation;
	}

	private BindChain currentChain;

	public BindChain Bind<TObject, TProperty>(Control control, Expression<Func<TObject, TProperty>> expression, string bindProperty = "Text") 
	{
		System.Type bindType = typeof(TObject);
		string propertyName = PropertyResolver.GetMemberName(expression);

		//binding
		control.DataBindings.Add(bindProperty, source, propertyName, true, DataSourceUpdateMode.OnPropertyChanged);

		currentChain = new BindChain(this, control, bindType, propertyName);
		return currentChain;
	}

	public void Validate(Control control, System.Type bindType, string propertyName)
	{
		if(DisableValidation)
			return;
		
			smartValid.Bind(control, bindType, propertyName);
	}

	public void ValidateOnEvent(Control control, string propertyName)
	{
		if (DisableValidation)
			return;

		if (!propertyName.Contains(".Id") && propertyName != "Id") //bo sie jebie, chyba typ powinien byc wtedy Entity -> dziedziczenie
		{
			control.Validating += new EventValidation(smartValid, ActiveTags).ValidatingHandler;
		}
	}

	public class BindChain
	{
		private System.Type clazz;
		private string prop;
		private Control control;
		private Binder currentBinder;
		

		internal BindChain(Binder binder,  Control control, System.Type clazz, string property)
		{
			this.clazz = clazz;
			this.currentBinder = binder;
			this.prop = property;
			this.control = control;
		}

		public BindChain Validate()
		{
			currentBinder.Validate(control, clazz, prop);
			return this;
		}

		public BindChain WithEvent()
		{
			currentBinder.ValidateOnEvent(control, prop);
			return this;
		}

		public BindChain ValidateWithEvent()
		{
			RecursiveUnpack(ref clazz, ref prop);

			currentBinder.Validate(control, clazz, prop);
			currentBinder.ValidateOnEvent(control, prop);
			return this;
		}

		private void RecursiveUnpack(ref Type clazz, ref string property)
		{
			if (property.Contains("."))
			{
				clazz = NameToTypeMapper(property);
				property = property.Substring(property.IndexOf(".") + 1);

				if (property.Contains("."))
					RecursiveUnpack(ref clazz, ref property);
			}
		}
	}

	

		/// <summary>
		/// A better way -> http://stackoverflow.com/questions/608332/best-way-to-get-a-type-object-from-a-string-in-net
		/// </summary>
		/// <param name="propertyName"></param>
		/// <returns></returns>
	private static Type NameToTypeMapper(string propertyName)
	{
		Type result = null;
		propertyName = propertyName.Substring(0, propertyName.IndexOf('.'));

		switch (propertyName)
		{
			case "Klient": result = typeof(Klient_B); break;
			case "KlientB": result = typeof(Klient_B); break;
			case "RachunekB": result = typeof(Rachunek_B); break;
			default: throw new ArgumentException("Nie obslugiwany typ!"); break;
		}
		return result;
	}

}
}

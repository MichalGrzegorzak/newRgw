using System.Windows.Forms;
using NHibernate.Validator.Binding.Controls;

namespace NHibernate.Validator.Binding.Controls
{
	[ControlValidable(typeof(TextBox))]
	[ControlValidable(typeof(RichTextBox))]
    [ControlValidable(typeof(MaskedTextBox))]
	public class TextValuable : IControlValuable
	{
		#region IControlValuable Members

		public object GetValue(Control control)
		{
			return control.Text;
		}

		#endregion
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Kanc.MVP.Presentation.Customers
{
    public abstract class ControlHelper
    {
        public static TextBox FindTextBoxByName(Control fromControl, string name)
        {
            return FindControlByName<TextBox>(fromControl, name);
        }

        public static T FindControlByName<T>(Control fromControl, string name) where T : Control
        {
            return GetAll<T>(fromControl).FirstOrDefault(x => x.Name == name);
        }

        public static IEnumerable<TextBox> GetAllTextBoxes(Control fromControl)
        {
            return GetAll<TextBox>(fromControl);
        }

        public static IEnumerable<T> GetAll<T>(Control fromControl) where T : Control
        {
            return GetAll(fromControl, typeof (T)).Cast<T>();
        }

        public static IEnumerable<Control> GetAll(Control fromControl, Type type)
        {
            var controls = fromControl.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                .Concat(controls)
                .Where(c => c.GetType() == type);
        }
    }
}
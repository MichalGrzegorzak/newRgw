using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kanc.Commons
{
    public class DropdownBase : ComboBox
    {
        public DropdownBase() : base()
        {
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.LayoutEventArgs);
            this.DropDownStyle = ComboBoxStyle.DropDownList;

            this.DisplayMember = "Value";
            this.ValueMember = "Key";

        }

        public int StartIndex { get; set; }

        protected virtual void LayoutEventArgs(object target, EventArgs e)
        {
            if (this.Items.Count > 0)
                this.SelectedIndex = StartIndex;
        }
    }
}

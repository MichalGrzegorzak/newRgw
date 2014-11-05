using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Castle.Core;
using Castle.Core.Internal;

namespace Kanc.Commons
{
    public static class UIExtension
    {
        public static void AttachRadioButtons(this GroupBox groupBox, EventHandler handler)
        {
            var radioList = groupBox.Controls.OfType<RadioButton>();
            radioList.ForEach(r => r.CheckedChanged += handler);
        }
    }
}

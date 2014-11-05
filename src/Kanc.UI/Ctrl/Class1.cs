using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kanc.UI.Ctrl
{
    public class PanelAdv : ToolStripControlHost
    {
        // Controls in this item.
        private FlowLayoutPanel controlPanel;
        private CheckBox chk = new CheckBox();
        private TextBox txt = new TextBox();
        ucTabControl tab = new ucTabControl();

        public PanelAdv() : base(new FlowLayoutPanel())
        {
            // Set up the FlowLayouPanel.
            controlPanel = (FlowLayoutPanel)base.Control;
            controlPanel.BackColor = Color.Red;

            // Add two child controls.
            //chk.AutoSize = true;
            //controlPanel.Controls.Add(chk);
            controlPanel.Controls.Add(tab);
            //controlPanel.Controls.Add(txt);
        }
    }
}

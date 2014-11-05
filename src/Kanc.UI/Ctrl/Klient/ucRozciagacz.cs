using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kanc.UI.Ctrl.Klient
{
    public partial class ucRozciagacz : UserControl
    {
        public ucRozciagacz()
        {
            InitializeComponent();

            //ResetTabIndex();
        }

        private void splitContainer1_Panel1_MouseEnter(object sender, EventArgs e)
        {
            splitContainer1.SplitterDistance = 45;
        }

        private void splitContainer1_Panel2_MouseEnter(object sender, EventArgs e)
        {
            splitContainer1.SplitterDistance = 145;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Castle.Core;
using Kanc.Core;
using Kanc.Core.Entities;

namespace Kanc.UI.Ctrl
{
    public partial class ucDzieci : BaseUserControl
    {
        public ucDzieci()
        {
            InitializeComponent();

            ResetTabIndex();
            numericUpDown1.TabIndex = 610;
            dzieciDatyTextBox.TabIndex = 620;
        }

        public override void LoadData(Binder binder, bool option = false)
        {
            binder.BindRozlicz(numericUpDown1, r=> r.Klient.DzieciLiczba);
            binder.BindRozlicz(dzieciDatyTextBox, r => r.Klient.DzieciDaty);
        }

    }
}

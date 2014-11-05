using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Kanc.Core;

namespace Kanc.UI.Ctrl.Klient
{
    public partial class ucMandatenID : BaseUserControl
    {
        public ucMandatenID()
        {
            InitializeComponent();

            ResetTabIndex();
        }

        public override void LoadData(Binder binder, bool option = false)
        {
            binder.BindRozlicz(mIdTextBox, (r) => r.Klient.MandId);
        }
    }
}

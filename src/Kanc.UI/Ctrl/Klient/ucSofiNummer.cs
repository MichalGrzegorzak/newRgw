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
    public partial class ucSofiNummer : BaseUserControl
    {
        public ucSofiNummer()
        {
            InitializeComponent();

            ResetTabIndex();
        }

        public override void LoadData(Binder binder, bool option = false)
        {
            binder.BindRozlicz(sofinummerTextBox, (r) => r.Klient.Steuernummer).ValidateWithEvent();
        }
    }
}

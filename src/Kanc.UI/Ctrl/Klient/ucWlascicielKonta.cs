using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Kanc.Core;
using Kanc.Core.Entities;

namespace Kanc.UI.Ctrl
{
    public partial class ucWlascicielKonta : BaseUserControl
    {
        public ucWlascicielKonta()
        {
            InitializeComponent();

            ResetTabIndex();
            wlascicielKontaDDL1.TabIndex = 1;
            kontoWlascicielTextBox.TabIndex = 2;

        }

        public override void LoadData(Binder binder, bool option = false)
        {
            //ValidateWithEvent
            binder.Bind(kontoWlascicielTextBox,     (Rozliczenie r) => r.Konto.KontoWlasciciel);
            binder.Bind(wlascicielKontaDDL1,        (Rozliczenie r) => r.Konto.KontoTypWlasciciela);
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Kanc.Commons;
using Kanc.Core.Entities;

namespace Kanc.UI.Ctrl
{
    public partial class ucKsiegowanie : BaseUserControl
    {
        public ucKsiegowanie()
        {
            InitializeComponent();

            nrKPTextBox.Enabled = false;
            kodListyZaplTextBox.Enabled = false;
        }

        public override void LoadData(Core.Binder binder, bool option = false)
        {
            //if(DesignMode) return;
            Binder = binder;
            binder.Bind(nrKPTextBox, (Rozliczenie r) => r.Rachunek.NrKP);
            binder.Bind(kodListyZaplTextBox, (Rozliczenie r) => r.Rachunek.KodListyZapl);

            binder.Bind(numerRachunkuTextBox, (Rozliczenie r) => r.Rachunek.NumerRachunku).ValidateWithEvent();
            binder.Bind(kwotaRachunekTextBox, (Rozliczenie r) => r.Rachunek.KwotaRachunek).ValidateWithEvent();
            binder.Bind(doZaplatyTextBox, (Rozliczenie r) => r.Rachunek.DoZaplaty).ValidateWithEvent();
            binder.Bind(uxProcPodatek1, (Rozliczenie r) => r.Rachunek.PodatekProcent, "SetValue");
            binder.Bind(statusDDL1, (Rozliczenie r) => r.Status);

            binder.Bind(dataDateTimePicker, (Rozliczenie r) => r.Rachunek.Data).ValidateWithEvent();
            binder.Bind(urodzMaskedTextBoxExt, (Rozliczenie r) => r.Rachunek.Data).ValidateWithEvent();

            ucID_Mandaten_Rok1.LoadData(binder);
        }

        private void btnDoZaplaty_Click(object sender, EventArgs e)
        {
            Rozliczenie.Status = Status.s77;
        }

        private void btnProwizja_Click(object sender, EventArgs e)
        {
            Rozliczenie.Status = Status.s90;
        }

        private void btnZaplacony_Click(object sender, EventArgs e)
        {
            Rozliczenie.Status = Status.doZaplaty;
        }
    }
}

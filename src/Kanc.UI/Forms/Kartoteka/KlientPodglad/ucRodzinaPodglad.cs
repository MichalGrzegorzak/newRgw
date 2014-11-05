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
    public partial class ucRodzinaPodglad : BaseUserControl
    {
        public ucRodzinaPodglad()
        {
            InitializeComponent();
        }

        public override void LoadData(Binder binder, bool option = false)
        {
            binder.Bind(partnerImieTextBox, (Rozliczenie r) => r.Partner.Imie);
            binder.Bind(partnerMandIdTextBox, (Rozliczenie r) => r.Partner.MandId);
            binder.Bind(partnerWyznanieTextBox, (Rozliczenie r) => r.Partner.Religia);
            binder.Bind(partnerSlubMaskedTextBoxExt, (Rozliczenie r) => r.Klient.DataSlubu);
            binder.Bind(partnerUrodzMaskedTextBoxExt, (Rozliczenie r) => r.Partner.Urodz);
            binder.Bind(numericUpDown1, (Rozliczenie r) => r.Klient.DzieciLiczba);
            binder.Bind(dzieciDatyTextBox, (Rozliczenie r) => r.Klient.DzieciDaty);
        }
    }
}

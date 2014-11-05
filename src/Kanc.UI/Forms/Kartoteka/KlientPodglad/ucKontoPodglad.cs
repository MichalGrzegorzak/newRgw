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
    public partial class ucKontoPodglad : BaseUserControl
    {
        public ucKontoPodglad()
        {
            InitializeComponent();
        }

        public override void LoadData(Binder binder, bool option = false)
        {
            //kontoLkTextBox.DataBindings.Add("Text", source, GetMemberName((Rozliczenie r) => r.Klient.KontoLk), true, DataSourceUpdateMode.OnPropertyChanged);

            //binder.Bind(blzTextBox, (Rozliczenie r) => r.Konto.Blz);
            binder.Bind(kontoTextBox, (Rozliczenie r) => r.Konto.KontoNr);
            binder.Bind(nazwaCombo, (Rozliczenie r) => r.Konto.BankNazwa);
            binder.Bind(adresCombo, (Rozliczenie r) => r.Konto.BankAdres);
            binder.Bind(swiftCombo, (Rozliczenie r) => r.Konto.BankSwift);
            binder.Bind(krajeDDL1, (Rozliczenie r) => r.Konto.BankKraj, "SetValue");
        }
    }
}

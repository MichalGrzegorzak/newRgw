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
using Kanc.UI.Ctrl;

namespace Kanc.UI.Ctrl
{
    public partial class ucPodstKlientPodglad : BaseUserControl
    {   
        public ucPodstKlientPodglad()
        {
            InitializeComponent();
        }

        public override void LoadData(Binder binder, bool option = false)
        {
            binder.Bind(imieTextBox,(Rozliczenie r) => r.Klient.Imie);
            binder.Bind(imieDeTextBox,(Rozliczenie r) => r.Klient.ImieDe);
            binder.Bind(mIdTextBox, (Rozliczenie r) => r.Klient.MandId);
            binder.Bind(nazwiskoTextBox,(Rozliczenie r) => r.Klient.Nazwisko);
            binder.Bind(nazwiskoDeTextBox,(Rozliczenie r) => r.Klient.NazwiskoDe);
            binder.Bind(krajeDDL1, (Rozliczenie r) => r.Klient.AdresZameld.Kraj, "SetValue");
            binder.Bind(idTextBox2,(Rozliczenie r) => r.Klient.AdresZameld.Id);
            binder.Bind(SteuernummerTextBox, (Rozliczenie r) => r.Klient.Steuernummer);
            binder.Bind(RokTextBox,(Rozliczenie r) => r.Rok);
            binder.Bind(StatusTextBox,(Rozliczenie r) => r.Status);
            binder.Bind(OperatorRokTextBox,(Rozliczenie r) => r.Rok);
            binder.Bind(urodzMaskedTextBoxExt,(Rozliczenie r) => r.Klient.Urodz);
            binder.Bind(poleconyDDL1, (Rozliczenie r) => r.Klient.Polecil);

            lblOperator.Text = "Operator: " + (binder.Rozliczenie).CreatedBy;
            //OperatorPozycjaTextBox.DataBindings.Add("Text", source, GetMemberName((Rozliczenie r) => r.Pozycja), true, DataSourceUpdateMode.OnPropertyChanged);
        }
    }
}

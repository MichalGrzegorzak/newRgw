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
    public partial class ucKontakt : BaseUserControl
    {
        public ucKontakt()
        {
            InitializeComponent();
        }

        public override void LoadData(Binder binder, bool option = false)
		{
			binder.Bind(kodTextBox,(Rozliczenie r) => r.Klient.AdresZameld.Kod);
            binder.Bind(miastoTextBox, (Rozliczenie r) => r.Klient.AdresZameld.Miasto);
            binder.Bind(miejsceTextBox, (Rozliczenie r) => r.Klient.AdresZameld.Miejsce);
            binder.Bind(ulicaTextBox, (Rozliczenie r) => r.Klient.AdresZameld.Ulica);
				
            binder.Bind(emailTextBox,(Rozliczenie r) => r.Klient.Email);
			binder.Bind(komorkaTextBox,(Rozliczenie r) => r.Klient.Komorka);
			binder.Bind(telefonTextBox,(Rozliczenie r) => r.Klient.Telefon);

            binder.Bind(notkaTextBox, (Rozliczenie r) => r.Klient.Notka);
		}
    }
}

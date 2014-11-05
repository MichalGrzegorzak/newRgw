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
	public partial class ucAdresPodglad : BaseUserControl
	{
		public ucAdresPodglad()
		{
			InitializeComponent();
		}

        public override void LoadData(Binder binder, bool option = false)
		{
			//if (option)
			{
                binder.Bind(kodTextBox1, (Rozliczenie r) => r.Klient.AdresZameld.Kod);
                binder.Bind(miastoTextBox1, (Rozliczenie r) => r.Klient.AdresZameld.Miasto);
                binder.Bind(miejsceTextBox1, (Rozliczenie r) => r.Klient.AdresZameld.Miejsce);
                binder.Bind(ulicaTextBox1, (Rozliczenie r) => r.Klient.AdresZameld.Ulica);
				binder.Bind(emailTextBox,(Rozliczenie r) => r.Klient.Email);
				binder.Bind(komorkaTextBox,(Rozliczenie r) => r.Klient.Komorka);
				binder.Bind(telefonTextBox,(Rozliczenie r) => r.Klient.Telefon);
			}
            //else
            //{
            //    binder.Bind(kodTextBox1,(Rozliczenie r) => r.Klient.AdresKoresp.Kod);
            //    binder.Bind(miastoTextBox1,(Rozliczenie r) => r.Klient.AdresKoresp.Miasto);
            //    binder.Bind(miejsceTextBox1,(Rozliczenie r) => r.Klient.AdresKoresp.Miejsce);
            //    binder.Bind(ulicaTextBox1,(Rozliczenie r) => r.Klient.AdresKoresp.Ulica);
            //    binder.Bind(emailTextBox,(Rozliczenie r) => r.Klient.Email);
            //    binder.Bind(komorkaTextBox,(Rozliczenie r) => r.Klient.Komorka);
            //    binder.Bind(telefonTextBox,(Rozliczenie r) => r.Klient.Telefon);
            //}


			
		}
	}
}

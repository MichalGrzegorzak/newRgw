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
using Kanc.UI.Forms.Modalne;

namespace Kanc.UI.Ctrl
{
    public partial class ucRachunekPodglad : BaseUserControl
    {
        public ucRachunekPodglad()
        {
            InitializeComponent();
        }

        public override void LoadData(Binder binder, bool option = false)
        {
            Binder = binder;

            binder.Bind(NrRachunkuTextBox, (Rozliczenie r) => r.Rachunek.NumerRachunku);
            binder.Bind(BetragTextBox, (Rozliczenie r) => r.Rachunek.KwotaRachunek); //reszta
            //binder.Bind(UmsatzsteuerTextBox, (Rozliczenie r) => r.Rachunek); 19 procent od kwoty?
            binder.Bind(DoZaplatyTextBox, (Rozliczenie r) => r.Rachunek.DoZaplaty);
            binder.Bind(RechnungsbetragTextBox, (Rozliczenie r) => r.Rachunek.PodatekProcent);

            ucForListaZaplat1.LoadData(binder, option);
        }


        private void OdeslanieButton_Click(object sender, EventArgs e)
        {
            //zmien status
        }

        private void ZaplataButton_Click(object sender, EventArgs e)
        {
            //frm zaplata rachuinku
        }

        private void KsiegowanieButton_Click(object sender, EventArgs e)
        {
            FrmKsiegowanie frm = new FrmKsiegowanie(Binder.Rozliczenie.Id);
            frm.Closing += new CancelEventHandler(frm_Closing);
            frm.ShowDialog(this.ParentForm);
        }

        void frm_Closing(object sender, CancelEventArgs e)
        {
            FrmKsiegowanie f = (sender as FrmKsiegowanie);
            if (f.SavedSucessfull)
            {
                Binder.source.DataSource = f.CurrentItem;
            }
        }
    }
}

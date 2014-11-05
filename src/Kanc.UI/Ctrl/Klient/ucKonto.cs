using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Kanc.Commons;
using Kanc.Core;
using Kanc.Core.Entities;
using Kanc.UI.Forms;
using NHibernate;
using NHibernate.Linq;

namespace Kanc.UI.Ctrl
{
    /// <summary>
    /// trzeba zrobic dynamiczna / warunkowa walidacje IBAN jesli podajemy pelne dane
    /// </summary>
    public partial class ucKonto : BaseUserControl
    {
        public EventHandler AddBankEvent;

        private FrmDodajBank frmDodajBank;

        private void SetTabsIndex()
        {
            ResetTabIndex();

            krajeBankiDDL1.TabIndex = 300;
            kontoLkTextBox.TabIndex = 310;
            blzTextBox.TabIndex = 320;
            kontoTextBox.TabIndex = 330;
            nazwaCombo.TabIndex = 340;
            adresCombo.TabIndex = 350;
            swiftCombo.TabIndex = 360;
            btnDodajBank.TabIndex = 370;
        }
        
        public ucKonto() : base()
        {
            InitializeComponent();

            SetTabsIndex();

            if (DesignMode || Context.Slownik == null)
                return;

            try
            {
                AutoCompleteStringCollection nazwyBankow = new AutoCompleteStringCollection();
                Context.Slownik.Banki.Select(b => b.Nazwa).ForEach(x => nazwyBankow.Add(x));
                nazwaCombo.AutoCompleteCustomSource = nazwyBankow;
                nazwaCombo.Validated += new EventHandler(nazwaCombo_Validated);

                AutoCompleteStringCollection swiftyBankow = new AutoCompleteStringCollection();
                Context.Slownik.Banki.Where(x => !string.IsNullOrEmpty(x.Swift)).Select(b => b.Swift)
                    .ForEach(x => swiftyBankow.Add(x));
                swiftCombo.AutoCompleteCustomSource = swiftyBankow;

                AutoCompleteStringCollection adresyBankow = new AutoCompleteStringCollection();
                Context.Slownik.Banki.Where(x=>!string.IsNullOrEmpty(x.Adres)).Select(b => b.Adres)
                    .ForEach(x => adresyBankow.Add(x));
                adresCombo.AutoCompleteCustomSource = adresyBankow;
            }
            catch
            {
            }
        }

        void nazwaCombo_Validated(object sender, EventArgs e)
        {
            string nazwa = nazwaCombo.Text;
            if (nazwa.IsNotNullOrEmpty())
            {
                Bank b = Context.Slownik.Banki.Where(x => x.Nazwa == nazwa).FirstOrDefault();
                if (b == null) return;
                adresCombo.Text = b.Adres;
                swiftCombo.Text = b.Swift;
            }

            if (krajeBankiDDL1.SelectedIndex > 0
                && kontoLkTextBox.Text.IsNotNullOrEmptyT()
                && blzTextBox.Text.IsNotNullOrEmptyT()
                && kontoTextBox.Text.IsNotNullOrEmptyT())
            {
                //waliduj IBAN
                string s = "";
            }
        }

        public override void LoadData(Binder binder, bool option = false)
        {
            Binder = binder;

            binder.Bind(blzTextBox, (Rozliczenie r) => r.Konto.BankBLZ).ValidateWithEvent();
            binder.Bind(kontoLkTextBox, (Rozliczenie r) => r.Konto.KontoLk).ValidateWithEvent();
            binder.Bind(kontoTextBox, (Rozliczenie r) => r.Konto.KontoNr).ValidateWithEvent();
            binder.Bind(idTextBox, (Rozliczenie r) => r.Konto.Id);
            
            binder.Bind(nazwaCombo, (Rozliczenie r) => r.Konto.BankNazwa).ValidateWithEvent();
            binder.Bind(adresCombo, (Rozliczenie r) => r.Konto.BankAdres).ValidateWithEvent();
            binder.Bind(swiftCombo, (Rozliczenie r) => r.Konto.BankAdres).ValidateWithEvent();

            binder.Bind(krajeBankiDDL1, (Rozliczenie r) => r.Konto.BankKraj);
        }

        private void btnDodajBank_Click(object sender, EventArgs e)
        {
            //Bank bank = Binder.source.Current.As<Rozliczenie>().Konto;
            Bank bank = new Bank();

            //if (bank.IsModified)  //trick zeby utworzyl nam nowy obiekt, jesli dokonano zmian
            {
                
                //Bank klon = (Bank)bank.Clone(); //nowe obiekty wewnetrzne
                //Bank klon = CloneHelper.CloneObject(_startingItem); //nie dziala
                //bank = klon;
            }

            frmDodajBank = new FrmDodajBank(Session, bank);
            frmDodajBank.ShowDialog(this.ParentForm);
            frmDodajBank.FormClosing += new FormClosingEventHandler(form_FormClosing); //przypisz nam spowrotem obiekt z formatki
        }

        void form_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmDodajBank form = (FrmDodajBank) sender;
            //((Rozliczenie)Source.DataSource).Konto = form.CurrentItem;
            //Source.ResetBindings(true); //odswiez binding
        }
    }
}

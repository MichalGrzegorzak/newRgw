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
using NHibernate.Validator.Binding;

namespace Kanc.UI.Ctrl
{
    public partial class ucEdycjaKlient : BaseUserControl
    {
        public ucEdycjaKlient()
        {
            InitializeComponent();

            ResetTabIndex();
            imieTextBox.TabIndex = 130;
            nazwiskoTextBox.TabIndex = 140;
            imieDeTextBox.TabIndex = 150;
            nazwiskoDeTextBox.TabIndex = 160;
            urodzMaskedTextBoxExt.TabIndex = 170;
            telefonTextBox.TabIndex = 180;
            komorkaTextBox.TabIndex = 190;
            emailTextBox.TabIndex = 200;
            plecDDL1.TabIndex = 210;
        }

        public override void LoadData(Binder binder, bool option = false)
        {
            //DANE KLIENTA
            binder.BindRozlicz(imieTextBox, (r) => r.Klient.Imie).ValidateWithEvent();
            binder.BindRozlicz(imieDeTextBox, (r) => r.Klient.ImieDe).ValidateWithEvent(); ;
            binder.BindRozlicz(nazwiskoTextBox, (r) => r.Klient.Nazwisko).ValidateWithEvent();
            binder.BindRozlicz(nazwiskoDeTextBox, (r) => r.Klient.NazwiskoDe).ValidateWithEvent();
            binder.BindRozlicz(emailTextBox, (r) => r.Klient.Email).ValidateWithEvent();
            binder.BindRozlicz(komorkaTextBox, (r) => r.Klient.Komorka).ValidateWithEvent();
            binder.BindRozlicz(telefonTextBox, (r) => r.Klient.Telefon).ValidateWithEvent();
            //binder.BindRozlicz(mIdTextBox, (r) => r.MandId).ValidateWithEvent();

            binder.BindRozlicz(urodzMaskedTextBoxExt, (r) => r.Klient.Urodz).ValidateWithEvent();
            binder.BindRozlicz(plecDDL1, (r) => r.Klient.Plec, "SetValue");


            //ADRES
            binder.BindRozlicz(kodTextBox1, (r) => r.Klient.AdresZameld.Kod).ValidateWithEvent(); ;
            binder.BindRozlicz(miastoTextBox1, (r) => r.Klient.AdresZameld.Miasto).ValidateWithEvent();
            binder.BindRozlicz(miejsceTextBox1, (r) => r.Klient.AdresZameld.Miejsce).ValidateWithEvent(); ;
            binder.BindRozlicz(ulicaTextBox1, (r) => r.Klient.AdresZameld.Ulica).ValidateWithEvent(); ;
            binder.BindRozlicz(idTextBox2, (r) => r.Klient.AdresZameld.Id);
            binder.BindRozlicz(krajeDDL1, (r) => r.Klient.AdresZameld.Kraj); 

            //DZIECI
            binder.BindRozlicz(numericUpDown1, r => r.Klient.DzieciLiczba);
            binder.BindRozlicz(dzieciDatyTextBox, r => r.Klient.DzieciDaty);

            //KONTO
            binder.BindRozlicz(blzTextBox, (r) => r.Konto.BankBLZ).ValidateWithEvent();
            binder.BindRozlicz(kontoLkTextBox, (r) => r.Konto.KontoLk).ValidateWithEvent();
            binder.BindRozlicz(kontoTextBox, (r) => r.Konto.KontoNr).ValidateWithEvent();
            binder.BindRozlicz(idTextBox, (r) => r.Konto.Id);

            binder.BindRozlicz(nazwaCombo, (r) => r.Konto.BankNazwa).ValidateWithEvent();
            binder.BindRozlicz(adresCombo, (r) => r.Konto.BankAdres).ValidateWithEvent();
            binder.BindRozlicz(swiftCombo, (r) => r.Konto.BankAdres).ValidateWithEvent();

            binder.BindRozlicz(krajeBankiDDL1, (r) => r.Konto.BankKraj);

            //PARTNER
            binder.BindRozlicz(partnerImieTextBox, (r) => r.Partner.Imie).ValidateWithEvent();
            binder.BindRozlicz(partnerMandIdTextBox, (r) => r.Partner.MandId).ValidateWithEvent();
            binder.BindRozlicz(partnerSlubMaskedTextBoxExt, (r) => r.Klient.DataSlubu).ValidateWithEvent();
            binder.BindRozlicz(partnerUrodzMaskedTextBoxExt, (r) => r.Partner.Urodz).ValidateWithEvent();

            //no validation
            binder.BindRozlicz(partnerWyznanieTextBox, (r) => r.Partner.Religia);
        }



    }
}

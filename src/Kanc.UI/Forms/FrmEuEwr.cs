using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Kanc.Commons;
using Kanc.Core;
using Kanc.Core.Entities;
using Kanc.Core.Features;
using Kanc.Core.Features.Raporty;
using Kanc.Core.Features.Raporty.DE;
using NHibernate;
using NHibernate.Linq;
using NHibernate.Validator.Binding.Util;

namespace Kanc.UI.Forms
{
    public partial class FrmEuEwr : BaseFormSimple
    {
        public FrmEuEwr()
        {
            InitializeComponent();
        }

        public FrmEuEwr(ISession session, Rozliczenie roz) : base(session, roz)
        {
            InitializeComponent();
        }

        protected override void Init()
        {
            grpSamotnyZonaty.AttachRadioButtons(samotny_CheckedChanged);
        }

        protected override void Binding()
        {
            //Contract.EnsuresOnThrow<Exception>(MainBindingSrc.DataSource != null, "Uzyj ShowForm z MainForm, i ustaw DataSource");
            //Check.NotNull(MainBindingSrc.DataSource, "MainBindingSrc.DataSource", "Uzyj ShowForm z MainForm, i ustaw DataSource");
            //MainBindingSrc = new BindingSource(); //nowy, niezalezny obiekt
            //MainBindingSrc.DataSource = item;

            //top 3 section
            //binder.DisableValidation
            binder.Bind(txbID, (Rozliczenie r) => r.PoprzedniId);
            binder.Bind(txbMandaten, (Rozliczenie r) => r.Klient.MandId);
            binder.Bind(JahrTextBox, (Rozliczenie r) => r.Rok);
            //urzad pusty
            //popraw pusty

            //kient
            binder.Bind(nazwiskoTextBox, (Rozliczenie r) => r.Klient.Nazwisko);
            binder.Bind(imieTextBox, (Rozliczenie r) => r.Klient.Imie);
            binder.Bind(kodTextBox, (Rozliczenie r) => r.Klient.AdresZameld.Kod);
            binder.Bind(miastoTextBox, (Rozliczenie r) => r.Klient.AdresZameld.Miasto);
            binder.Bind(miejsceTextBox, (Rozliczenie r) => r.Klient.AdresZameld.Miejsce);
            binder.Bind(ulicaTextBox, (Rozliczenie r) => r.Klient.AdresZameld.Ulica);
            binder.Bind(urodzDateTimePicker, (Rozliczenie r) => r.Klient.Urodz);
            //
            binder.Bind(partnerImieTextBox, (Rozliczenie r) => r.Partner.Imie);
            binder.Bind(krajRozliczeniaTextBox, (Rozliczenie r) => r.Kraj); // co dac tutaj ???
            binder.Bind(partnerUrodzDateTimePicker, (Rozliczenie r) => r.Partner.Urodz);
            binder.Bind(partnerSlubDateTimePicker, (Rozliczenie r) => r.Klient.DataSlubu);
            binder.Bind(operatorTextBox, (Rozliczenie r) => r.CreatedBy);

            //reszta niebindowana
            zonatyDateTimePicker.Text = CurrentItem.Klient.DataSlubu.IfValueThenShortDate();
            //wdowiecDateTimePicker.Text = CurrentItem.Klient.DataSlubu.IfValueThenShortDate();
            
            if (CurrentItem.Partner.IsPresent)
                zonatyRadioButton.Checked = true;
            else
                samotnyRadioButton.Checked = true;

            samotny_CheckedChanged(null, null);
        }

        private void BindRightPart(IOsoba osoba)
        {
            nazwiskoTextBox2.Text = osoba.Nazwisko;
            imieTextBox2.Text = osoba.Imie;
            urodzDateTimePicker2.Text = osoba.Urodz.IfValueThenShortDate();
            //
            krajZamieszkaniaTextBox2.Text = CurrentItem.Klient.AdresZameld.Kraj.ToString();
            kodTextBox2.Text = CurrentItem.Klient.AdresZameld.Kod;
            miejsceTextBox2.Text = CurrentItem.Klient.AdresZameld.KodIMiasto(); // k.AdresZameld.Miejsce;
            ulicaTextBox2.Text = CurrentItem.Klient.AdresZameld.Ulica;
            obywatelstwoTextBox2.Text = "polskie";
        }

        private void BindLeftPart(IOsoba osoba)
        {
            nazwiskoTextBox1.Text =  osoba.Nazwisko;
            imieTextBox1.Text = osoba.Imie;
            urodzDateTimePicker1.Text = osoba.Urodz.IfValueThenShortDate();
            //
            krajZamieszkaniaTextBox1.Text = CurrentItem.Klient.AdresZameld.Kraj.ToString();
            kodTextBox1.Text = CurrentItem.Klient.AdresZameld.Kod;
            miejsceTextBox1.Text = CurrentItem.Klient.AdresZameld.KodIMiasto();
            ulicaTextBox1.Text = CurrentItem.Klient.AdresZameld.Ulica;
            obywatelstwoTextBox1.Text = "polskie";
        }

        private void ClearBothParts()
        {
            nazwiskoTextBox1.Text = nazwiskoTextBox2.Text = string.Empty;
            imieTextBox1.Text = imieTextBox2.Text = string.Empty;
            urodzDateTimePicker1.Text = urodzDateTimePicker2.Text = string.Empty;
            krajZamieszkaniaTextBox1.Text = krajZamieszkaniaTextBox2.Text = string.Empty;
            miejsceTextBox1.Text = miejsceTextBox2.Text = string.Empty;
            kodTextBox1.Text = kodTextBox2.Text = string.Empty;
            obywatelstwoTextBox1.Text = obywatelstwoTextBox2.Text = string.Empty;
            ulicaTextBox1.Text = ulicaTextBox2.Text = string.Empty;
        }

        void samotny_CheckedChanged(object sender, EventArgs e)
        {
            ClearBothParts();

            if (samotnyRadioButton.Checked)
            {
                BindLeftPart(CurrentItem.Klient);
            }
            if (zonatyRadioButton.Checked)
            {
                BindLeftPart(CurrentItem.Klient);
                BindRightPart(CurrentItem.Partner);
            }
            if (zameznaRadioButton.Checked)
            {
                BindLeftPart(CurrentItem.Partner);
                BindRightPart(CurrentItem.Klient);
            }
            if (tylkoZonaRadioButton.Checked)
            {
                BindRightPart(CurrentItem.Partner);
            }
        }

        private void DrukujButton_Click(object sender, EventArgs e)
        {
            if (this.PlRadioButton.Checked)
            {
                FillReport_EuEWR(RptLang.Polski);
            }
            else if (this.DeRadioButton.Checked)
            {
                FillReport_EuEWR(RptLang.Obcy);
            }
            else
            {
                FillReport_EuEWR(RptLang.PolskiIObcy);
            }

        }

        private void FillReport_EuEWR(RptLang jezyk)
        {
            EuEwr rpt = (EuEwr)RaportFactory.Niemcy.EuEwr.Map(r.Rok, r, jezyk);

            rpt.DataWdowiecOd = wdowiecDateTimePicker.Text;
            rpt.DataZonatyOd = zonatyDateTimePicker.Text;
            rpt.Obywatelstwo = rpt.ObywatelstwoPartner = "polskie";

            rpt.Imie = imieTextBox1.Text;
            rpt.Nazwisko = nazwiskoTextBox1.Text;
            rpt.Dataur = urodzDateTimePicker1.Text;
            rpt.Krajzam = krajZamieszkaniaTextBox1.Text;
            rpt.Miejscezam = miejsceTextBox1.Text;
            rpt.Ulica = ulicaTextBox1.Text;
            rpt.Kodpocztowy = kodTextBox1.Text;

            rpt.ImiePartner = imieTextBox2.Text;
            rpt.NazwiskoPartner = nazwiskoTextBox2.Text;
            rpt.DataurPartner = urodzDateTimePicker2.Text;
            rpt.KrajzamPartner = krajZamieszkaniaTextBox2.Text;
            rpt.MiejscezamPartner = miejsceTextBox2.Text;
            rpt.UlicaPartner = ulicaTextBox2.Text;
            rpt.KodpocztowyPartner = kodTextBox2.Text;
            
            rpt.Genereate();
        }

        private void btnKrapkowice_Click(object sender, EventArgs e)
        {
            PodanieUSKrapkowice rpt = (PodanieUSKrapkowice)RaportFactory.Niemcy.PodanieUSKrapkowice.Map(r);
            rpt.ImieINazwisko = imieTextBox1.Text + " " + nazwiskoTextBox1.Text;
            rpt.AdresLinia1 = kodTextBox1.Text + " " + miejsceTextBox1.Text;
            rpt.AdresLinia2 = ulicaTextBox1.Text;
            rpt.ImieINazwiskoPartner = imieTextBox2.Text + " " + nazwiskoTextBox2.Text;
            rpt.AdresLinia1Partner = kodTextBox2.Text + " " + miejsceTextBox2.Text;
            rpt.AdresLinia2Partner = ulicaTextBox2.Text;
            //rpt.RozliczenieOkres
            //rpt.NIP
            //rpt.Opis
            rpt.Genereate();
        }

        private void btnPodanie_Click(object sender, EventArgs e)
        {
            //rpt.NIP;
            //rpt.MalzonekNIP;
            //rpt.WSprawie;
            PodanieEuEwr rpt = (PodanieEuEwr)RaportFactory.Niemcy.PodanieEuEwr.Map(r);
            rpt.MalzonekWpiszRok = PoprawTextBox.Text; //??

            rpt.Nazwisko = nazwiskoTextBox1.Text;
            rpt.Imiona = imieTextBox1.Text;
            rpt.DataUrodzenia = urodzDateTimePicker1.Text;
            rpt.Miejscowosc = ulicaTextBox1.Text;
            rpt.KodPocztowyMiejsceZamieszkania = kodTextBox1.Text + " " + miejsceTextBox1.Text;
            rpt.ObywatelstwoObywatelstwa = obywatelstwoTextBox1.Text;

            rpt.MalzonekNazwisko = nazwiskoTextBox2.Text;
            rpt.MalzonekImiona = imieTextBox2.Text;
            rpt.MalzonekDataUrodzenia = urodzDateTimePicker2.Text;
            rpt.MalzonekAdresZamieszkania = ulicaTextBox2.Text;
            rpt.MalzonekKodPocztowyMiejsceZamieszkania = kodTextBox2.Text + " " + miejsceTextBox2.Text;
            rpt.MalzonekObywatelstwoObywatelstwa = obywatelstwoTextBox2.Text;

            rpt.MiejscowoscUS = urzadSkarbowyTextBox.Text;
            
            rpt.Genereate();
        }

        private void btnClose_Click(object sender, EventArgs e) { Close(); }

    }
}

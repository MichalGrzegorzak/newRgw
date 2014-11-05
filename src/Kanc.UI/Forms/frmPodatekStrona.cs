using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
using iTextSharp.text.pdf;

namespace Kanc.UI.Forms
{
    public partial class FrmPodatekStrona : BaseFormSimple
    {
        #region .CTORs

        public FrmPodatekStrona()
        {
            InitializeComponent();
        }
        public FrmPodatekStrona(ISession session, Rozliczenie roz) : base(session, roz)
        {
            InitializeComponent();
        }
        #endregion

        protected override void Init()
        {
            comboBox1.SelectedIndex = 0;
        }

        protected override void Binding()
        {
            //operatorTextBox.DataBindings.Add("Text", source, GetMemberName((Rozliczenie r) => r.Adres), true, DataSourceUpdateMode.OnPropertyChanged);
            binder.Bind(idTextBox, (Rozliczenie r) => r.Id);
            binder.Bind(rokTextBox, (Rozliczenie r) => r.Rok);
            binder.Bind(steuernummerTextBox, (Rozliczenie r) => r.Klient.Steuernummer);
            binder.Bind(nazwiskoTextBox, (Rozliczenie r) => r.Klient.Nazwisko);
            binder.Bind(nazwiskoDeTextBox, (Rozliczenie r) => r.Klient.NazwiskoDe);
            binder.Bind(imieTextBox, (Rozliczenie r) => r.Klient.Imie);
            binder.Bind(imieDeTextBox, (Rozliczenie r) => r.Klient.ImieDe);
            binder.Bind(wyznanieTextBox, (Rozliczenie r) => r.Klient.Religia);
            binder.Bind(emailTextBox, (Rozliczenie r) => r.Klient.Email);
            binder.Bind(ulicaTextBox, (Rozliczenie r) => r.Klient.AdresZameld.Ulica);
            binder.Bind(miejsceTextBox, (Rozliczenie r) => r.Klient.AdresZameld.Miejsce);
            binder.Bind(kodTextBox, (Rozliczenie r) => r.Klient.AdresZameld.Kod);
            binder.Bind(komorkaTextBox, (Rozliczenie r) => r.Klient.Komorka);
            binder.Bind(telefonTextBox, (Rozliczenie r) => r.Klient.Telefon);
            binder.Bind(dzieciLiczbaTextBox, (Rozliczenie r) => r.Klient.DzieciLiczba);
            binder.Bind(partnerImieTextBox, (Rozliczenie r) => r.Partner.Imie);
            binder.Bind(partnerMandIdTextBox, (Rozliczenie r) => r.Partner.MandId);
            binder.Bind(partnerWyznanieTextBox, (Rozliczenie r) => r.Partner.Religia);
            //pickery
            binder.Bind(urodzDateTimePicker, (Rozliczenie r) => r.Klient.Urodz);
            binder.Bind(partnerUrodzDateTimePicker, (Rozliczenie r) => r.Partner.Urodz);
            binder.Bind(partnerSlubDateTimePicker, (Rozliczenie r) => r.Klient.DataSlubu);
        }

        private void DrukujButton_Click(object sender, EventArgs e)
        {
            if (this.PlRadioButton.Checked)
            {
                FillReport2(RptLang.Polski);
            }
            else if (this.DeRadioButton.Checked)
            {
                FillReport2(RptLang.Obcy);
            }
            else
            {
                FillReport2(RptLang.PolskiIObcy);
            }
        }

        private void FillReport2(RptLang jezyk)
        {
            StronaNiemcy rpt = (StronaNiemcy)RaportFactory.Niemcy.StronaNiemcy.Map(r);
            rpt.Language = jezyk;

            rpt.Rok = this.rokTextBox.Text;
            rpt.Operator = this.operatorTextBox.Text;
            rpt.DataPodpis = this.dataDateTimePicker.Value.ToShortDateString();
            
            
            // osobiste
            rpt.MandantenNr = this.NumerRejestracyjnyTextBox.Text; //
            rpt.NrKlienta = this.idTextBox.Text;
            rpt.Steuernummer = this.steuernummerTextBox.Text;
            rpt.NazwiskoImieDe = this.nazwiskoDeTextBox.Text + "," + this.imieDeTextBox.Text;
            rpt.NazwiskoImiePl = this.nazwiskoTextBox.Text + "," + this.imieTextBox.Text;
            rpt.Urodz = this.urodzDateTimePicker.Date.IfValueThenShortDate();
            rpt.Kod = this.kodTextBox.Text;
            rpt.Miejscowosc = this.miejsceTextBox.Text;
            rpt.KodMiejscowosc = this.kodTextBox.Text + " " + this.miejsceTextBox.Text;
            rpt.Ulica = this.ulicaTextBox.Text;
            rpt.Telefon = this.telefonTextBox.Text;
            rpt.Komorka = this.komorkaTextBox.Text;
            rpt.Email = this.emailTextBox.Text;
            rpt.Religia = this.wyznanieTextBox.Text;
            rpt.Zarobki = this.dochodyMazTextBox.Text;
            rpt.DataSlubu = this.partnerSlubDateTimePicker.Date.IfValueThenShortDate();
            rpt.LiczbaDzieci = this.dzieciLiczbaTextBox.Text;
            rpt.Zawod = this.txbZawod.Text;
            rpt.InneDochody = this.txbPozostałeDochody.Text;
            // partner
            rpt.PartnerImie = this.partnerImieTextBox.Text;
            rpt.PartnerUrodz = this.partnerUrodzDateTimePicker.Date.IfValueThenShortDate();
            rpt.PartnerNrKlienta = this.partnerMandIdTextBox.Text;
            rpt.PartnerSteuernummer = this.nipZonyTextBox.Text;
            rpt.PartnerReligia = this.partnerWyznanieTextBox.Text;
            rpt.PartnerZarobki = this.dochodyZonaTextBox.Text;

            // CHECKBOXY
            rpt.Zonaty = this.zonatyTakradioButton.Checked; //    dictionary.Add("rbZonatyNie", "no");
            rpt.PartnerMieszkaWniemczech = this.ZamieszkanieNiemcyCheckBox.Checked; //this.zamieszakaniePolskaCheckBox.Checked
            rpt.PartnerPracujeNiemcy = this.pracaNiemcyCheckBox.Checked; //this.pracaPolskaCheckBox.Checked

            // AUTO - rpt.ResetSamochod();
            rpt.Pkw = this.SamochodPrywatnyCheckBox.Checked;
            rpt.Publiczny = this.PubliczneSrodkiCheckBox.Checked;
            rpt.Firmenwagen = this.SamochodFirmowyCheckBox.Checked;

            rpt.AdresNiemcy = this.AdresNiemcyTextBox.Text;
            rpt.Czynsz = this.CzynszNiemcyTextBox.Text;
            rpt.Odleglosc = this.OdlegloscTextBox.Text;
            rpt.Podroze = this.PodrozIleRazyTextBox.Text;
            rpt.NumerRejestracyjny1 = this.NumerRejestracyjnyTextBox.Text;
            rpt.NumerRejestracyjny2 = this.NumerRejestracyjny2TextBox.Text;
            
            // TYLKO NIEMIECKI FORMULARZ
            // ALE BRAKUJE POL NA FORMATCE
            //rpt.AdresNiemcy2;
            //rpt.Czynsz2;
            //rpt.Odleglosc2;
            //rpt.Podroze2;

            rpt.AdresMieszkanieNiem1 = this.MieszkanieNiemcy1TextBox.Text;
            rpt.AdresMieszkanieNiem2 = this.MieszkanieNiemcy2TextBox.Text;
            rpt.AdresPracaNiem1 = this.PracaNiemcy1TextBox.Text;
            rpt.AdresPracaNiem2 = this.PracaNiemcy2TextBox.Text;
            rpt.Dystans1 = this.OdlegloscNiemcy1TextBox.Text;
            rpt.Dystans2 = this.OdlegloscNiemcy2TextBox.Text;

            // TYLKO POLSKI
            rpt.KlasaPodatkowa = this.KlasaPodatkowaTextBox.Text;
            rpt.IloscKartPodatkowych = this.IleKartPodatkowychTextBox.Text;
            // checki
            rpt.OryginalnaKarta = this.OryginalnaKartaCheckBox.Checked;
            rpt.ZasilekPl = this.zasilekPolskaCheckBox.Checked;

            rpt.Genereate();
        }

        private void FillReport(string fileName)
        {
            // add content to existing PDF document with PdfStamper
            PdfStamper ps = null;
            try
            {
                // read existing PDF document
                PdfReader r = new PdfReader(@"..\..\Raporty\Strona\" + fileName);
                FileStream stream = new FileStream(@"c:\podatek_strona.pdf", FileMode.OpenOrCreate);
                ps = new PdfStamper(r, stream);
                // retrieve properties of PDF form w/AcroFields object
                AcroFields af = ps.AcroFields;
                // fill in PDF fields by parameter:
                // 1. field name
                // 2. text to insert

                //dane dotyczace raportu
                af.SetField("ImieOperatora", this.operatorTextBox.Text);
                af.SetField("DataPodpis", this.dataDateTimePicker.Value.ToShortDateString());

                //dane osobiste
                af.SetField("NazwiskoImieDe", this.nazwiskoDeTextBox.Text + "," + this.imieDeTextBox.Text);
                af.SetField("NazwiskoImiePl", this.nazwiskoTextBox.Text + "," + this.imieTextBox.Text);
                af.SetField("DataUrodz", this.urodzDateTimePicker.Date.IfValueThenShortDate());
                af.SetField("NIPniemiecki", this.steuernummerTextBox.Text);
                af.SetField("KodPocztowyMiejscowosc", this.kodTextBox.Text);
                af.SetField("Adres", this.ulicaTextBox.Text);
                af.SetField("Email", this.emailTextBox.Text);
                af.SetField("NumerKlienta", this.idTextBox.Text);
                af.SetField("Rok", this.rokTextBox.Text);
                af.SetField("Religia", this.wyznanieTextBox.Text);
                af.SetField("Telefon", this.telefonTextBox.Text);
                af.SetField("Komorka", this.komorkaTextBox.Text);

                if (this.zonatyTakradioButton.Checked)
                {
                    af.SetField("rbZonatyTak", "yes");
                }
                else
                {
                    af.SetField("rbZonatyNie", "no");
                }

                af.SetField("cxMiejsceZamieszMezaZonyNiemcy", this.ZamieszkanieNiemcyCheckBox.Checked ? "On" : "Off");
                af.SetField("cxMiejsceZamieszkMezaZonyPolska", this.zamieszakaniePolskaCheckBox.Checked ? "On" : "Off");
                af.SetField("cxMiejscePracyMezaZonyNiemcy", this.pracaNiemcyCheckBox.Checked ? "On" : "Off");
                af.SetField("cxMiejscePracyMezaZonyPolska", this.pracaPolskaCheckBox.Checked ? "On" : "Off");
                af.SetField("NipNiemieckiZony", this.nipZonyTextBox.Text);
                af.SetField("LiczbaDzieci", this.dzieciLiczbaTextBox.Text);
                af.SetField("cxZasilekPl", this.zasilekPolskaCheckBox.Checked ? "On" : "Off");
                af.SetField("cxZasilekNiem", this.zasilekNiemcyCheckBox.Checked ? "On" : "Off");
                af.SetField("DataSlubu", this.partnerSlubDateTimePicker.Date.IfValueThenShortDate());
                af.SetField("ReligiaZony", this.partnerWyznanieTextBox.Text);

                af.SetField("NrKlientaZony", this.partnerMandIdTextBox.Text);
                af.SetField("DataUrodzZony", this.partnerUrodzDateTimePicker.Date.IfValueThenShortDate());
                af.SetField("ImieMezaZony", this.partnerImieTextBox.Text);
                af.SetField("DochodyMezaPl", this.dochodyMazTextBox.Text);
                af.SetField("DochodyZonyPl", this.dochodyZonaTextBox.Text);

                //dane dot. rozenia
                af.SetField("Adres w Niemczech", this.AdresNiemcyTextBox.Text);
                af.SetField("CzynszWNiem", this.CzynszNiemcyTextBox.Text);
                af.SetField("IloscPodrozDom", this.PodrozIleRazyTextBox.Text);
                af.SetField("OdlegloscNiemPl", this.OdlegloscTextBox.Text);
                af.SetField("cxSamochPryw", this.SamochodPrywatnyCheckBox.Checked ? "On" : "Off");
                af.SetField("cxSamochFirmowy", this.SamochodFirmowyCheckBox.Checked ? "On" : "Off");
                af.SetField("cxTransportPublicz", this.PubliczneSrodkiCheckBox.Checked ? "On" : "Off");
                af.SetField("NumerRejestracyjny1", this.NumerRejestracyjnyTextBox.Text);
                af.SetField("NumerRejestracyjny2", this.NumerRejestracyjny2TextBox.Text);
                af.SetField("AdresMieszkanieNiem1", this.MieszkanieNiemcy1TextBox.Text);
                af.SetField("AdresMieszkanieNiem2", this.MieszkanieNiemcy2TextBox.Text);
                af.SetField("AdresPracaNiem1", this.PracaNiemcy1TextBox.Text);
                af.SetField("AdresPracaNiem2", this.PracaNiemcy2TextBox.Text);
                af.SetField("Odleglosc1", this.OdlegloscNiemcy1TextBox.Text);
                af.SetField("Odleglosc2", this.OdlegloscNiemcy2TextBox.Text);
                af.SetField("IloscKartPodatkowych", this.IleKartPodatkowychTextBox.Text);
                af.SetField("cxOryginalnaKarta", this.OryginalnaKartaCheckBox.Checked ? "On" : "Off");
                af.SetField("KlasaPodatkowa", this.KlasaPodatkowaTextBox.Text);



                // make resultant PDF read-only for end-user
                ps.FormFlattening = true;
                // forget to close() PdfStamper, you end up with
                // a corrupted file!
                ps.Close();
            }
            catch { }
            finally { if (ps != null) ps.Close(); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dane dotyczace raportu
            this.operatorTextBox.Text = "operator1";
            dataDateTimePicker.Value = new DateTime(2010, 11, 21);

            //dane osobiste
            this.nazwiskoDeTextBox.Text = "Walter, Ernest";
            this.nazwiskoTextBox.Text = "Walter, Ernest";
            this.urodzDateTimePicker.Date = new DateTime(2010, 11, 21);
            this.steuernummerTextBox.Text = "4234-234-234";
            this.kodTextBox.Text = "41-101";
            this.ulicaTextBox.Text = "ul. Nowa 1/1";
            this.emailTextBox.Text = "ernest@wp.pl";
            this.idTextBox.Text = "1121";
            this.rokTextBox.Text = "2010";
            this.wyznanieTextBox.Text = "RK";
            this.telefonTextBox.Text = "4423423";
            this.komorkaTextBox.Text = "4234324";

            this.zonatyTakradioButton.Checked = true;
            this.zonatyNieRadioButton.Checked = false;
            this.ZamieszkanieNiemcyCheckBox.Checked = true;
            this.zamieszakaniePolskaCheckBox.Checked = false;
            this.pracaNiemcyCheckBox.Checked = false;
            this.pracaPolskaCheckBox.Checked = true;
            this.nipZonyTextBox.Text = "42342-23423-43";
            this.dzieciLiczbaTextBox.Text = "1";
            this.zasilekPolskaCheckBox.Checked = true;
            this.zasilekNiemcyCheckBox.Checked = true;
            this.partnerSlubDateTimePicker.Date = new DateTime(2010, 11, 21);
            this.partnerWyznanieTextBox.Text = "RK";

            this.partnerMandIdTextBox.Text = "232";
            this.partnerUrodzDateTimePicker.Date = new DateTime(2010, 11, 21);
            this.partnerImieTextBox.Text = "Halina";
            this.dochodyMazTextBox.Text = "23000";
            this.dochodyZonaTextBox.Text = "12000";

            //dane dot. rozenia
            this.AdresNiemcyTextBox.Text = "ul. Nowa 2/2";
            this.CzynszNiemcyTextBox.Text = "200";
            this.PodrozIleRazyTextBox.Text = "1";
            this.OdlegloscTextBox.Text = "233";
            this.SamochodPrywatnyCheckBox.Checked = true;
            this.SamochodFirmowyCheckBox.Checked = false;
            this.PubliczneSrodkiCheckBox.Checked = true;
            this.NumerRejestracyjnyTextBox.Text = "Sk2324";
            this.NumerRejestracyjny2TextBox.Text = "Sk32423";
            this.MieszkanieNiemcy1TextBox.Text = "mieszkanie 1";
            this.MieszkanieNiemcy2TextBox.Text = "mieszkanie 2";
            this.PracaNiemcy1TextBox.Text = "praca 1";
            this.PracaNiemcy2TextBox.Text = "praca 2";
            this.OdlegloscNiemcy1TextBox.Text = "233";
            this.OdlegloscNiemcy2TextBox.Text = "231";
            this.IleKartPodatkowychTextBox.Text = "2";
            this.OryginalnaKartaCheckBox.Checked = true;
            this.KlasaPodatkowaTextBox.Text = "1";
        }

    }
}

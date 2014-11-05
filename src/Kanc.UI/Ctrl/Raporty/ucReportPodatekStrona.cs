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
using Kanc.Core.Features.Raporty;
using iTextSharp.text.pdf;
using System.IO;
using Kanc.Core.Entities;
using Kanc.Core.Features;
using System.Configuration;

namespace Kanc.UI.Ctrl
{
    public partial class ucReportPodatekStrona : BaseUserControl
    {
        public ucReportPodatekStrona()
        {
            InitializeComponent();
        }

        public override void LoadData(Binder binder, bool option)
        {
            Binder = binder;
            //TODO:
            //operatorTextBox.DataBindings.Add("Text", source, GetMemberName((Rozliczenie r) => r.Adres), true, DataSourceUpdateMode.OnPropertyChanged);
             binder.Bind(idTextBox,(Rozliczenie r) => r.Id);
             binder.Bind(rokTextBox,(Rozliczenie r) => r.Rok);
             binder.Bind(steuernummerTextBox,(Rozliczenie r) => r.Klient.Steuernummer);
             binder.Bind(nazwiskoTextBox,(Rozliczenie r) => r.Klient.Nazwisko);
             binder.Bind(nazwiskoDeTextBox,(Rozliczenie r) => r.Klient.NazwiskoDe);
             binder.Bind(imieTextBox,(Rozliczenie r) => r.Klient.Imie);
             binder.Bind(imieDeTextBox,(Rozliczenie r) => r.Klient.ImieDe);
             binder.Bind(wyznanieTextBox,(Rozliczenie r) => r.Klient.Religia);
             binder.Bind(emailTextBox,(Rozliczenie r) => r.Klient.Email);
             binder.Bind(ulicaTextBox,(Rozliczenie r) => r.Klient.AdresZameld.Ulica);
             binder.Bind(miejsceTextBox, (Rozliczenie r) => r.Klient.AdresZameld.Miejsce);
             binder.Bind(kodTextBox, (Rozliczenie r) => r.Klient.AdresZameld.Kod);
             binder.Bind(komorkaTextBox,(Rozliczenie r) => r.Klient.Komorka);
             binder.Bind(telefonTextBox,(Rozliczenie r) => r.Klient.Telefon);
             binder.Bind(dzieciLiczbaTextBox,(Rozliczenie r) => r.Klient.DzieciLiczba);
             binder.Bind(partnerImieTextBox,(Rozliczenie r) => r.Partner.Imie);
             binder.Bind(partnerMandIdTextBox,(Rozliczenie r) => r.Partner.MandId);
             binder.Bind(partnerWyznanieTextBox,(Rozliczenie r) => r.Partner.Religia);
             //pickery
             binder.Bind(urodzDateTimePicker,(Rozliczenie r) => r.Klient.Urodz);
             binder.Bind(partnerUrodzDateTimePicker,(Rozliczenie r) => r.Partner.Urodz);
             binder.Bind(partnerSlubDateTimePicker,(Rozliczenie r) => r.Klient.DataSlubu);
            
            //dataDateTimePicker.DataBindings.Add("Text", source, GetMemberName((Rozliczenie r) => r.Adres), true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void DrukujButton_Click(object sender, EventArgs e)
        {
            if (this.PlRadioButton.Checked)
            {
                FillReport2(RptLang.Polski);
            }
            else if (this.DeRadioButton.Checked)
            {
                //TODO: przygotuj niemiecka wersja pliki
                FillReport2(RptLang.Obcy);
            }
            else
            {
                //TODO: przygotuj wspolna wersje pliki pl + de
                FillReport2(RptLang.PolskiIObcy);
            }
        }

        private void FillReport2(RptLang jezyk)
        {
            IDictionary<string, string> dictionary = new Dictionary<string, string>();

            #region set fields 
            //dane dotyczace raportu
            dictionary.Add("ImieOperatora", this.operatorTextBox.Text);
            dictionary.Add("DataPodpis", this.dataDateTimePicker.Value.ToShortDateString());

            //dane osobiste
            dictionary.Add("NazwiskoImieDe", this.nazwiskoDeTextBox.Text + "," + this.imieDeTextBox.Text);
            dictionary.Add("NazwiskoImiePl", this.nazwiskoTextBox.Text + "," + this.imieTextBox.Text);
            dictionary.Add("DataUrodz", this.urodzDateTimePicker.Date.IfValueThenShortDate());
            dictionary.Add("NIPniemiecki", this.steuernummerTextBox.Text);
            dictionary.Add("KodPocztowyMiejscowosc", this.kodTextBox.Text);
            dictionary.Add("Adres", this.ulicaTextBox.Text);
            dictionary.Add("Email", this.emailTextBox.Text);
            dictionary.Add("NumerKlienta", this.idTextBox.Text);
            dictionary.Add("Rok", this.rokTextBox.Text);
            dictionary.Add("Religia", this.wyznanieTextBox.Text);
            dictionary.Add("Telefon", this.telefonTextBox.Text);
            dictionary.Add("Komorka", this.komorkaTextBox.Text);

            if (this.zonatyTakradioButton.Checked)
                dictionary.Add("rbZonatyTak", "yes");
            else
                dictionary.Add("rbZonatyNie", "no");

            dictionary.Add("cxMiejsceZamieszMezaZonyNiemcy", this.ZamieszkanieNiemcyCheckBox.Checked ? "On" : "Off");
            dictionary.Add("cxMiejsceZamieszkMezaZonyPolska", this.zamieszakaniePolskaCheckBox.Checked ? "On" : "Off");
            dictionary.Add("cxMiejscePracyMezaZonyNiemcy", this.pracaNiemcyCheckBox.Checked ? "On" : "Off");
            dictionary.Add("cxMiejscePracyMezaZonyPolska", this.pracaPolskaCheckBox.Checked ? "On" : "Off");
            dictionary.Add("NipNiemieckiZony", this.nipZonyTextBox.Text);
            dictionary.Add("LiczbaDzieci", this.dzieciLiczbaTextBox.Text);
            dictionary.Add("cxZasilekPl", this.zasilekPolskaCheckBox.Checked ? "On" : "Off");
            dictionary.Add("cxZasilekNiem", this.zasilekNiemcyCheckBox.Checked ? "On" : "Off");
            dictionary.Add("DataSlubu", this.partnerSlubDateTimePicker.Date.IfValueThenShortDate());
            dictionary.Add("ReligiaZony", this.partnerWyznanieTextBox.Text);

            dictionary.Add("NrKlientaZony", this.partnerMandIdTextBox.Text);
            dictionary.Add("DataUrodzZony", this.partnerUrodzDateTimePicker.Date.IfValueThenShortDate());
            dictionary.Add("ImieMezaZony", this.partnerImieTextBox.Text);
            dictionary.Add("DochodyMezaPl", this.dochodyMazTextBox.Text);
            dictionary.Add("DochodyZonyPl", this.dochodyZonaTextBox.Text);

            //dane dot. rozenia
            dictionary.Add("Adres w Niemczech", this.AdresNiemcyTextBox.Text);
            dictionary.Add("CzynszWNiem", this.CzynszNiemcyTextBox.Text);
            dictionary.Add("IloscPodrozDom", this.PodrozIleRazyTextBox.Text);
            dictionary.Add("OdlegloscNiemPl", this.OdlegloscTextBox.Text);
            dictionary.Add("cxSamochPryw", this.SamochodPrywatnyCheckBox.Checked ? "On" : "Off");
            dictionary.Add("cxSamochFirmowy", this.SamochodFirmowyCheckBox.Checked ? "On" : "Off");
            dictionary.Add("cxTransportPublicz", this.PubliczneSrodkiCheckBox.Checked ? "On" : "Off");
            dictionary.Add("NumerRejestracyjny1", this.NumerRejestracyjnyTextBox.Text);
            dictionary.Add("NumerRejestracyjny2", this.NumerRejestracyjny2TextBox.Text);
            dictionary.Add("AdresMieszkanieNiem1", this.MieszkanieNiemcy1TextBox.Text);
            dictionary.Add("AdresMieszkanieNiem2", this.MieszkanieNiemcy2TextBox.Text);
            dictionary.Add("AdresPracaNiem1", this.PracaNiemcy1TextBox.Text);
            dictionary.Add("AdresPracaNiem2", this.PracaNiemcy2TextBox.Text);
            dictionary.Add("Odleglosc1", this.OdlegloscNiemcy1TextBox.Text);
            dictionary.Add("Odleglosc2", this.OdlegloscNiemcy2TextBox.Text);
            dictionary.Add("IloscKartPodatkowych", this.IleKartPodatkowychTextBox.Text);
            dictionary.Add("cxOryginalnaKarta", this.OryginalnaKartaCheckBox.Checked ? "On" : "Off");
            dictionary.Add("KlasaPodatkowa", this.KlasaPodatkowaTextBox.Text);
            #endregion

            Rozliczenie roz = Binder.source.Current as Rozliczenie;
            BaseRpt raport = RaportFactory.Niemcy.StronaNiemcy.Create(2011, roz, jezyk);
            dictionary.ToList().ForEach(x => raport.Fields[x.Key] = x.Value);
            raport.Genereate();
            //generator.Typ = TypRaportu.StronaNiemcy;
            //generator.TemplatePath = ConfigurationSettings.AppSettings["RaportTemplatePathStrona"];
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

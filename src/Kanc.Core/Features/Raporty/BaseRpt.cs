using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection;
using System.Text;
using Kanc.Commons;
using Kanc.Core.Entities;

namespace Kanc.Core.Features.Raporty
{
    public interface IRaport
    {
        string FileName { get; set; }
        int Rok { get; set; }
        RptLang Language { get; set; }

        string ResolveReportPath();
        void MapFieldsWithRozliczenie(Rozliczenie rozlicz);
        Fields Fields { get; set; }
    }

    public class BaseRpt : IRaport
    {
        public string FileName { get; set; }
        public string CountryFolderCode { get; set; }
        public int Rok { get; set; }
        public RptLang Language { get; set; }
        public Rozliczenie Rozliczenie { get; set; }
        public Fields Fields { get; set; }

        public virtual string ResolveReportPath()
        {
            string path = CountryFolderCode + "/" + FileName;
            return path;
        }

        public virtual void MapFieldsWithRozliczenie(Rozliczenie rozlicz)
        {
            //podst
            Fields["NazwiskoImie"] = rozlicz.Klient.Nazwisko + ", " + rozlicz.Klient.Imie;
            Fields["NazwiskoImieDe"] = rozlicz.Klient.NazwiskoDe + ", " + rozlicz.Klient.ImieDe;
            Fields["NazwiskoImiePl"] = rozlicz.Klient.Nazwisko + ", " + rozlicz.Klient.Imie;
            
            Fields["nazwisko"] = rozlicz.Klient.Nazwisko;
            Fields["imie"] = rozlicz.Klient.Imie;
            Fields["Name"] = rozlicz.Klient.NazwiskoDe;
            Fields["Vorname"] = rozlicz.Klient.ImieDe;

            
            Fields["ImieINazwisko"] = rozlicz.Klient.ImieINazwisko;
            Fields["ImieNazwisko"] = rozlicz.Klient.ImieINazwisko;
            Fields["klientFullName"] = rozlicz.Klient.ImieINazwisko;
            Fields["KlientAdresFull"] = rozlicz.Klient.AdresZameld.PelnyAdres();

            Fields["PartnerFullName"] = rozlicz.Partner.ImieINazwisko;
            //Fields["PartnerAdresFull"] = rozlicz.Partner. //BRAK
            
            //if (rozlicz.Klient.Imie.Last() == 'a') //herr frau
            //    Fields["PanPani"] = "Pani " + Fields["ImieINazwisko"];
            //else
            //    Fields["PanPani"] = "Pan " + Fields["ImieINazwisko"];
            Fields["PanPani"] = "Pani " + Fields["ImieINazwisko"];


            //daty
            Fields["rok"] = rozlicz.Rok.ToString();
            Fields["Rok"] = rozlicz.Rok.ToString();
            Fields["Year"] = rozlicz.Rok.ToString();
            Fields["DataUrodz"] = rozlicz.Klient.Urodz.IfValueThenShortDate();
            Fields["dataur"] = rozlicz.Klient.Urodz.IfValueThenShortDate();

            //numery
            Fields["Mandaten"] = rozlicz.Klient.MandId;
            Fields["NIPniemiecki"] = rozlicz.Klient.Steuernummer;
            Fields["Email"] = rozlicz.Klient.Email;
            Fields["Telefon"] = rozlicz.Klient.Telefon;
            Fields["Komorka"] = rozlicz.Klient.Komorka;
            
            //adresy
            Fields["Adres"] = rozlicz.AdresRozliczenia.PelnyAdres();
            Fields["miejscezam"] = rozlicz.AdresRozliczenia.Miejsce; //?
            Fields["Ort"] = rozlicz.AdresRozliczenia.Miejsce;

            Fields["kodpocztowy"] = rozlicz.AdresRozliczenia.Kod;
            Fields["KodPocztowyMiejscowosc"] = rozlicz.AdresRozliczenia.Kod;
            Fields["PZL"] = rozlicz.AdresRozliczenia.Kod;

            Fields["Strasse"] = rozlicz.AdresRozliczenia.Ulica;
            Fields["ulica"] = rozlicz.AdresRozliczenia.Ulica;
            Fields["Stadt"] = rozlicz.AdresRozliczenia.Miasto;
            
            //partner
            Fields["imiePartner"] = rozlicz.Partner.Imie;
            Fields["nazwiskoPartner"] = rozlicz.Partner.Nazwisko;
            Fields["dataurPartner"] = rozlicz.Partner.Urodz.IfValueThenShortDate();
            Fields["dataZonatyOd"] = rozlicz.Klient.DataSlubu.IfValueThenShortDate(); 

            //BRAKUJACY DANE
            //Fields["obywatelstwo"] = rozlicz.Klient.;
            //Fields["krajzam"] = rozlicz.Klient.;
            //Fields["obywatelstwoPartner"] = rozlicz;
            //Fields["kodpocztowyPartner"] = rozlicz.Partner;
            //Fields["krajzamPartner"] = rozlicz;
            //Fields["miejscezamPartner"] = rozlicz;
            //Fields["ulicaPartner"] = rozlicz;
            //Fields["dataWdowiecOd"] = rozlicz;

            Fields["ImieOperatora"] = rozlicz.CreatedBy;
            Fields["DataPodpis"] = DateTime.Now.ToShortDateString();
            Fields["Data"] = DateTime.Now.ToShortDateString();
        }

        public virtual void AddPropertiesToFields()
        {
            //throw new NotImplementedException();
        }

        public virtual BaseRpt Map(Rozliczenie roz) { return Map(roz.Rok, roz, RptLang.Obcy, null); }

        public virtual BaseRpt Map(int rok, Rozliczenie rozlicz, RptLang lang = RptLang.Obcy, Dictionary<string, string> fields = null)
        {
            Language = lang;
            Fields = new Fields();

            if(rok > 1990) Rok = rok;
            if (rozlicz != null) Rozliczenie = rozlicz;
            if (fields != null) Fields.AddRange(fields);

            Contract.Ensures(Rozliczenie != null, "Rozliczenie raczej nie moze byc puste!");
            Contract.Ensures(Rok > 1990, "Rok wyglada na zle ustawiony");
            
            //for testing only
            if (Context.IsReportTestingMode)
            {
                AddPropertiesToFields();

                var list = Fields.Keys.ToList();
                foreach (string key in list)
                {
                    Fields[key] = key;
                }
            }

            //ResolveReportPath();

            if (Rozliczenie != null)
            {
                Fields.InitFieldsName(Rozliczenie);
                MapFieldsWithRozliczenie(Rozliczenie);
            }

            return this;
        }

        public void Genereate()
        {
            RaportGenerator generator = new RaportGenerator();
            generator.ReportPath = "/Raporty/";
            generator.InitialFolderToSave = ConfigurationSettings.AppSettings["InitialDirectoryToSaveReport"];
            generator.GenerateReport(this);
        }

    }
}

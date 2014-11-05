using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kanc.Core.Entities;

namespace Kanc.Core.Features.Raporty.DE
{
    public class BaseStronaniemcy_de : BaseRpt
    {
		public string MandantenNr
		{
			get { return Fields["MandantenNr"]; }
			set { Fields["MandantenNr"] = value; }
		}
		public string Deutschland
		{
			get { return Fields["Deutschland"]; }
			set { Fields["Deutschland"] = value; }
		}
		public string Polen
		{
			get { return Fields["Polen"]; }
			set { Fields["Polen"] = value; }
		}
		public string Pkw
		{
			get { return Fields["Pkw"]; }
			set { Fields["Pkw"] = value; }
		}
		public string Firmenwagen
		{
			get { return Fields["Firmenwagen"]; }
			set { Fields["Firmenwagen"] = value; }
		}
		public string Pkw_2
		{
			get { return Fields["Pkw_2"]; }
			set { Fields["Pkw_2"] = value; }
		}
		public string Firmenwagen_2
		{
			get { return Fields["Firmenwagen_2"]; }
			set { Fields["Firmenwagen_2"] = value; }
		}
		public string Steuernummer
		{
			get { return Fields["steuernummer"]; }
			set { Fields["steuernummer"] = value; }
		}
		public string NazwiskoImieDe
		{
			get { return Fields["nazwiskoImieDe"]; }
			set { Fields["nazwiskoImieDe"] = value; }
		}
		public string Rok
		{
			get { return Fields["rok"]; }
			set { Fields["rok"] = value; }
		}
		public string Urodz
		{
			get { return Fields["urodz"]; }
			set { Fields["urodz"] = value; }
		}
		public string Religia
		{
			get { return Fields["religia"]; }
			set { Fields["religia"] = value; }
		}
		public string Kod
		{
			get { return Fields["kod"]; }
			set { Fields["kod"] = value; }
		}
		public string Miejscowosc
		{
			get { return Fields["miejscowosc"]; }
			set { Fields["miejscowosc"] = value; }
		}
		public string Ulica
		{
			get { return Fields["ulica"]; }
			set { Fields["ulica"] = value; }
		}
		public string DataSlubu
		{
			get { return Fields["dataSlubu"]; }
			set { Fields["dataSlubu"] = value; }
		}
		public string PartnerImie
		{
			get { return Fields["partnerImie"]; }
			set { Fields["partnerImie"] = value; }
		}
		public string PartnerUrodz
		{
			get { return Fields["partnerUrodz"]; }
			set { Fields["partnerUrodz"] = value; }
		}
		public string PartnerSteuernummer
		{
			get { return Fields["partnerSteuernummer"]; }
			set { Fields["partnerSteuernummer"] = value; }
		}
		public string PartnerReligia
		{
			get { return Fields["partnerReligia"]; }
			set { Fields["partnerReligia"] = value; }
		}
		public string LiczbaDzieci
		{
			get { return Fields["liczbaDzieci"]; }
			set { Fields["liczbaDzieci"] = value; }
		}
		public string PartnerZarobki
		{
			get { return Fields["partnerZarobki"]; }
			set { Fields["partnerZarobki"] = value; }
		}
		public string AdresNiemcy
		{
			get { return Fields["adresNiemcy"]; }
			set { Fields["adresNiemcy"] = value; }
		}
		public string AdresNiemcy2
		{
			get { return Fields["adresNiemcy2"]; }
			set { Fields["adresNiemcy2"] = value; }
		}
		public string Czynsz
		{
			get { return Fields["czynsz"]; }
			set { Fields["czynsz"] = value; }
		}
		public string Czynsz2
		{
			get { return Fields["czynsz2"]; }
			set { Fields["czynsz2"] = value; }
		}
		public string Podroze2
		{
			get { return Fields["podroze2"]; }
			set { Fields["podroze2"] = value; }
		}
		public string Odleglosc
		{
			get { return Fields["odleglosc"]; }
			set { Fields["odleglosc"] = value; }
		}
		public string Podroze
		{
			get { return Fields["podroze"]; }
			set { Fields["podroze"] = value; }
		}
		public string NumerRejestracyjny1
		{
			get { return Fields["numerRejestracyjny1"]; }
			set { Fields["numerRejestracyjny1"] = value; }
		}
		public string NumerRejestracyjny2
		{
			get { return Fields["numerRejestracyjny2"]; }
			set { Fields["numerRejestracyjny2"] = value; }
		}
		public string AdresMieszkanieNiem1
		{
			get { return Fields["adresMieszkanieNiem1"]; }
			set { Fields["adresMieszkanieNiem1"] = value; }
		}
		public string AdresMieszkanieNiem2
		{
			get { return Fields["adresMieszkanieNiem2"]; }
			set { Fields["adresMieszkanieNiem2"] = value; }
		}
		public string AdresPracaNiem1
		{
			get { return Fields["adresPracaNiem1"]; }
			set { Fields["adresPracaNiem1"] = value; }
		}
		public string AdresPracaNiem2
		{
			get { return Fields["adresPracaNiem2"]; }
			set { Fields["adresPracaNiem2"] = value; }
		}
		public string Odleglosc2
		{
			get { return Fields["odleglosc2"]; }
			set { Fields["odleglosc2"] = value; }
		}
		public string Dystans1
		{
			get { return Fields["dystans1"]; }
			set { Fields["dystans1"] = value; }
		}
		public string Dystans2
		{
			get { return Fields["dystans2"]; }
			set { Fields["dystans2"] = value; }
		}
		public string Zarobki
		{
			get { return Fields["zarobki"]; }
			set { Fields["zarobki"] = value; }
		}
		public string Zawod
		{
			get { return Fields["zawod"]; }
			set { Fields["zawod"] = value; }
		}
		public string InneDochody
		{
			get { return Fields["inneDochody"]; }
			set { Fields["inneDochody"] = value; }
		}
		public string DataPodpis
		{
			get { return Fields["DataPodpis"]; }
			set { Fields["DataPodpis"] = value; }
		}
		public string Publiczny
		{
			get { return Fields["publiczny"]; }
			set { Fields["publiczny"] = value; }
		}
		public string Publiczny2
		{
			get { return Fields["publiczny2"]; }
			set { Fields["publiczny2"] = value; }
		}
		public string Telefon
		{
			get { return Fields["telefon"]; }
			set { Fields["telefon"] = value; }
		}

		public override void AddPropertiesToFields() 
		{
			Fields.Add("MandantenNr","MandantenNr");
			Fields.Add("Deutschland","Deutschland");
			Fields.Add("Polen","Polen");
			Fields.Add("Pkw","Pkw");
			Fields.Add("Firmenwagen","Firmenwagen");
			Fields.Add("Pkw_2","Pkw_2");
			Fields.Add("Firmenwagen_2","Firmenwagen_2");
			Fields.Add("steuernummer","steuernummer");
			Fields.Add("nazwiskoImieDe","nazwiskoImieDe");
			Fields.Add("rok","rok");
			Fields.Add("urodz","urodz");
			Fields.Add("religia","religia");
			Fields.Add("kod","kod");
			Fields.Add("miejscowosc","miejscowosc");
			Fields.Add("ulica","ulica");
			Fields.Add("dataSlubu","dataSlubu");
			Fields.Add("partnerImie","partnerImie");
			Fields.Add("partnerUrodz","partnerUrodz");
			Fields.Add("partnerSteuernummer","partnerSteuernummer");
			Fields.Add("partnerReligia","partnerReligia");
			Fields.Add("liczbaDzieci","liczbaDzieci");
			Fields.Add("partnerZarobki","partnerZarobki");
			Fields.Add("adresNiemcy","adresNiemcy");
			Fields.Add("adresNiemcy2","adresNiemcy2");
			Fields.Add("czynsz","czynsz");
			Fields.Add("czynsz2","czynsz2");
			Fields.Add("podroze2","podroze2");
			Fields.Add("odleglosc","odleglosc");
			Fields.Add("podroze","podroze");
			Fields.Add("numerRejestracyjny1","numerRejestracyjny1");
			Fields.Add("numerRejestracyjny2","numerRejestracyjny2");
			Fields.Add("adresMieszkanieNiem1","adresMieszkanieNiem1");
			Fields.Add("adresMieszkanieNiem2","adresMieszkanieNiem2");
			Fields.Add("adresPracaNiem1","adresPracaNiem1");
			Fields.Add("adresPracaNiem2","adresPracaNiem2");
			Fields.Add("odleglosc2","odleglosc2");
			Fields.Add("dystans1","dystans1");
			Fields.Add("dystans2","dystans2");
			Fields.Add("zarobki","zarobki");
			Fields.Add("zawod","zawod");
			Fields.Add("inneDochody","inneDochody");
			Fields.Add("DataPodpis","DataPodpis");
			Fields.Add("publiczny","publiczny");
			Fields.Add("publiczny2","publiczny2");
			Fields.Add("telefon","telefon");

        }
    }
}
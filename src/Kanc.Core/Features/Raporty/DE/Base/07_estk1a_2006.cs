using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kanc.Core.Entities;

namespace Kanc.Core.Features.Raporty.DE
{
    public class BaseEstk1a_2006 : BaseRpt
    {
		public string Steuernummer
		{
			get { return Fields["Steuernummer"]; }
			set { Fields["Steuernummer"] = value; }
		}
		public string ZonaData
		{
			get { return Fields["ZonaData"]; }
			set { Fields["ZonaData"] = value; }
		}
		public string ZonaReligia
		{
			get { return Fields["ZonaReligia"]; }
			set { Fields["ZonaReligia"] = value; }
		}
		public string BankKonto
		{
			get { return Fields["BankKonto"]; }
			set { Fields["BankKonto"] = value; }
		}
		public string BankKod
		{
			get { return Fields["BankKod"]; }
			set { Fields["BankKod"] = value; }
		}
		public string BankAdres
		{
			get { return Fields["BankAdres"]; }
			set { Fields["BankAdres"] = value; }
		}
		public string FirmaPoczta
		{
			get { return Fields["FirmaPoczta"]; }
			set { Fields["FirmaPoczta"] = value; }
		}
		public string FirmaAdres
		{
			get { return Fields["FirmaAdres"]; }
			set { Fields["FirmaAdres"] = value; }
		}
		public string FirmaOkreg
		{
			get { return Fields["FirmaOkreg"]; }
			set { Fields["FirmaOkreg"] = value; }
		}
		public string Nazwisko
		{
			get { return Fields["Nazwisko"]; }
			set { Fields["Nazwisko"] = value; }
		}
		public string Imie
		{
			get { return Fields["Imie"]; }
			set { Fields["Imie"] = value; }
		}
		public string Zawod
		{
			get { return Fields["Zawod"]; }
			set { Fields["Zawod"] = value; }
		}
		public string AdresKod
		{
			get { return Fields["AdresKod"]; }
			set { Fields["AdresKod"] = value; }
		}
		public string AdresMIasto
		{
			get { return Fields["AdresMIasto"]; }
			set { Fields["AdresMIasto"] = value; }
		}
		public string AdresUlica
		{
			get { return Fields["AdresUlica"]; }
			set { Fields["AdresUlica"] = value; }
		}
		public string Uordzony
		{
			get { return Fields["Uordzony"]; }
			set { Fields["Uordzony"] = value; }
		}
		public string Religia
		{
			get { return Fields["Religia"]; }
			set { Fields["Religia"] = value; }
		}
		public string ZonaImie
		{
			get { return Fields["ZonaImie"]; }
			set { Fields["ZonaImie"] = value; }
		}
		public string FirmaNazwa1
		{
			get { return Fields["FirmaNazwa1"]; }
			set { Fields["FirmaNazwa1"] = value; }
		}
		public string FirmaNazwa2
		{
			get { return Fields["FirmaNazwa2"]; }
			set { Fields["FirmaNazwa2"] = value; }
		}

		public override void AddPropertiesToFields() 
		{
			Fields.Add("Steuernummer","Steuernummer");
			Fields.Add("ZonaData","ZonaData");
			Fields.Add("ZonaReligia","ZonaReligia");
			Fields.Add("BankKonto","BankKonto");
			Fields.Add("BankKod","BankKod");
			Fields.Add("BankAdres","BankAdres");
			Fields.Add("FirmaPoczta","FirmaPoczta");
			Fields.Add("FirmaAdres","FirmaAdres");
			Fields.Add("FirmaOkreg","FirmaOkreg");
			Fields.Add("Nazwisko","Nazwisko");
			Fields.Add("Imie","Imie");
			Fields.Add("Zawod","Zawod");
			Fields.Add("AdresKod","AdresKod");
			Fields.Add("AdresMIasto","AdresMIasto");
			Fields.Add("AdresUlica","AdresUlica");
			Fields.Add("Uordzony","Uordzony");
			Fields.Add("Religia","Religia");
			Fields.Add("ZonaImie","ZonaImie");
			Fields.Add("FirmaNazwa1","FirmaNazwa1");
			Fields.Add("FirmaNazwa2","FirmaNazwa2");

        }
    }
}
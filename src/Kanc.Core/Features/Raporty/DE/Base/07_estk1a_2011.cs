using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kanc.Core.Entities;

namespace Kanc.Core.Features.Raporty.DE
{
    public class BaseEstk1a_2011 : BaseRpt
    {
		public string Steuernummer
		{
			get { return Fields["Steuernummer"]; }
			set { Fields["Steuernummer"] = value; }
		}
		public string Nazwisko
		{
			get { return Fields["Nazwisko"]; }
			set { Fields["Nazwisko"] = value; }
		}
		public string Urodzony
		{
			get { return Fields["Urodzony"]; }
			set { Fields["Urodzony"] = value; }
		}
		public string Imie
		{
			get { return Fields["Imie"]; }
			set { Fields["Imie"] = value; }
		}
		public string AdresUlica
		{
			get { return Fields["AdresUlica"]; }
			set { Fields["AdresUlica"] = value; }
		}
		public string AdresKod
		{
			get { return Fields["AdresKod"]; }
			set { Fields["AdresKod"] = value; }
		}
		public string AdresMiasto
		{
			get { return Fields["AdresMiasto"]; }
			set { Fields["AdresMiasto"] = value; }
		}
		public string Religia
		{
			get { return Fields["Religia"]; }
			set { Fields["Religia"] = value; }
		}
		public string Zawod
		{
			get { return Fields["Zawod"]; }
			set { Fields["Zawod"] = value; }
		}
		public string ZonaImie
		{
			get { return Fields["ZonaImie"]; }
			set { Fields["ZonaImie"] = value; }
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
		public string FirmaAdres
		{
			get { return Fields["FirmaAdres"]; }
			set { Fields["FirmaAdres"] = value; }
		}
		public string FirmaPoczta
		{
			get { return Fields["FirmaPoczta"]; }
			set { Fields["FirmaPoczta"] = value; }
		}
		public string FirmaOkreg
		{
			get { return Fields["FirmaOkreg"]; }
			set { Fields["FirmaOkreg"] = value; }
		}

		public override void AddPropertiesToFields() 
		{
			Fields.Add("Steuernummer","Steuernummer");
			Fields.Add("Nazwisko","Nazwisko");
			Fields.Add("Urodzony","Urodzony");
			Fields.Add("Imie","Imie");
			Fields.Add("AdresUlica","AdresUlica");
			Fields.Add("AdresKod","AdresKod");
			Fields.Add("AdresMiasto","AdresMiasto");
			Fields.Add("Religia","Religia");
			Fields.Add("Zawod","Zawod");
			Fields.Add("ZonaImie","ZonaImie");
			Fields.Add("ZonaData","ZonaData");
			Fields.Add("ZonaReligia","ZonaReligia");
			Fields.Add("BankKonto","BankKonto");
			Fields.Add("BankKod","BankKod");
			Fields.Add("BankAdres","BankAdres");
			Fields.Add("FirmaNazwa1","FirmaNazwa1");
			Fields.Add("FirmaNazwa2","FirmaNazwa2");
			Fields.Add("FirmaAdres","FirmaAdres");
			Fields.Add("FirmaPoczta","FirmaPoczta");
			Fields.Add("FirmaOkreg","FirmaOkreg");

        }
    }
}
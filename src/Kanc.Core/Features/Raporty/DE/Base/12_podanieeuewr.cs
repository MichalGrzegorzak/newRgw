using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kanc.Core.Entities;

namespace Kanc.Core.Features.Raporty.DE
{
    public class BasePodanieeuewr : BaseRpt
    {
		public string Nazwisko
		{
			get { return Fields["Nazwisko"]; }
			set { Fields["Nazwisko"] = value; }
		}
		public string Imiona
		{
			get { return Fields["Imiona"]; }
			set { Fields["Imiona"] = value; }
		}
		public string NIP
		{
			get { return Fields["NIP"]; }
			set { Fields["NIP"] = value; }
		}
		public string Podpis
		{
			get { return Fields["podpis"]; }
			set { Fields["podpis"] = value; }
		}
		public string Miejscowosc
		{
			get { return Fields["Miejscowosc"]; }
			set { Fields["Miejscowosc"] = value; }
		}
		public string Data
		{
			get { return Fields["Data"]; }
			set { Fields["Data"] = value; }
		}
		public string AdresZamieszkania
		{
			get { return Fields["AdresZamieszkania"]; }
			set { Fields["AdresZamieszkania"] = value; }
		}
		public string KodPocztowyMiejsceZamieszkania
		{
			get { return Fields["KodPocztowyMiejsceZamieszkania"]; }
			set { Fields["KodPocztowyMiejsceZamieszkania"] = value; }
		}
		public string DataUrodzenia
		{
			get { return Fields["DataUrodzenia"]; }
			set { Fields["DataUrodzenia"] = value; }
		}
		public string ObywatelstwoObywatelstwa
		{
			get { return Fields["ObywatelstwoObywatelstwa"]; }
			set { Fields["ObywatelstwoObywatelstwa"] = value; }
		}
		public string WSprawie
		{
			get { return Fields["WSprawie"]; }
			set { Fields["WSprawie"] = value; }
		}
		public string WpiszRok
		{
			get { return Fields["WpiszRok"]; }
			set { Fields["WpiszRok"] = value; }
		}
		public string MalzonekNazwisko
		{
			get { return Fields["MalzonekNazwisko"]; }
			set { Fields["MalzonekNazwisko"] = value; }
		}
		public string MalzonekImiona
		{
			get { return Fields["MalzonekImiona"]; }
			set { Fields["MalzonekImiona"] = value; }
		}
		public string MalzonekAdresZamieszkania
		{
			get { return Fields["MalzonekAdresZamieszkania"]; }
			set { Fields["MalzonekAdresZamieszkania"] = value; }
		}
		public string MalzonekKodPocztowyMiejsceZamieszkania
		{
			get { return Fields["MalzonekKodPocztowyMiejsceZamieszkania"]; }
			set { Fields["MalzonekKodPocztowyMiejsceZamieszkania"] = value; }
		}
		public string MalzonekDataUrodzenia
		{
			get { return Fields["MalzonekDataUrodzenia"]; }
			set { Fields["MalzonekDataUrodzenia"] = value; }
		}
		public string MalzonekObywatelstwoObywatelstwa
		{
			get { return Fields["MalzonekObywatelstwoObywatelstwa"]; }
			set { Fields["MalzonekObywatelstwoObywatelstwa"] = value; }
		}
		public string MalzonekNIP
		{
			get { return Fields["MalzonekNIP"]; }
			set { Fields["MalzonekNIP"] = value; }
		}
		public string MalzonekWpiszRok
		{
			get { return Fields["MalzonekWpiszRok"]; }
			set { Fields["MalzonekWpiszRok"] = value; }
		}
		public string MalzonekPodpis
		{
			get { return Fields["MalzonekPodpis"]; }
			set { Fields["MalzonekPodpis"] = value; }
		}
		public string MiejscowoscUS
		{
			get { return Fields["MiejscowoscUS"]; }
			set { Fields["MiejscowoscUS"] = value; }
		}

		public override void AddPropertiesToFields() 
		{
			Fields.Add("Nazwisko","Nazwisko");
			Fields.Add("Imiona","Imiona");
			Fields.Add("NIP","NIP");
			Fields.Add("podpis","podpis");
			Fields.Add("Miejscowosc","Miejscowosc");
			Fields.Add("Data","Data");
			Fields.Add("AdresZamieszkania","AdresZamieszkania");
			Fields.Add("KodPocztowyMiejsceZamieszkania","KodPocztowyMiejsceZamieszkania");
			Fields.Add("DataUrodzenia","DataUrodzenia");
			Fields.Add("ObywatelstwoObywatelstwa","ObywatelstwoObywatelstwa");
			Fields.Add("WSprawie","WSprawie");
			Fields.Add("WpiszRok","WpiszRok");
			Fields.Add("MalzonekNazwisko","MalzonekNazwisko");
			Fields.Add("MalzonekImiona","MalzonekImiona");
			Fields.Add("MalzonekAdresZamieszkania","MalzonekAdresZamieszkania");
			Fields.Add("MalzonekKodPocztowyMiejsceZamieszkania","MalzonekKodPocztowyMiejsceZamieszkania");
			Fields.Add("MalzonekDataUrodzenia","MalzonekDataUrodzenia");
			Fields.Add("MalzonekObywatelstwoObywatelstwa","MalzonekObywatelstwoObywatelstwa");
			Fields.Add("MalzonekNIP","MalzonekNIP");
			Fields.Add("MalzonekWpiszRok","MalzonekWpiszRok");
			Fields.Add("MalzonekPodpis","MalzonekPodpis");
			Fields.Add("MiejscowoscUS","MiejscowoscUS");

        }
    }
}
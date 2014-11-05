using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kanc.Core.Entities;

namespace Kanc.Core.Features.Raporty.DE
{
    public class BasePrzebiegauta : BaseRpt
    {
		public string Data
		{
			get { return Fields["Data"]; }
			set { Fields["Data"] = value; }
		}
		public string NazwiskoImie
		{
			get { return Fields["NazwiskoImie"]; }
			set { Fields["NazwiskoImie"] = value; }
		}
		public string Marka
		{
			get { return Fields["Marka"]; }
			set { Fields["Marka"] = value; }
		}
		public string NrRejestracyjny
		{
			get { return Fields["NrRejestracyjny"]; }
			set { Fields["NrRejestracyjny"] = value; }
		}
		public string TypModel
		{
			get { return Fields["TypModel"]; }
			set { Fields["TypModel"] = value; }
		}
		public string Km_2
		{
			get { return Fields["Km_2"]; }
			set { Fields["Km_2"] = value; }
		}
		public string Km_3
		{
			get { return Fields["Km_3"]; }
			set { Fields["Km_3"] = value; }
		}
		public string Km_4
		{
			get { return Fields["Km_4"]; }
			set { Fields["Km_4"] = value; }
		}
		public string Km_1
		{
			get { return Fields["Km_1"]; }
			set { Fields["Km_1"] = value; }
		}
		public string Fahrzeug_1
		{
			get { return Fields["Fahrzeug_1"]; }
			set { Fields["Fahrzeug_1"] = value; }
		}
		public string Fahrzeug_2
		{
			get { return Fields["Fahrzeug_2"]; }
			set { Fields["Fahrzeug_2"] = value; }
		}
		public string VIN
		{
			get { return Fields["VIN"]; }
			set { Fields["VIN"] = value; }
		}
		public string NrSilnika
		{
			get { return Fields["NrSilnika"]; }
			set { Fields["NrSilnika"] = value; }
		}
		public string DataPoprzedniegoOdczytu
		{
			get { return Fields["DataPoprzedniegoOdczytu"]; }
			set { Fields["DataPoprzedniegoOdczytu"] = value; }
		}
		public string PoprzedniStanLicznika
		{
			get { return Fields["PoprzedniStanLicznika"]; }
			set { Fields["PoprzedniStanLicznika"] = value; }
		}
		public string DataOdczytu
		{
			get { return Fields["DataOdczytu"]; }
			set { Fields["DataOdczytu"] = value; }
		}
		public string StanLicznikaObecny
		{
			get { return Fields["StanLicznikaObecny"]; }
			set { Fields["StanLicznikaObecny"] = value; }
		}

		public override void AddPropertiesToFields() 
		{
			Fields.Add("Data","Data");
			Fields.Add("NazwiskoImie","NazwiskoImie");
			Fields.Add("Marka","Marka");
			Fields.Add("NrRejestracyjny","NrRejestracyjny");
			Fields.Add("TypModel","TypModel");
			Fields.Add("Km_2","Km_2");
			Fields.Add("Km_3","Km_3");
			Fields.Add("Km_4","Km_4");
			Fields.Add("Km_1","Km_1");
			Fields.Add("Fahrzeug_1","Fahrzeug_1");
			Fields.Add("Fahrzeug_2","Fahrzeug_2");
			Fields.Add("VIN","VIN");
			Fields.Add("NrSilnika","NrSilnika");
			Fields.Add("DataPoprzedniegoOdczytu","DataPoprzedniegoOdczytu");
			Fields.Add("PoprzedniStanLicznika","PoprzedniStanLicznika");
			Fields.Add("DataOdczytu","DataOdczytu");
			Fields.Add("StanLicznikaObecny","StanLicznikaObecny");

        }
    }
}
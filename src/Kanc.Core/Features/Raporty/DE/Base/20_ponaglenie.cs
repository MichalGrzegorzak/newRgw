using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kanc.Core.Entities;

namespace Kanc.Core.Features.Raporty.DE
{
    public class BasePonaglenie : BaseRpt
    {
		public string Data
		{
			get { return Fields["Data"]; }
			set { Fields["Data"] = value; }
		}
		public string PanPani
		{
			get { return Fields["PanPani"]; }
			set { Fields["PanPani"] = value; }
		}
		public string Adres1
		{
			get { return Fields["Adres1"]; }
			set { Fields["Adres1"] = value; }
		}
		public string Adres2
		{
			get { return Fields["Adres2"]; }
			set { Fields["Adres2"] = value; }
		}
		public string NrKlienta
		{
			get { return Fields["NrKlienta"]; }
			set { Fields["NrKlienta"] = value; }
		}
		public string DataZlozenia
		{
			get { return Fields["DataZlozenia"]; }
			set { Fields["DataZlozenia"] = value; }
		}
		public string Year
		{
			get { return Fields["Year"]; }
			set { Fields["Year"] = value; }
		}
		public string Czynnosci
		{
			get { return Fields["Czynnosci"]; }
			set { Fields["Czynnosci"] = value; }
		}
		public string ID
		{
			get { return Fields["ID"]; }
			set { Fields["ID"] = value; }
		}
		public string NieczynneOd
		{
			get { return Fields["NieczynneOd"]; }
			set { Fields["NieczynneOd"] = value; }
		}
		public string NieczynneDo
		{
			get { return Fields["NieczynneDo"]; }
			set { Fields["NieczynneDo"] = value; }
		}

		public override void AddPropertiesToFields() 
		{
			Fields.Add("Data","Data");
			Fields.Add("PanPani","PanPani");
			Fields.Add("Adres1","Adres1");
			Fields.Add("Adres2","Adres2");
			Fields.Add("NrKlienta","NrKlienta");
			Fields.Add("DataZlozenia","DataZlozenia");
			Fields.Add("Year","Year");
			Fields.Add("Czynnosci","Czynnosci");
			Fields.Add("ID","ID");
			Fields.Add("NieczynneOd","NieczynneOd");
			Fields.Add("NieczynneDo","NieczynneDo");

        }
    }
}
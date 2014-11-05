using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kanc.Core.Entities;

namespace Kanc.Core.Features.Raporty.DE
{
    public class BaseRptpnvollmacht : BaseRpt
    {
		public string ImieINazwisko
		{
			get { return Fields["ImieINazwisko"]; }
			set { Fields["ImieINazwisko"] = value; }
		}
		public string Adres
		{
			get { return Fields["Adres"]; }
			set { Fields["Adres"] = value; }
		}
		public string Data
		{
			get { return Fields["Data"]; }
			set { Fields["Data"] = value; }
		}
		public string Mandaten
		{
			get { return Fields["Mandaten"]; }
			set { Fields["Mandaten"] = value; }
		}

		public override void AddPropertiesToFields() 
		{
			Fields.Add("ImieINazwisko","ImieINazwisko");
			Fields.Add("Adres","Adres");
			Fields.Add("Data","Data");
			Fields.Add("Mandaten","Mandaten");

        }
    }
}
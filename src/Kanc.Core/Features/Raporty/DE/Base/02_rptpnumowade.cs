using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kanc.Core.Entities;

namespace Kanc.Core.Features.Raporty.DE
{
    public class BaseRptpnumowade : BaseRpt
    {
		public string Data
		{
			get { return Fields["Data"]; }
			set { Fields["Data"] = value; }
		}
		public string ImieNazwisko
		{
			get { return Fields["ImieNazwisko"]; }
			set { Fields["ImieNazwisko"] = value; }
		}

		public override void AddPropertiesToFields() 
		{
			Fields.Add("Data","Data");
			Fields.Add("ImieNazwisko","ImieNazwisko");

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kanc.Core.Entities;

namespace Kanc.Core.Features.Raporty.DE
{
    public class BaseRptpnbwstatubg : BaseRpt
    {
		public string PanPani
		{
			get { return Fields["PanPani"]; }
			set { Fields["PanPani"] = value; }
		}
		public string PanPani2
		{
			get { return Fields["PanPani2"]; }
			set { Fields["PanPani2"] = value; }
		}
		public string Data
		{
			get { return Fields["Data"]; }
			set { Fields["Data"] = value; }
		}

		public override void AddPropertiesToFields() 
		{
			Fields.Add("PanPani","PanPani");
			Fields.Add("PanPani2","PanPani2");
			Fields.Add("Data","Data");

        }
    }
}
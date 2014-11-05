using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kanc.Core.Entities;

namespace Kanc.Core.Features.Raporty.DE
{
    public class BaseBrakkarty : BaseRpt
    {
		public string Name
		{
			get { return Fields["Name"]; }
			set { Fields["Name"] = value; }
		}
		public string Vorname
		{
			get { return Fields["Vorname"]; }
			set { Fields["Vorname"] = value; }
		}
		public string PZL
		{
			get { return Fields["PZL"]; }
			set { Fields["PZL"] = value; }
		}
		public string Stadt
		{
			get { return Fields["Stadt"]; }
			set { Fields["Stadt"] = value; }
		}
		public string Ort
		{
			get { return Fields["Ort"]; }
			set { Fields["Ort"] = value; }
		}
		public string Strasse
		{
			get { return Fields["Strasse"]; }
			set { Fields["Strasse"] = value; }
		}
		public string Year
		{
			get { return Fields["Year"]; }
			set { Fields["Year"] = value; }
		}

		public override void AddPropertiesToFields() 
		{
			Fields.Add("Name","Name");
			Fields.Add("Vorname","Vorname");
			Fields.Add("PZL","PZL");
			Fields.Add("Stadt","Stadt");
			Fields.Add("Ort","Ort");
			Fields.Add("Strasse","Strasse");
			Fields.Add("Year","Year");

        }
    }
}
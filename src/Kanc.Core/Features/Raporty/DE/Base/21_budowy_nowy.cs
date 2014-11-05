using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kanc.Core.Entities;

namespace Kanc.Core.Features.Raporty.DE
{
    public class BaseBudowy_nowy : BaseRpt
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
		public string Year
		{
			get { return Fields["Year"]; }
			set { Fields["Year"] = value; }
		}
		public string Mandaten
		{
			get { return Fields["Mandaten"]; }
			set { Fields["Mandaten"] = value; }
		}
		public string Baustelle1
		{
			get { return Fields["Baustelle1"]; }
			set { Fields["Baustelle1"] = value; }
		}
		public string Baustelle2
		{
			get { return Fields["Baustelle2"]; }
			set { Fields["Baustelle2"] = value; }
		}
		public string Baustelle3
		{
			get { return Fields["Baustelle3"]; }
			set { Fields["Baustelle3"] = value; }
		}
		public string Baustelle4
		{
			get { return Fields["Baustelle4"]; }
			set { Fields["Baustelle4"] = value; }
		}
		public string OdDo1
		{
			get { return Fields["OdDo1"]; }
			set { Fields["OdDo1"] = value; }
		}
		public string OdDo2
		{
			get { return Fields["OdDo2"]; }
			set { Fields["OdDo2"] = value; }
		}
		public string OdDo3
		{
			get { return Fields["OdDo3"]; }
			set { Fields["OdDo3"] = value; }
		}
		public string OdDo4
		{
			get { return Fields["OdDo4"]; }
			set { Fields["OdDo4"] = value; }
		}

		public override void AddPropertiesToFields() 
		{
			Fields.Add("Name","Name");
			Fields.Add("Vorname","Vorname");
			Fields.Add("Year","Year");
			Fields.Add("Mandaten","Mandaten");
			Fields.Add("Baustelle1","Baustelle1");
			Fields.Add("Baustelle2","Baustelle2");
			Fields.Add("Baustelle3","Baustelle3");
			Fields.Add("Baustelle4","Baustelle4");
			Fields.Add("OdDo1","OdDo1");
			Fields.Add("OdDo2","OdDo2");
			Fields.Add("OdDo3","OdDo3");
			Fields.Add("OdDo4","OdDo4");

        }
    }
}
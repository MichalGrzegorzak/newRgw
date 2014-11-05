using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kanc.Core.Entities;

namespace Kanc.Core.Features.Raporty.DE
{
    public class BaseRptdrukkontobankowe : BaseRpt
    {
		public string Mandanten
		{
			get { return Fields["Mandanten"]; }
			set { Fields["Mandanten"] = value; }
		}
		public string PustePole
		{
			get { return Fields["PustePole"]; }
			set { Fields["PustePole"] = value; }
		}
		public string SwiftCode
		{
			get { return Fields["SwiftCode"]; }
			set { Fields["SwiftCode"] = value; }
		}
		public string NazwiskoImie
		{
			get { return Fields["NazwiskoImie"]; }
			set { Fields["NazwiskoImie"] = value; }
		}
		public string Adres
		{
			get { return Fields["Adres"]; }
			set { Fields["Adres"] = value; }
		}
		public string NazwaBanku
		{
			get { return Fields["NazwaBanku"]; }
			set { Fields["NazwaBanku"] = value; }
		}
		public string Data
		{
			get { return Fields["Data"]; }
			set { Fields["Data"] = value; }
		}
		public string NumerBanku_BLZ
		{
			get { return Fields["NumerBanku_BLZ"]; }
			set { Fields["NumerBanku_BLZ"] = value; }
		}
		public string NumerKonta
		{
			get { return Fields["NumerKonta"]; }
			set { Fields["NumerKonta"] = value; }
		}
		public string IBAN
		{
			get { return Fields["IBAN"]; }
			set { Fields["IBAN"] = value; }
		}

		public override void AddPropertiesToFields() 
		{
			Fields.Add("Mandanten","Mandanten");
			Fields.Add("PustePole","PustePole");
			Fields.Add("SwiftCode","SwiftCode");
			Fields.Add("NazwiskoImie","NazwiskoImie");
			Fields.Add("Adres","Adres");
			Fields.Add("NazwaBanku","NazwaBanku");
			Fields.Add("Data","Data");
			Fields.Add("NumerBanku_BLZ","NumerBanku_BLZ");
			Fields.Add("NumerKonta","NumerKonta");
			Fields.Add("IBAN","IBAN");

        }
    }
}
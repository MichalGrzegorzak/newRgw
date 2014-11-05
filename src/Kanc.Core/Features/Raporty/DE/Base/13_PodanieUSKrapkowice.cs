using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kanc.Core.Entities;

namespace Kanc.Core.Features.Raporty.DE
{
    public class BasePodanieUSKrapkowice : BaseRpt
    {
		public string Dnia
		{
			get { return Fields["dnia"]; }
			set { Fields["dnia"] = value; }
		}
		public string NazwaUrzedu
		{
			get { return Fields["nazwaUrzedu"]; }
			set { Fields["nazwaUrzedu"] = value; }
		}
		public string NIP
		{
			get { return Fields["NIP"]; }
			set { Fields["NIP"] = value; }
		}
		public string NIPPartner
		{
			get { return Fields["NIPPartner"]; }
			set { Fields["NIPPartner"] = value; }
		}
		public string InnyPowod1
		{
			get { return Fields["innyPowod1"]; }
			set { Fields["innyPowod1"] = value; }
		}
		public string InnyPowod2
		{
			get { return Fields["innyPowod2"]; }
			set { Fields["innyPowod2"] = value; }
		}
		public string ZaOkres
		{
			get { return Fields["zaOkres"]; }
			set { Fields["zaOkres"] = value; }
		}
		public string ImieINazwisko
		{
			get { return Fields["imieINazwisko"]; }
			set { Fields["imieINazwisko"] = value; }
		}
		public string ImieINazwiskoPartner
		{
			get { return Fields["imieINazwiskoPartner"]; }
			set { Fields["imieINazwiskoPartner"] = value; }
		}
		public string AdresLinia1
		{
			get { return Fields["adresLinia1"]; }
			set { Fields["adresLinia1"] = value; }
		}
		public string AdresLinia1Partner
		{
			get { return Fields["adresLinia1Partner"]; }
			set { Fields["adresLinia1Partner"] = value; }
		}
		public string AdresLinia2
		{
			get { return Fields["adresLinia2"]; }
			set { Fields["adresLinia2"] = value; }
		}
		public string AdresLinia2Partner
		{
			get { return Fields["adresLinia2Partner"]; }
			set { Fields["adresLinia2Partner"] = value; }
		}

		public override void AddPropertiesToFields() 
		{
			Fields.Add("dnia","dnia");
			Fields.Add("nazwaUrzedu","nazwaUrzedu");
			Fields.Add("NIP","NIP");
			Fields.Add("NIPPartner","NIPPartner");
			Fields.Add("innyPowod1","innyPowod1");
			Fields.Add("innyPowod2","innyPowod2");
			Fields.Add("zaOkres","zaOkres");
			Fields.Add("imieINazwisko","imieINazwisko");
			Fields.Add("imieINazwiskoPartner","imieINazwiskoPartner");
			Fields.Add("adresLinia1","adresLinia1");
			Fields.Add("adresLinia1Partner","adresLinia1Partner");
			Fields.Add("adresLinia2","adresLinia2");
			Fields.Add("adresLinia2Partner","adresLinia2Partner");

        }
    }
}
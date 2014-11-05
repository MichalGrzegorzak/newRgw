using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kanc.Core.Entities;

namespace Kanc.Core.Features.Raporty.DE
{
    public class BaseEuewr_pl : BaseRpt
    {
		public string Nazwisko
		{
			get { return Fields["nazwisko"]; }
			set { Fields["nazwisko"] = value; }
		}
		public string Imie
		{
			get { return Fields["imie"]; }
			set { Fields["imie"] = value; }
		}
		public string Obywatelstwo
		{
			get { return Fields["obywatelstwo"]; }
			set { Fields["obywatelstwo"] = value; }
		}
		public string Dataur
		{
			get { return Fields["dataur"]; }
			set { Fields["dataur"] = value; }
		}
		public string Krajzam
		{
			get { return Fields["krajzam"]; }
			set { Fields["krajzam"] = value; }
		}
		public string Kodpocztowy
		{
			get { return Fields["kodpocztowy"]; }
			set { Fields["kodpocztowy"] = value; }
		}
		public string Miejscezam
		{
			get { return Fields["miejscezam"]; }
			set { Fields["miejscezam"] = value; }
		}
		public string Ulica
		{
			get { return Fields["ulica"]; }
			set { Fields["ulica"] = value; }
		}
		public string NazwiskoPartner
		{
			get { return Fields["nazwiskoPartner"]; }
			set { Fields["nazwiskoPartner"] = value; }
		}
		public string ImiePartner
		{
			get { return Fields["imiePartner"]; }
			set { Fields["imiePartner"] = value; }
		}
		public string DataurPartner
		{
			get { return Fields["dataurPartner"]; }
			set { Fields["dataurPartner"] = value; }
		}
		public string ObywatelstwoPartner
		{
			get { return Fields["obywatelstwoPartner"]; }
			set { Fields["obywatelstwoPartner"] = value; }
		}
		public string KrajzamPartner
		{
			get { return Fields["krajzamPartner"]; }
			set { Fields["krajzamPartner"] = value; }
		}
		public string KodpocztowyPartner
		{
			get { return Fields["kodpocztowyPartner"]; }
			set { Fields["kodpocztowyPartner"] = value; }
		}
		public string MiejscezamPartner
		{
			get { return Fields["miejscezamPartner"]; }
			set { Fields["miejscezamPartner"] = value; }
		}
		public string UlicaPartner
		{
			get { return Fields["ulicaPartner"]; }
			set { Fields["ulicaPartner"] = value; }
		}
		public string DataZonatyOd
		{
			get { return Fields["dataZonatyOd"]; }
			set { Fields["dataZonatyOd"] = value; }
		}
		public string DataWdowiecOd
		{
			get { return Fields["dataWdowiecOd"]; }
			set { Fields["dataWdowiecOd"] = value; }
		}
		public string Rok
		{
			get { return Fields["rok"]; }
			set { Fields["rok"] = value; }
		}

		public override void AddPropertiesToFields() 
		{
			Fields.Add("nazwisko","nazwisko");
			Fields.Add("imie","imie");
			Fields.Add("obywatelstwo","obywatelstwo");
			Fields.Add("dataur","dataur");
			Fields.Add("krajzam","krajzam");
			Fields.Add("kodpocztowy","kodpocztowy");
			Fields.Add("miejscezam","miejscezam");
			Fields.Add("ulica","ulica");
			Fields.Add("nazwiskoPartner","nazwiskoPartner");
			Fields.Add("imiePartner","imiePartner");
			Fields.Add("dataurPartner","dataurPartner");
			Fields.Add("obywatelstwoPartner","obywatelstwoPartner");
			Fields.Add("krajzamPartner","krajzamPartner");
			Fields.Add("kodpocztowyPartner","kodpocztowyPartner");
			Fields.Add("miejscezamPartner","miejscezamPartner");
			Fields.Add("ulicaPartner","ulicaPartner");
			Fields.Add("dataZonatyOd","dataZonatyOd");
			Fields.Add("dataWdowiecOd","dataWdowiecOd");
			Fields.Add("rok","rok");

        }
    }
}
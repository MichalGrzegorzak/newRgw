using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using ElvTools.Ext;
using SculptureDA;

namespace MigrationTool.Entities
{
    public class Klient : EntityBase
    {
        public override int Id { get; set; }
        public DateTime Urodz { get; set; }
        
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string ImieDe { get; set; }
        public string NazwiskoDe { get; set; }

        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Komorka { get; set; }
        
        public string Konto { get; set; }
        public string AdresBanku { get; set; }
        public int BankId { get; set; }
        public int AdresZameldId { get; set; }
        public int AdresKorespId { get; set; }
        public int PartnerId { get; set; }
        
        public DateTime? DataZawZwiazku { get; set; }
        public int Polecil { get; set; }
        public int Plec { get; set; }

        public Klient() : base()
        {
            Plec = 0;
            string empty = "<br>";
            Email = Komorka = Telefon = AdresBanku = Konto = empty;
            CreatedBy = empty;
            CreatedOn = (DateTime)SqlDateTime.MinValue;
        }

        public Klient(Niemieckie n) : this()
        {
            if (n.MandatenN.Contains("K"))
                Polecil = 1;
            if (n.RM.HasValue && n.RM.Value == true)
                Polecil = 2;
            //if (n.MandatenN.Contains("M")) PolecajId = 2;

            Urodz = n.Geb_kunde.Value;

            if (n.VornamePl.Last() == 'a')
                Plec = 1;

            Imie = n.VornamePl.ClearText();
            ImieDe = n.VornameD.ClearText();
            Nazwisko = n.NamePl.ClearText();
            NazwiskoDe = n.NameD.ClearText();
            DataZawZwiazku = n.Miete_d;

            if (n.OperatorX.IsNotNullOrEmpty()) CreatedBy = n.OperatorX;
            if (n.Datum.HasValue) CreatedOn = n.Datum.Value;

            //konto
            string lk = "";
            if (n.Lk.IsNotNullOrEmptyT()) lk = n.Lk.RegexOnlyDigits(); ;
            if (n.Konto.IsNotNullOrEmpty()) Konto = n.Konto.RegexOnlyDigits();
            if(lk.IsNotNullOrEmptyT())
            {
                Konto = lk + Konto;
            }

            if (n.KondGeldD.IsNotNullOrEmpty())
            {
                string s = n.KondGeldD.ClearText();
                if (s != "0") Email = s;
            } 
            
            if (n.Komorka.IsNotNullOrEmpty()) Komorka = n.Komorka.RegexOnlyDigits();     //.RemoveAllOf("-", "."," ", ",","/","\\");
            if (n.Telefon.IsNotNullOrEmpty()) Telefon = n.Telefon.RegexOnlyDigits();
            if (n.BankAdres.IsNotNullOrEmpty()) AdresBanku = n.BankAdres.ClearText();
        }
    }
}

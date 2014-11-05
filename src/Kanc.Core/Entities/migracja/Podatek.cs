using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using ElvTools.Ext;
using SculptureDA;

namespace MigrationTool.Entities
{
    public class Podatek : EntityBase
    {
        public Podatek() : base()
        {
            string empty = "<br>";
            Steuernummer = Religia = Auto = Notka = empty;
            Do1M = DoXM = DzieciDaty = empty;
        }

        public Podatek(Niemieckie n) : this()
        {
            //poszlo do Rachunek
            //if (n.Auto2.IsNotNullOrEmptyT()) Auto2 = n.Auto2;
            //Do2W = n.Do2w.Value;

            if (n.Steuernummer.IsNotNullOrEmptyT())
            {
                Steuernummer = n.Steuernummer.ClearText();
                Steuernummer.RemoveAllOf("/", "\\", " ","-");
            }
            if (n.Kirche.IsNotNullOrEmptyT()) Religia = n.Kirche.ClearText();
            
            if (n.Kinder.HasValue) DzieciLiczba = n.Kinder.Value.ToString().ParseSafe<int>();
            if (n.KmStand.IsNotNullOrEmptyT())
            {
                List<DateTime> dzieciDaty = ParseDaty(n.KmStand);
                dzieciDaty.RemoveAll(x => x == (DateTime)SqlDateTime.MinValue); //usun zle daty
                if (DzieciLiczba == 0)
                    DzieciLiczba = dzieciDaty.Count();
                
                DzieciDaty = dzieciDaty.ToLine(";");
            }

            if (n.Auto.IsNotNullOrEmptyT()) Auto = n.Auto.ClearText();
            if (n.Do1m.IsNotNullOrEmptyT()) Do1M = n.Do1m.ClearText();
            if (n.Teltekst.IsNotNullOrEmpty()) Notka = n.Teltekst.ClearText();
            Do3W = n.Do3w;

            //if (n.Miete_pl.IsNotNullOrEmptyT()) MietePl = n.Miete_pl;
            //if (n.Miete_d.HasValue) MieteData = n.Miete_d.Value;
            //if (n.Kilometer.HasValue) KmDom = n.Kilometer.Value.ToString().Parse<int>();
            //if (n.Arbeit_km.HasValue) KmPraca = n.Arbeit_km.Value.ToString().Parse<int>();
            //Mieszkanie = n.Wohnung.Value;
            //RodzinnePl = n.KinderGeldPl.Value;
        }

        public List<DateTime> ParseDaty(string datyDzieci)
        {
            datyDzieci = datyDzieci.Trim('.', ';');

            if (datyDzieci.IsExistAny('`', '\'', ':',','))
                datyDzieci = datyDzieci.ReplaceAllOf(';', '`', '\'', ':',',');

            List<DateTime> results = new List<DateTime>();
            foreach (string s in datyDzieci.Split(';'))
            {
                DateTime dt = s.ParseSafe<DateTime>();
                if (dt == DateTime.MinValue)
                    dt = (DateTime)SqlDateTime.MinValue;
                results.Add(dt);
            }
            return results;
        }

        public override int Id { get; set; }
        public string Steuernummer { get; set; }
        public string Religia { get; set; } //kirche
        public int DzieciLiczba { get; set; }
        public string DzieciDaty { get; set; } // KmStand
        
        public string Auto { get; set; } //nr rejestracyjny + syfy
        //public string MietePl { get; set; }  //slownik PL, DE
        

        //do2w i auto w KPRachunek
        public DateTime? Do1W { get; set; }
        public DateTime? Do3W { get; set; }

        public string Do1M { get; set; } //wyznanie ???
        public string DoXM { get; set; }
        public string Notka { get; set; }

        //nie przypisane
        //public int KmDom { get; set; } //Kilometer
        //public int KmPraca { get; set; } //ArbeitKm
        //public bool Mieszkanie { get; set; } //wohnung
        //public int RodzinnePl { get; set; } //kinder geld
        //public int RodzinneD { get; set; }
        //public int MieszkaPl { get; set; }
        //public int CzynszZaD { get; set; }
        //public int CzynszZazPl { get; set; }
        //public int CzynszD { get; set; }
        //public int CzybszPl { get; set; }
        //public int Zameldowanie { get; set; }
        
        //public int RodzPotwD { get; set; }
        //public int DojazdAuto { get; set; }
        //public int DojazdFirm { get; set; }
        //public int DojazdBus { get; set; }
        //public int DojazdReszta { get; set; }
        //public string NrRejest1 { get; set; }
        //public string NrRejest2 { get; set; }
        //public DateTime? DoAuto { get; set; } 

        
        //public string LiczbaKart { get; set; }
        //public string KlasaPodatkowa { get; set; }

        //public int TwardaKarta { get; set; }
        //public int PartnerMieszkanie { get; set; }
        //public int PartnerMieszkanie2 { get; set; }
        //public int PartnerPraca { get; set; }
        //public int PartnerPracaD { get; set; }
        //public int PartnerPraca333 { get; set; }
        //public int Paragon { get; set; }

        //wyznannie
        //dzieci
        //itp...
    }
}

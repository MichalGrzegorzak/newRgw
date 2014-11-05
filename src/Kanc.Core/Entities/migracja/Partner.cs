using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ElvTools.Ext;
using SculptureDA;

namespace MigrationTool.Entities
{
    public class Partner : EntityBase
    {
        public override int Id { get; set; }
        public string MandId { get; set; } //Zug
        public string Imie { get; set; } //frau_pl
        public string Nazwisko { get; set; }
        public int Plec { get; set; }
        public string Religia { get; set; } //do1m
        public DateTime? Urodz { get; set; } //frau_geb

        public Partner() : base()
        {
            Plec = 0;
            string empty = "<br>";
            Imie = Nazwisko = Religia = MandId = empty;
        }

        public Partner(Niemieckie n) : this()
        {
            if (!n.Frau_pl.IsNotNullOrEmptyT())
                return;

            Imie = n.Frau_pl.ClearText();
            Nazwisko = n.NamePl.ClearText();
            Urodz = n.Frau_geb;

            if(Imie.IsNotNullOrEmptyT())
                if (Imie.Last() == 'a') Plec = 1;

            if (n.Zug.IsNotNullOrEmptyT()) MandId = n.Zug.ClearText();
            if (n.Do1m.IsNotNullOrEmptyT()) Religia = n.Do1m.ClearText();

            if (MandId == "0")
                MandId = "<br>";
        }
    }
}
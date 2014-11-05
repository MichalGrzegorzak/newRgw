using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ElvTools.Ext;
using SculptureDA;

namespace MigrationTool.Entities
{
    public class Adres : EntityBase
    {
        public override int Id { get; set; }
        public string Miasto { get; set; }
        public string Ulica { get; set; }
        public string Kod { get; set; }
        public string Miejsce { get; set; }
        public int CountryId { get; set; }

        public Adres() : base() 
        {
            string empty = "<br>";
            Ulica = Miasto = Kod = Miejsce = empty;
            CountryId = 1; //<br> - nie da sie tego wykryc
        }

        public Adres(Niemieckie niem) : this()
        {
            if (niem.StadtPl.IsNotNullOrEmpty())
                Miasto = niem.StadtPl.RegexOnlyLetters();
            if (niem.OrtPl.IsNotNullOrEmpty())
                Miejsce = niem.OrtPl.RegexOnlyLetters();
            if (niem.Adrespl.IsNotNullOrEmpty())
                Ulica = niem.Adrespl.ClearText();
            if (niem.Kodp.IsNotNullOrEmpty())
                Kod = niem.Kodp.ClearText();
        }
    }
}

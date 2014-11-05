using System;
using System.Linq;
using System.Data.Linq;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Kanc.Commons;

namespace Kanc.Core.Entities
{
    [Serializable]
    public class Adres : BaseEntity
    {
        public Adres() { }
        //public Adres(Rozliczenie roz) { this.Rozliczenie = roz; }

        public virtual string Miasto { get; set; }
        public virtual string Ulica { get; set; }
        public virtual string Kod { get; set; }
        public virtual string Miejsce { get; set; }
        public virtual Kraje Kraj { get; set; }

        public string PelnyAdres()
        {
            string result = Ulica + ", " + Kod + " " + Miasto;
            return result;
        }

        public string Linia1()
        {
            return Ulica;
        }

        public string Linia2()
        {
            return Kod + " " + Miasto;
        }

        public string KodIMiasto()
        {
            return Kod + " " + Miasto;
        }

        public override object Clone()
        {
            var result = (Adres)MemberwiseClone();
            result.Id = 0;
            return result;
        }

    }
}
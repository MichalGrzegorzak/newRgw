using System;
using System.Linq;
using System.Data.Linq;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Kanc.Commons;

namespace Kanc.Core.Entities
{
    public interface IOsoba
    {
        string MandId { get; set; }
        string Imie { get; set; }
        string ImieDe { get; set; }
        string Nazwisko { get; set; }
        string NazwiskoDe { get; set; }
        Plec Plec { get; set; }
        int Religia { get; set; }
        DateTime? Urodz { get; set; }
        string Zawod { get; set; }

        //zamieszkanie kraj
        //string obywatelstwo
    }

    [Serializable]
    public class Partner : OneToOneEntity, IOsoba
    { 
        public Partner()
        {
            Plec = Plec.Kobieta;
        }
        public Partner(Rozliczenie roz) : this()
        {
            this.Rozliczenie = roz;
        }

        public virtual string MandId { get; set; }
        public virtual string Imie { get; set; } //frau_pl
        public virtual string ImieDe { get; set; }
        public virtual string Nazwisko { get; set; }
        public virtual string NazwiskoDe { get; set; }
        public virtual Plec Plec { get; set; }
        public virtual int Religia { get; set; } //do1m
        public virtual DateTime? Urodz { get; set; }  //frau_geb
        public virtual string Zawod { get; set; }

        public bool IsPresent
        {
            get { return (Imie.IsNotNullOrEmptyT()); }
        }
        public string ImieINazwisko
        {
            get { return Imie + " " + Nazwisko; }
        }
        public string ImieINazwiskoDe
        {
            get { return ImieDe + " " + NazwiskoDe; }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Kanc.Commons;
using NHibernate.Validator.Constraints;

namespace Kanc.Core.Entities
{
    [Serializable]
    public class Klient : OneToOneEntity, IOsoba
    {
        public Klient()
        {
            Polecil = Polecony.brak;
            Plec = Plec.Mężczyzna;
            AdresZameld = new Adres();
        }
        public Klient(Rozliczenie roz) : this()
        {
            Rozliczenie = roz;
        }
        //public Klient()
            //rozenia = new BindingList<rozenie> { AllowNew = true };
            //Bank = new Bank();
            //AdresZameld = new Adres();
            //AdresKoresp = new Adres();
            //Partner = new Partner();

        
        //public virtual IList<rozenie> rozenia { get; set; }
        public virtual string MandId { get; set; }
        public virtual string Steuernummer { get; set; }

        public virtual string Imie { get; set; }
        public virtual string ImieDe { get; set; }
        public virtual string Nazwisko { get; set; }
        public virtual string NazwiskoDe { get; set; }
        public virtual DateTime? Urodz { get; set; }
        public virtual string Telefon { get; set; }
        public virtual string Komorka { get; set; }
        public virtual string Email { get; set; }
        public virtual int Religia { get; set; } //kirche
        public virtual Plec Plec { get; set; }

        public virtual DateTime? DataSlubu { get; set; }
        public virtual int DzieciLiczba { get; set; }
        public virtual string DzieciDaty { get; set; } // KmStand
        public virtual Polecony Polecil { get; set; }
        public virtual string Notka { get; set; }

        public virtual string Zawod { get; set; }

        public virtual Adres AdresZameld { get; set; }

        //public override object Clone()
        //{
        //    var k = (Klient)MemberwiseClone();
        //    k.Id = 0;
        //    //if (Bank != null) k.Bank = (Bank)Bank.Clone();
        //    //if (AdresKoresp != null) k.AdresKoresp = (Adres)AdresKoresp.Clone();
        //    //if (AdresZameld != null) k.AdresZameld = (Adres)AdresZameld.Clone();
        //    //if (Partner != null) k.Partner = (Partner)Partner.Clone();
        //    //foreach (var roz in rozenia)
        //    //{
        //    //    k.rozenia.Add((rozenie)roz.Clone());
        //    //}

        //    return k;
        //}

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
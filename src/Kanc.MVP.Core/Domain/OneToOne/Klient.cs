using System;
using Kanc.MVP.Core.nHibernate.Base;

namespace Kanc.MVP.Core.Domain
{
    [Serializable]
    public class Klient : Osoba, IAutoMap
    {
        public Klient() {}
        public Klient(Rozliczenie rozlicz)
        {
            Rozliczenie = rozlicz;
            AdresZameld = new Adres() {IsNew = true};
            IsNew = true;
        }
        public virtual void AssignFrom(Osoba o)
        {
            MandId = o.MandId;
            Steuernummer = o.Steuernummer;
            Urodz = o.Urodz;
            Imie = o.Imie;
            Nazwisko = o.Nazwisko;
            ImieDe = o.ImieDe;
            NazwiskoDe = o.NazwiskoDe;
            Plec = o.Plec;
            Religia = o.Religia;
            Zawod = o.Zawod;
        }

        public virtual Rozliczenie Rozliczenie { get; protected set; }
        public virtual Adres AdresZameld { get; protected set; }
        
        public virtual string Telefon { get; set; }
        public virtual string Komorka { get; set; }
        public virtual string Email { get; set; }

        public virtual DateTime? DataSlubu { get; set; }
        public virtual int Polecil { get; set; }
        public virtual string Notka { get; set; }

        public virtual int DzieciLiczba { get; set; }
        public virtual string DzieciDaty { get; set; } // KmStand

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

        public virtual string ImieINazwisko
        {
            get { return Imie + " " + Nazwisko; }
        }
        public virtual string ImieINazwiskoDe
        {
            get { return ImieDe + " " + NazwiskoDe; }
        }

    }
}
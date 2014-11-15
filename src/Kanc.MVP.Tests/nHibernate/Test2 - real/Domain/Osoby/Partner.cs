using System;

namespace Kanc.MVP.Tests.nHibernate.Domain.Rozliczenie
{
    [Serializable]
    public class Partner : Osoba, IAutoMap
    {
        public virtual Rozliczenie Rozliczenie { get; set; }

        public Partner() { }
        public Partner(Rozliczenie rozlicz)
        {
            Rozliczenie = rozlicz;
        }
        public Partner(Osoba o)
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
    }
}
using System;
using Kanc.MVP.Core.nHibernate.Base;

namespace Kanc.MVP.Core.Domain
{
    [Serializable]
    public class Partner : Osoba, IAutoMap
    {
        public virtual Rozliczenie Rozliczenie { get; protected set; }

        public Partner() { }
        public Partner(Rozliczenie rozlicz)
        {
            Rozliczenie = rozlicz;
            IsNew = true;
        }
        protected internal virtual void AssignFrom(Osoba o)
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
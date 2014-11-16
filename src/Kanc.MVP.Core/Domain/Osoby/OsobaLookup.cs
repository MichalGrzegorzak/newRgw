using System;
using System.Collections.Generic;
using Kanc.MVP.Core.nHibernate.Base;

namespace Kanc.MVP.Core.Domain
{
    /// <summary>
    /// Unikalne, i zawsze aktualne dane klienta
    /// </summary>
    [Serializable]
    public class OsobaLookup : ModelBase, IAutoMap
    {
        public static readonly List<OsobaLookup> AllCustomers = new List<OsobaLookup>();

        public OsobaLookup()
        {
            Rozliczenies = new List<Rozliczenie>();
        }
        public OsobaLookup(Osoba o)
        {
            MandId = o.MandId;
            Steuernummer = o.Steuernummer;
            Urodz = o.Urodz;
            Imie = o.Imie;
            Nazwisko = o.Nazwisko;
            ImieDe = o.ImieDe;
            NazwiskoDe = o.NazwiskoDe;
        }

        public virtual string MandId { get; set; }
        public virtual string Steuernummer { get; set; }

        public virtual string Imie { get; set; }
        public virtual string Nazwisko { get; set; }
        public virtual string ImieDe { get; set; }
        public virtual string NazwiskoDe { get; set; }

        public virtual DateTime? Urodz { get; set; }

        public virtual IList<Rozliczenie> Rozliczenies { get; protected set; }
    }
}
using System;
using Kanc.MVP.Core.nHibernate.Base;

namespace Kanc.MVP.Core.Domain.Osoby
{
    [Serializable]
    public class Osoba : ModelBase 
    {
        public virtual string MandId { get; set; }
        public virtual string Steuernummer { get; set; }
        public virtual DateTime? Urodz { get; set; }

        public virtual string Imie { get; set; }
        public virtual string Nazwisko { get; set; }
        public virtual string ImieDe { get; set; }
        public virtual string NazwiskoDe { get; set; }

        public virtual bool Plec { get; set; }
        public virtual int Religia { get; set; }
        public virtual string Zawod { get; set; }
    }
}
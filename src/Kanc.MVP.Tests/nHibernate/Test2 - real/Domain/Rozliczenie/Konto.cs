using System;
using Kanc.MVP.Tests.nHibernate.Domain.Enums;

namespace Kanc.MVP.Tests.nHibernate.Domain.Rozliczenie
{
    [Serializable]
    public class Konto : ModelBase, IAutoMap
    {
        public Konto()
        {
        }
        public Konto(Rozliczenie rozlicz)
        {
            Rozliczenie = rozlicz;
        }

        public virtual Rozliczenie Rozliczenie { get; set; }

        public virtual string KontoLk { get; set; }
        public virtual string KontoNr { get; set; }
        public virtual string KontoWlasciciel { get; set; }
        public virtual KontoWlasciciel KontoTypWlasciciela { get; set; }

        public virtual string BankNazwa { get; set; }
        public virtual string BankBLZ { get; set; }
        public virtual string BankSwift { get; set; }
        public virtual string BankAdres { get; set; }
        public virtual Kraje BankKraj { get; set; }

    }
}
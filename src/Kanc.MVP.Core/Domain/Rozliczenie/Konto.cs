using System;
using Kanc.MVP.Core.Domain.Enums;
using Kanc.MVP.Core.nHibernate.Base;

namespace Kanc.MVP.Core.Domain.Rozliczenie
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
            KontoTypWlasciciela = Enums.KontoWlasciciel.brak;
            BankKraj = Kraje.brak;
        }

        public virtual void AssignFrom(Bank b)
        {
            BankKraj = b.Kraj;
            BankNazwa = b.Nazwa;
            BankSwift = b.Swift;
            BankAdres = b.Adres;
            BankBLZ = b.Blz;
        }

        public virtual Rozliczenie Rozliczenie { get; protected set; }

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
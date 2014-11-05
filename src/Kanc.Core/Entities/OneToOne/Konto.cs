using System;
using System.Linq;
using System.Data.Linq;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Kanc.Commons;
using NHibernate.Validator.Constraints;

namespace Kanc.Core.Entities
{
    [Serializable]
    public class Konto : OneToOneEntity
    {
        public Konto() { }
        public Konto(Rozliczenie roz) { this.Rozliczenie = roz; }

        public virtual string KontoLk { get; set; }
        public virtual string KontoNr { get; set; }
        public virtual string KontoWlasciciel { get; set; }
        public virtual KontoWlasciciel  KontoTypWlasciciela { get; set; }

        public virtual string BankNazwa { get; set; }
        public virtual string BankBLZ { get; set; }
        public virtual string BankSwift { get; set; }
        public virtual string BankAdres { get; set; }
        public virtual Kraje BankKraj { get; set; }

    }
}
using System;
using System.Linq;
using System.Data.Linq;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using NHibernate.Validator.Constraints;

namespace Kanc.Core.Entities
{
    [Serializable]
    public class Podatek : OneToOneEntity
    {
        public Podatek() { }
        public Podatek(Rozliczenie roz) : this()
        { this.Rozliczenie = roz; }

        //nr rejestracyjny + syfy
        public virtual string Auto { get; set; }
        //do2w i auto w KPRachunek
        public virtual DateTime? Do1W { get; set; }
        public virtual DateTime? Do3W { get; set; }
        //wyznanie ???
        public virtual string Do1M { get; set; }
        public virtual string DoXM { get; set; }

        //private string _MietePl;  //slownik PL, DE
        
    }
}
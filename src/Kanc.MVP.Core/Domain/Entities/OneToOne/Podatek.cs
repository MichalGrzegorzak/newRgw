using System;
using Kanc.MVP.Core.Domain.Entities.Base;

namespace Kanc.MVP.Core.Domain.Entities.OneToOne
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
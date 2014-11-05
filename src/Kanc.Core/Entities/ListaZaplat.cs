using System;
using System.Linq;
using System.Data.Linq;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Kanc.Commons;

namespace Kanc.Core.Entities
{
    [Serializable]
    public class ListaZaplat : EntityAdv
    {
        public ListaZaplat() { }
        //CreatedOn == Opened

        public virtual TypListyZaplat Typ { get; set; }
        public virtual bool IsClosed { get; set; }
        //Farhbuch z Niemieckie
        public virtual string KodListyZapl { get; set; }

        public virtual DateTime? OpenedOn { get; set; }
        public virtual DateTime? ClosedOn { get; set; }

        public override object Clone()
        {
            var result = (ListaZaplat)MemberwiseClone();
            result.Id = 0;
            return result;
        }
    }
}
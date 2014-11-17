using System;
using Kanc.MVP.Core.nHibernate.Base;

namespace Kanc.MVP.Core.Domain
{
    [Serializable]
    public class Bank : EntityBase, IAutoMap
    {
        public Bank() { }

        public virtual string Blz { get; set; }
        public virtual string Nazwa { get; set; }
        public virtual string Adres { get; set; }
        public virtual string Swift { get; set; }
        public virtual Kraje Kraj { get; set; }

        //public override object Clone()
        //{
        //    var result = (Bank)MemberwiseClone();
        //    result.Id = 0;
        //    return result;
        //}

    }
}
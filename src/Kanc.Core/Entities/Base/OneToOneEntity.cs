using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kanc.Core.Entities
{
    [Serializable]
    public abstract class OneToOneEntity : BaseEntity
    {
        public virtual Rozliczenie Rozliczenie { get; set; }

        //public override object Clone()
        //{
        //    var result = (Podatek)MemberwiseClone();
        //    result.Id = 0;
        //    return result;
        //}
    }
}

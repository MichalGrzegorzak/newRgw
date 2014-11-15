using System;
using Kanc.MVP.Core.Domain.Entities.OneToOne;

namespace Kanc.MVP.Core.Domain.Entities.Base
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

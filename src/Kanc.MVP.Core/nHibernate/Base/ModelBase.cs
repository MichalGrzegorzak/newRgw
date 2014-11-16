using System;

namespace Kanc.MVP.Core.nHibernate.Base
{
    [Serializable]
    public abstract class ModelBase
    {
        public virtual int Id { get; protected set; }

        public virtual bool IsNew { get; set; }
    }
}
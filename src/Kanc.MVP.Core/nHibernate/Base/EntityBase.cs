using System;

namespace Kanc.MVP.Core.nHibernate.Base
{
    [Serializable]
    public abstract class EntityBase
    {
        public virtual int Id { get; protected set; }

        public virtual bool IsTransient()
        {
            return this.Id == default(int);
        }
    }
}
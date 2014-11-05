using System;
using System.ComponentModel;
using System.Linq;
using System.Data.Linq;
using System.Collections.Generic;
using System.Text;
using NHibernate.Validator.Constraints;
using NHibernate.Validator.Engine;

namespace Kanc.Core.Entities
{
	[Serializable]
	public abstract class BaseEntity : AbstractEntity<int>, IEntity
	{
		public virtual event PropertyChangedEventHandler PropertyChanged;

		//public override int Id { get; protected set; }
        public override int Id { get; set; }

		public virtual bool IsNew()
		{
			return IsTransient();
		}
		
		public virtual bool IsValid()
		{
			return Context.Validator.IsValid(this);
		}

		//public virtual bool IsModified { get; set; }

		public virtual InvalidValue[] GetErrors()
		{
			ValidatorEngine val = NHibernate.Validator.Cfg.Environment.SharedEngineProvider.GetEngine();
			return val.Validate(this);
		}

		//public abstract object Clone();
        public virtual object Clone()
        {
            var result = (BaseEntity)MemberwiseClone();
            result.Id = 0;
            return result;
        }
	}

	public interface IEntity
	{
		int Id { get; }
		bool IsNew();
		bool IsValid();
		//bool IsModified { get; set; }
		//bool IsTracking { get; set; }
		//void EnableTracking();
		InvalidValue[] GetErrors();
		object Clone();
	}
}
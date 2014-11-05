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
	public abstract class EntityAdv : BaseEntity
	{
		public virtual string CreatedBy { get; set; }
		public virtual DateTime? CreatedOn { get; set; }
		public virtual string ModifiedBy { get; set; }
		public virtual DateTime? ModifiedOn { get; set; }

		public virtual bool IsTracking { get; set; }
		public virtual bool IsModified { get; set; }

		public virtual void EnableTracking()
		{
			IsTracking = true;
		}
	}

}
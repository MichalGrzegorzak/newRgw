using System;

namespace Kanc.MVP.Core.Domain.Entities.Base
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
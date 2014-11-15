using System;

namespace Kanc.MVP.Core.Domain.Entities.Base
{
	public interface IGenericEntity<TIdentity> : IEquatable<IGenericEntity<TIdentity>>
	{
		TIdentity Id { get; }
	}
}
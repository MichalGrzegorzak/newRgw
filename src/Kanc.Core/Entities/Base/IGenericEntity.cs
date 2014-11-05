using System;

namespace Kanc.Core.Entities
{
	public interface IGenericEntity<TIdentity> : IEquatable<IGenericEntity<TIdentity>>
	{
		TIdentity Id { get; }
	}
}
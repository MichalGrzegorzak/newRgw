using Kanc.UI.Tests.Infrastructure.Setup;
using NHibernate;
using NHibernate.Validator.Engine;

namespace Kanc.UI.Tests
{
	public class Context
	{
		public static ISessionFactory SessionFactory { get; set; }
		public static ValidatorEngine Validator { get; set; }

		public static SessionFactoryInitializer FactoryInitializer { get; set; }
	}
}
using Kanc.Core.Entities;
using NHibernate;
using NHibernate.Validator.Engine;

namespace Kanc.Core
{
	public class Context
	{
		public static ISessionFactory SessionFactory { get; set; }
		public static ValidatorEngine Validator { get; set; }
		public static SessionFactoryInitializer FactoryInitializer { get; set; }

        public static Slowniki Slownik { get; set; }

        public static ListaZaplat ListaNiemcy { get; set; }
        public static ListaZaplat ListaHolandia { get; set; }

        public static bool IsTestingMode { get; set; }
        public static bool IsReportTestingMode { get; set; }
	}
}
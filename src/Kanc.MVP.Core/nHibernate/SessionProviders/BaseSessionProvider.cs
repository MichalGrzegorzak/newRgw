using FluentNHibernate.Automapping;
using FluentNHibernate.Cfg;
using Kanc.MVP.Core.nHibernate.Base;
using Kanc.MVP.Core.nHibernate.Conventions;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace Kanc.MVP.Core.nHibernate.SessionProviders
{
    public abstract class BaseSessionProvider<T> where T : class, new()
    {
        protected static T instance;
        public static T Instance
        {
            get { return instance ?? (instance = new T()); }
        }

        protected ISessionFactory sessionFactory;
        protected Configuration configuration;

        protected BaseSessionProvider() { }

        public void Initialize()
        {
            sessionFactory = CreateSessionFactory();

            ExportSchema();
        }

        public abstract FluentConfiguration GetDatabase();

        protected ISessionFactory CreateSessionFactory()
        {
            return GetDatabase()
                .ExposeConfiguration(cfg => configuration = cfg)
                .Mappings(val => val.AutoMappings.Add(
                    AutoMap.AssemblyOf<IAutoMap>(new AutomappingConfiguration())
                    .Conventions.Setup(con =>
                {
                    //con.Add<DefaultTableNameConvention>();
                    con.Add<DefaultPrimaryKeyConvention>();
                    con.Add<DefaultStringLengthConvention>();
                    con.Add<DefaultReferenceConvention>();
                    con.Add<DefaultHasManyConvention>();
                    con.Add<CascadeAllConvention>();
                })))
                .BuildSessionFactory();
        }

        public ISession OpenSession()
        {
            ISession session = sessionFactory.OpenSession();

            //var export = new SchemaExport(configuration);
            //SchemaExport(export, session);

            return session;
        }

        private void ExportSchema()
        {
            // Validate the schema: if wrong try to create the new schema
			try
			{
                new SchemaValidator(configuration).Validate();
			}
			catch (HibernateException ex)
			{
				var s = ex.Message;
                RecreateDB(configuration);
			}
		}

        public static void RecreateDB(Configuration conf)
        {
            var export = new SchemaExport(conf);
            export.Drop(false, true);
            export.Create(false, true);

            //schema.Execute(true, true, false, session.Connection, null);
        }

        public void Dispose()
        {
            if (sessionFactory != null)
                sessionFactory.Dispose();

            sessionFactory = null;
            configuration = null;
        }
    }
}

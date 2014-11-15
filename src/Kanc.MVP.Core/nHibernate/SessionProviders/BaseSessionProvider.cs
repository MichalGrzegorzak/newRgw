using System;
using FluentNHibernate.Automapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Kanc.MVP.Core.nHibernate.Base;
using Kanc.MVP.Core.nHibernate.Conventions;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace Kanc.MVP.Tests.nHibernate.Core
{
    public abstract class BaseSessionProvider<T> where T : class, new()
    {
        private static T instance;
        public static T Instance
        {
            get { return instance ?? (instance = new T()); }
        }

        private ISessionFactory sessionFactory;
        private Configuration configuration;

        private BaseSessionProvider() { }

        public void Initialize()
        {
            sessionFactory = CreateSessionFactory();
        }

        public abstract FluentConfiguration GetDatabase();
        //{
        //    return Fluently.Configure();
        //}



        private ISessionFactory CreateSessionFactory()
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

            var export = new SchemaExport(configuration);
            export.Execute(true, true, false, session.Connection, null);

            return session;
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

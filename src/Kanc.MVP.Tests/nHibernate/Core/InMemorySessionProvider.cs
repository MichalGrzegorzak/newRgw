﻿using System;
using FluentNHibernate.Automapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace Kanc.MVP.Tests.nHibernate.Core
{
    public class InMemorySessionFactoryProvider
    {
        private static InMemorySessionFactoryProvider instance;
        public static InMemorySessionFactoryProvider Instance
        {
            get { return instance ?? (instance = new InMemorySessionFactoryProvider()); }
        }

        private ISessionFactory sessionFactory;
        private Configuration configuration;

        private InMemorySessionFactoryProvider() { }

        public void Initialize()
        {
            sessionFactory = CreateSessionFactory();
        }

        private ISessionFactory CreateSessionFactory()
        {
            var db = MsSqlConfiguration.MsSql2008.ConnectionString(
                connstr => connstr.FromConnectionStringWithKey("dbNH"));

            //sqlite
            //var db = SQLiteConfiguration.Standard.InMemory();

            return Fluently.Configure()
                .Database(db.ShowSql)
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

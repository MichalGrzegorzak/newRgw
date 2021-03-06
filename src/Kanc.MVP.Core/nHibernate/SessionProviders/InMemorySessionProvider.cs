﻿using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;

namespace Kanc.MVP.Core.nHibernate.SessionProviders
{
    public class InMemorySessionFactoryProvider : BaseSessionProvider<InMemorySessionFactoryProvider>
    {
        public override FluentConfiguration GetDatabase()
        {
            var db = SQLiteConfiguration.Standard.InMemory();
            return Fluently.Configure().Database(db.ShowSql);
        }
    }
}

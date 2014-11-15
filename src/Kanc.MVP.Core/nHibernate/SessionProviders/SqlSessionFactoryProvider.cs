using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;

namespace Kanc.MVP.Core.nHibernate.SessionProviders
{
    public class SqlSessionFactoryProvider : BaseSessionProvider<SqlSessionFactoryProvider>
    {
        public override FluentConfiguration GetDatabase()
        {
            var db = MsSqlConfiguration.MsSql2008.ConnectionString(
                connstr => connstr.FromConnectionStringWithKey("dbNH"));

            return Fluently.Configure().Database(db.ShowSql);
        }
    }
}

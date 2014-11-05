using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Cfg;
using NHibernate;
//using NHibernate.Linq;
using System.IO;
using Kanc.Core.Entities;

namespace Kanc.Core
{
    public class DBContext : IDisposable
    {
        private ISession session = null;

        public DBContext(ISession session)
        {
            this.session = session;
            ///this.session = Context.SessionFactory.OpenSession();
        }

        public IQueryable<Kraj> Kraje
        {
            get
            {
                return (this.session.Query<Kraj>());
            }
        }

        public IQueryable<Polecil> Polecajacy
        {
            get
            {
                return (this.session.Query<Polecil>());
            }
        }

        public IQueryable<Rozliczenie> Rozliczenia
        {
            get
            {
                return (this.session.Query<Rozliczenie>());
            }
        }

        public IQueryable<Klient> Klienci
        {
            get
            {
                return (this.session.Query<Klient>());
            }
        }

        public IQueryable<Adres> Adresy
        {
            get
            {
                return (this.session.Query<Adres>());
            }
        }

        public IQueryable<Bank> Banki
        {
            get
            {
                return (this.session.Query<Bank>());
            }
        }

        #region IDisposable Members

        public void Dispose()
        {
            if (this.session != null)
            {
                this.session.Dispose();
                this.session = null;
            }
        }

        #endregion
    }
}

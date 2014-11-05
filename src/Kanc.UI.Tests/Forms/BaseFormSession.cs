using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using Kanc.UI.Tests;
using NHibernate;
using System;

namespace Kanc.UI.Tests
{
    /// <summary>
    /// Czysta implementacja sesji
    /// </summary>
    public class BaseFormSession : BaseForm
    {
        private readonly bool isStandAlone = true;
        private ISession session;
        //protected T addedItem = null;

        public BaseFormSession() {}

        public BaseFormSession(ISession session) : this()
        {
            if (session != null)
            {
                isStandAlone = false;
            }
            this.session = session;
        }

        public ISession Session
        {
            get
            {
                if (session == null || !session.IsOpen)
                {
                    CreateSession();
                }
                return session;
            }
        }

        /// <summary>
        /// Sesja tworzy sie sama, uzywaj tej metody, jesli nhibernate rzuci wyjatek
        /// </summary>
        public void CreateSession()
        {
            if (session != null)
            {
                session.Dispose();
            }
            session = Context.SessionFactory.OpenSession();
            session.FlushMode = FlushMode.Never;
        }

        public bool IsStandAlone
        {
            get { return isStandAlone; }
        }

        private void BaseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isStandAlone && session != null)
            {
                session.Dispose();
            }
        }

        protected void btnAnuluj_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        //protected void btnOk_Click(object sender, System.EventArgs e)
        //{
        //    if (addedItem != null)
        //    {
        //        if (addedItem.IsValid())
        //            AddNewItem(addedItem);
        //        else
        //            return;
        //    }

        //    using (ITransaction tx = Session.BeginTransaction())
        //    {
        //        Session.Flush();
        //        tx.Commit();
        //    }
        //    Close();
        //}

        //protected void AddNewItem(object item)
        //{
        //    using (ITransaction tx = Session.BeginTransaction())
        //    {
        //        Session.Save(item);
        //        tx.Commit();
        //    }
        //}

        //protected void DeleteItem(object item)
        //{
        //    using (ITransaction tx = Session.BeginTransaction())
        //    {
        //        Session.Delete(item);
        //        tx.Commit();
        //    }
        //}
    }


}


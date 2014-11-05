using System.ComponentModel;
using System.Linq.Expressions;
using System.Windows.Forms;
using Kanc.UI.Ctrl;
using NHibernate;
using Kanc.Core;

namespace Kanc.UI.Forms
{
    /// <summary>
    /// Czysta implementacja sesji
    /// </summary>
    public class BaseSession : Form
    {
        protected readonly bool isStandAlone = true;
        protected ISession session;

        protected bool IsInDesignMode
        {
            get
            {
                return (LicenseManager.UsageMode == LicenseUsageMode.Designtime);
            }
        }

        public BaseSession() : base()
        {
            if (!DesignMode)
            {
                this.FormClosed += BaseForm_FormClosed;
            }
        }

        public BaseSession(ISession session) : this()
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
            if (Context.SessionFactory == null)
                return;
            
            
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

        protected void BaseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isStandAlone && session != null)
            {
                session.Dispose();
            }
        }

        //protected void btnAnuluj_Click(object sender, System.EventArgs e)
        //{
        //    Close();
        //}



    }
}


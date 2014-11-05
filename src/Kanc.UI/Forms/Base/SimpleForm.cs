using System;
using System.Diagnostics.Contracts;
using Kanc.Core.Entities;
using Kanc.UI.Ctrl;
using NHibernate;
using NHibernate.Validator.Binding.Util;

namespace Kanc.UI.Forms
{
    public class SimpleForm : BaseFormSessionGeneric<Rozliczenie>
    {
        public SimpleForm()
        {
            this.Load += new EventHandler(SimpleForm_Load);
        }
        public SimpleForm(Rozliczenie roz)
        {
            this.CurrentItem = roz;
            this.Load += new EventHandler(SimpleForm_Load);
        }
        public SimpleForm(ISession session, Rozliczenie roz) : base(session)
        {
            this.CurrentItem = roz;
            this.Load += new EventHandler(SimpleForm_Load);
        }

        void SimpleForm_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;

            General_LoadData();
        }

    }
}
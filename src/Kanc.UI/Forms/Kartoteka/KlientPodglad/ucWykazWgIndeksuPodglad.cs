using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Kanc.Core;
using Kanc.Core.Entities;
using NHibernate;

namespace Kanc.UI.Ctrl
{
    public partial class ucWykazWgIndeksuPodglad : BaseUserControl
    {
        public ucWykazWgIndeksuPodglad()
        {
            InitializeComponent();
        }

        public override void LoadData(Binder binder, bool option = false)
        {

        }

        public int CustomerId { get; set; }

        private void ucWykazWgIndeksuPodglad_Load(object sender, EventArgs e)
        {
            if (Session != null)
            {
                IList<Rozliczenie> _rozliczeniaWgIndeksu;
                using (ITransaction tx = Session.BeginTransaction())
                {
                    _rozliczeniaWgIndeksu = Session.QueryOver<Rozliczenie>()
                              .Where(t => t.Klient.Id == CustomerId)
                              .OrderBy(t => t.Rok).Desc
                              .List();

                    tx.Commit();
                }

                wykazBindingSource.DataSource = _rozliczeniaWgIndeksu;
                wykazGridView.DataSource = wykazBindingSource;
                wykazGridView.AutoGenerateColumns = false;
            }
        }
    }
}

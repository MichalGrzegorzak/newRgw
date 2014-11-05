using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Kanc.Core.Entities;
using NHibernate;
using NHibernate.Transform;

namespace Kanc.UI.Forms
{
    public partial class FrmTest1 : BaseFormSession
    {
        public FrmTest1()
        {
            InitializeComponent();

            this.Load += new EventHandler(FrmTest1_Load);
        }

        void FrmTest1_Load(object sender, EventArgs e)
        {
            all = LoadAll();
            rozliczenieBindingSource.DataSource = all;
        }

        IList<Rozliczenie> all = new List<Rozliczenie>();


        public IList<Rozliczenie> LoadAll()
        {
            return LoadAll(String.Empty, true);
        }

        public IList<Rozliczenie> LoadAll(String associationPath, Boolean lazy)
        {
            return Session.QueryOver<Rozliczenie>().Where(x => x.Id < 1000).List();
            //ICriteria criteria = Session.CreateCriteria(typeof(Rozliczenie));
            //if (lazy)
            //{
            //    return criteria.List<Rozliczenie>();
            //}
            //else
            //{
            //    return criteria.SetFetchMode(associationPath, FetchMode.Join)
            //    .SetResultTransformer(new DistinctRootEntityResultTransformer()).List<Rozliczenie>();
            //}
        }

        private void rozliczenieBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Rozliczenie r = rozliczenieBindingSource.Current as Rozliczenie;
            MessageBox.Show(r.Partner.Imie);
        }

    }
}

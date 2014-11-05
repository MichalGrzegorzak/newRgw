using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Kanc.Core;
using Kanc.UI.Ctrl;
using Kanc.Core.Entities;
using NHibernate;
using NHibernate.Validator.Binding;

namespace Kanc.UI.Forms
{
    public partial class FrmKartotekaPodglad : FrmKartotekaPodgladChild
    {
        public int RozliczenieId { get; set; }

        public FrmKartotekaPodglad()
        {
            this.Text = "Kartoteka";
            
            InitializeComponent();
        }

        private void FrmKartotekaPodglad_Load(object sender, EventArgs e)
        {
            IList<Rozliczenie> _rozliczenia;

            if(RozliczenieId > 0)
            {
                using (ITransaction tx = Session.BeginTransaction())
                {
                    _rozliczenia = Session.QueryOver<Rozliczenie>()
                              .Where(t => t.Id == RozliczenieId)
                              .List();

                    CurrentItem = _rozliczenia[0];

                    tx.Commit();
                }

                MainBindingSrc.DataSource = _rozliczenia[0];
            }

            if (CurrentItem != null)
                LoadAndBind();
        }

        protected override void LoadAndBind()
        {
            binder = new Binder(MainBindingSrc, null, true);

            ucPodstKlientPodglad1.LoadData(binder);
            ucAdresPodglad1.LoadData(binder);
            ucKontoPodglad1.LoadData(binder);
            ucRodzinaPodglad1.LoadData(binder);
            ucHistoriaPodglad1.LoadData(binder);
            ucRachunekPodglad1.LoadData(binder);
            ucReklamacje1.LoadData(binder);

            //ucPodstKlientPodglad1.Enabled = false;
            //ucAdresPodglad1.Enabled = false;
            //ucKontoPodglad1.Enabled = false;
            //ucRodzinaPodglad1.Enabled = false;

            ucWykazWgIndeksuPodglad1.Session = Session;
            ucWykazWgIndeksuPodglad1.CustomerId = binder.Rozliczenie.Klient.Id;
            ucWykazWgIndeksuPodglad1.LoadData(binder);
            //ucHistoriaPodglad1.Historia = r.Historia ?? new List<Historia>();
        }


    }

    public class FrmKartotekaPodgladChild : BaseFormSessionGeneric<Rozliczenie>
    {

    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Kanc.Commons;
using Kanc.Commons.Controls.Enums;
using Kanc.Core;
using Kanc.Core.Entities;
using Kanc.UI.Ctrl;
using Kanc.UI.Forms;
using NHibernate;
using Kanc.Core.Features;
using System.Configuration;
using NHibernate.Cfg;
using NHibernate.Validator.Binding;
using NHibernate.Validator.Engine;
using NHibernate.Linq;

namespace Kanc.UI.Forms
{
    public partial class FormTest2 : Form1Base
    {
        public FormTest2()
        {
            InitializeComponent();

            //binder = new Binder(MainBindingSrc, new SmartViewValidator(errorProvider2));
        }

        public int RozliczenieId { get; set; }


        private void FormTest2_Load_1(object sender, EventArgs e)
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
                LoadData(CurrentItem);
        }

        private void LoadData(Rozliczenie roz)
        {
            binder = new Binder(MainBindingSrc, null, true);
            binder.Bind(textBox1, (Rozliczenie r) => r.Klient.Nazwisko).ValidateWithEvent();
            binder.Bind(krajeDDL1, (Rozliczenie r) => r.Kraj);
        }

        //protected override void BindControls()
        //{
        //    log.Debug("BindControls begin");

        //    //ucPodstKlient1.LoadData(binder);
        //    //binder.Bind(typyListGrpBox1, (Rozliczenie r) => r.Status, "Selected");
        //    binder.Bind(textBox1, (Rozliczenie r) => r.Klient.Nazwisko).ValidateWithEvent();
        //    binder.Bind(krajeDDL1, (Rozliczenie r) => r.Kraj);

        //}

        private void button1_Click(object sender, EventArgs e)
        {
            //bool rr = Session.IsDirtyEntity(CurrentItem);
            SaveItem();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GenerateDBData gen = new GenerateDBData();
            var list = gen.GenerateList(10);

            foreach (Rozliczenie rozliczenie in list)
            {
                using (ITransaction tx = Session.BeginTransaction())
                {
                    Session.SaveOrUpdate(rozliczenie);
                    Session.Flush();
                    tx.Commit();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BootStrapper.RecreateDB(new Configuration().Configure("hibernate.cfg.xml"));
        }

        

        //private void splitContainer1_Panel1_MouseEnter(object sender, EventArgs e)
        //{
        //    splitContainer1.SplitterDistance = 145;
        //}
        //private void splitContainer1_Panel2_MouseEnter(object sender, EventArgs e)
        //{
        //    splitContainer1.SplitterDistance = 44;
        //}
    }

    public class Form1Base : BaseFormSessionGeneric<Rozliczenie>
    {
    }
}

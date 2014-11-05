using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
using Kanc.UI.Tests;
using Kanc.UI.Tests.Controls;
using NHibernate;
using NHibernate.Mapping;
using NHibernate.Validator.Binding;
using NHibernate.Validator.Engine;

namespace Kanc.UI.Tests
{
    public partial class Binding_DynamicProxy_Atributes : BaseFormSession
    {
        public Binding_DynamicProxy_Atributes()
        {
            InitializeComponent();

            if (!DesignMode) this.Load += FormLoad;
        }

        public void FormLoad(object sender, EventArgs e)
        {
            rachunekBindingSource.DataSource = LoadAll();
            //ucRozliczenie1.LoadData(rachunekBindingSource);
            ucRozliczenie1.Session = Session;
        }

        /// <summary>
        /// save
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            Rachunek_A r = rachunekBindingSource.Current as Rachunek_A;
            bool ch = ValidateChildren();
            if (!r.IsValid())
            {
                IList<InvalidValue> errors = r.GetErrors();
                string s = errors.Select(x => x.Message + "\n").Aggregate((i,j) => i + "\n" + j );
                MessageBox.Show(s);
                return;
            }
            else
            {
                using (ITransaction tx = Session.BeginTransaction())
                {
                    Session.SaveOrUpdate(r);
                    Session.Flush();
                    tx.Commit();
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Kraj_A c = new Kraj_A();
            //c.Name = "NA";
            //c.NazwaPL = "PL";
            //c.NazwaEU = "EU";

            Klient_A k = new Klient_A();
            k.Name = "name klienta";
            k.Urodz = DateTime.Now;

            Rachunek_A r = new Rachunek_A();
            r.Name = "name rachunku";
            r.KlientA = k;
            //r.KlientA.KrajA = c;

            using (ITransaction tx = Session.BeginTransaction())
            {
                Session.SaveOrUpdate(r);
                Session.Flush();
                tx.Commit();
            }
        }

        private IList<Rachunek_A> LoadAll()
        {
            IList<Rachunek_A> results = null;
            using (ITransaction tx = Session.BeginTransaction())
            {
                results = Session.QueryOver<Rachunek_A>().List();
                Session.Flush();
                tx.Commit();
            }
            return results;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (ITransaction tx = Session.BeginTransaction())
            {
                //szukaj po nazwisku
                {
                    var wyniki =
                        (from r in Session.QueryOver<Rachunek_B>()
                         //where r.Rok == 1981
                         where r.Klient.Name == "aaa"
                         select r).List();

                    var pod = (from w in wyniki
                               select new { w.Id, w.Klient.Urodz }).ToList().Distinct();
                }
            }
        }


    }
}

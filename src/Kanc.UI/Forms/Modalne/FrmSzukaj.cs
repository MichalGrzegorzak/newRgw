using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Kanc.Core.Entities;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Linq;

namespace Kanc.UI.Forms
{
    public partial class FrmSzukaj : FrmSzukajChild
    {
        public FrmSzukaj()
        {
            InitializeComponent();
        }

        private void szukajButton_Click(object sender, EventArgs e)
        {
            var nazwisko = nazwiskoTextBox.Text;
            var mandId = mandantenTextBox.Text;
            bool dataOk = true;
            DateTime data;
            if (!DateTime.TryParse(dataUrodzeniaTextBoxExt.Text, out data))
            {
                dataOk = false;
            }
            else
            {
                if (data == DateTime.MinValue)
                {
                    dataOk = false;
                }
            }
            IEnumerable<Rozliczenie> wyniki = new Rozliczenie[] {};
            IEnumerable<object> pod = new Rozliczenie[] { };

            //!!! QueryOver<> musi zuwac JOINOW do przegladania dzieci, ale ma duzo featurow -> .List()

            using (ITransaction tx = Session.BeginTransaction())
            {
                //szukaj po nazwisku
                if (!string.IsNullOrEmpty(nazwisko))
                {
                    
                    wyniki =
                        (from r in Session.Query<Rozliczenie>()
                         .Where(x=>x.Klient.Nazwisko == nazwisko)
                         select r).ToList();

                    pod = (from w in wyniki
                               select new {w.Id, w.Klient.Imie, w.Klient.Nazwisko, w.Klient.Urodz  }).ToList().Distinct();
                    //szukajbindingSource.DataSource = pod;
                }

                //szukaj po mand id
                if (!string.IsNullOrEmpty(mandId))
                {
                    wyniki =
                        (from r in Session.Query<Rozliczenie>()
                         where r.Klient.MandId == mandId
                         select r).ToList();

                    pod = (from w in wyniki
                               select new { w.Id, w.Klient.Imie, w.Klient.Nazwisko, w.Klient.Urodz }).ToList().Distinct();
                   // szukajbindingSource.DataSource = pod;
                }

                //szukaj po dacie urodzenia
                if (dataOk)
                {
                    wyniki =
                        (from r in Session.Query<Rozliczenie>()
                         where r.Klient.Urodz == data
                         select r).ToList();

                    pod = (from w in wyniki
                               select new { w.Klient.Id, w.Klient.Imie, w.Klient.Nazwisko, w.Klient.Urodz }).ToList().Distinct();
                    //szukajbindingSource.DataSource = pod;
                }

                wynikiGridView.DataSource = pod;
                tx.Commit();
            }

            if (wyniki.Any())
            {
                FindRozliczeniaForPerson(wyniki.First().Klient.Id);
            }
        }

        private void wynikiGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.wynikiGridView.SelectedRows[0].Cells[0].Value != null)
            {
                int klientId = (int) this.wynikiGridView.SelectedRows[0].Cells[0].Value;
                FindRozliczeniaForPerson(klientId);
            }

            
        }

        private void FindRozliczeniaForPerson(int klientId)
        {
            //if (klientId <= 0) return;

            var wyniki = (from r in Session.QueryOver<Rozliczenie>()
                             where r.Klient.Id == klientId
                             select r).List();

            var pod = (from w in wyniki
                        select new { w.Id, w.Rok }).ToList().Distinct();

            if (pod.Count() > 0)
            {
                rozliczeniabindingSource.DataSource = pod;
                rozliczeniaGridView.DataSource = rozliczeniabindingSource;

                if (pod.Count() == 1)
                {
                    UIContext.MainForm.OpenNewRozliczenie(pod.First().Id);
                }
            }
        }


        private void rozliczeniaGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.rozliczeniaGridView.SelectedRows[0].Cells[0].Value != null)
            {
                //var podglad = ShowFormAsMdi<FrmKartotekaPodglad>(true);
                //var podglad = new FrmKartotekaPodglad();
                //podglad.Show();
                int id = (int)this.rozliczeniaGridView.SelectedRows[0].Cells[0].Value;
                UIContext.MainForm.OpenNewRozliczenie(id);
                
                //this.Close();
            }
        }
    }

   
    public class FrmSzukajChild : BaseFormSessionGeneric<Rozliczenie>
    {
    }
}

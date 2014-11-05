using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Kanc.Core;
using Kanc.Core.Entities;
using NHibernate;
using NHibernate.Linq;

namespace Kanc.UI.Forms
{
    public partial class Glowna : BaseFormSessionRozlicz
    {
        public Glowna()
        {
            InitializeComponent();
            
        }

        protected override void InitForm()
        {
            this.AcceptButton = btnSzukaj;
            NavigatorEnabled = false;

            Session.FlushMode = FlushMode.Never;
            //Session = null;
            
            EventPublisher.Register<RozliczenieSaved>(ChildSaved);

            BindControlsOnForm();
        }

        protected override void BindControlsOnForm()
        {
            var nazwisko = txbPoNazwisku.Text;
            IEnumerable<object> wyniki = new Rozliczenie[] { };
            using (ITransaction tx = Session.BeginTransaction())
            {
                //szukaj po nazwisku
                if (!string.IsNullOrEmpty(nazwisko))
                {
                    wyniki = (from r in Session.Query<Rozliczenie>()
                             .Where(x => x.Klient.Nazwisko == nazwisko)
                              select r).ToList();
                }
            }
            var rrrr = wyniki.First() as Rozliczenie;
            MainBindingSrc.DataSource = rrrr;
            binder.source = MainBindingSrc;
            FrmKontoBankowe frm = new FrmKontoBankowe(null, rrrr);
            frm.Show();

        }

        private void Search()
        {
            var nazwisko = txbPoNazwisku.Text;
            var mandId = txbPoMandaten.Text;
            bool dataOk = true;
            DateTime data;
            if (!DateTime.TryParse(txbPoDacie.Text, out data))
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
            IEnumerable<object> wyniki = new Rozliczenie[] { };
            //IEnumerable<object> pod = new Rozliczenie[] { };

            //!!! QueryOver<> musi zuwac JOINOW do przegladania dzieci, ale ma duzo featurow -> .List()
            using (ITransaction tx = Session.BeginTransaction())
            {
                //szukaj po nazwisku
                if (!string.IsNullOrEmpty(nazwisko))
                {
                    wyniki =
                        (from r in Session.Query<Rozliczenie>()
                         .Where(x => x.Klient.Nazwisko == nazwisko)
                         select new { r.Klient.Id, r.Rok, r.Klient.Nazwisko, r.Klient.Imie, r.Klient.Urodz }).ToList();

                    //pod = (from w in wyniki
                    //       select new {w.Klient.Id, w.Rok, w.Klient.Nazwisko, w.Klient.Imie, w.Klient.Urodz});
                    //szukajbindingSource.DataSource = pod;
                }

                //szukaj po mand id
                if (!string.IsNullOrEmpty(mandId))
                {
                    wyniki =
                        (from r in Session.Query<Rozliczenie>()
                         where r.Klient.MandId == mandId
                         select r).ToList();

                    //pod = (from w in wyniki
                    //       select new { w.Klient.Id, w.Rok, w.Klient.Nazwisko, w.Klient.Imie, w.Klient.Urodz });
                    // szukajbindingSource.DataSource = pod;
                }

                //szukaj po dacie urodzenia
                if (dataOk)
                {
                    wyniki =
                        (from r in Session.Query<Rozliczenie>()
                         where r.Klient.Urodz == data
                         select r).ToList();

                    //pod = (from w in wyniki
                    //       select new { w.Id, w.Rok, w.Klient.Nazwisko, w.Klient.Imie, w.Klient.Urodz });
                    //szukajbindingSource.DataSource = pod;
                }
                
                tx.Commit();

                wynikiGridView.DataSource = wyniki;
                CurrentItem = wyniki.First() as Rozliczenie;

                if (wyniki.Count() == 1) //autoopen if only one
                {
                    ShowEditForm(wyniki.First() as Rozliczenie);
                }
                
            }
        }

        private void wynikiGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(this.wynikiGridView.SelectedCells.Count > 0 && this.wynikiGridView.SelectedRows[0].Cells[0].Value != null)
            {
                int idRozliczenia = (int)this.wynikiGridView.SelectedRows[0].Cells[0].Value;
                Rozliczenie rozlicz = (from r in Session.QueryOver<Rozliczenie>()
                                   where r.Id == idRozliczenia
                                   select r).SingleOrDefault();
                ShowEditForm(rozlicz);
            }
        }

        private void btnSzukaj_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void btnPrzeglad_Click(object sender, EventArgs e)
        {
            EdycjaKlienta klient = new EdycjaKlienta();
            klient.NavigatorEnabled = true;
            klient.Show();
        }

        private void ShowEditForm(Rozliczenie roz)
        {
            EdycjaKlienta klient = new EdycjaKlienta(null, roz);
            //klient.Closing += new CancelEventHandler(klient_Closing);
            klient.Show();
            
            CurrentItem = roz;
        }

        void klient_Closing(object sender, CancelEventArgs e)
        {
            var frm = sender as EdycjaKlienta;
            if (frm.CurrentItem.IsValid())
            {
                Session.Merge(frm.CurrentItem);
                //Session.Evict(frm.CurrentItem);
                //Session.Clear();
            }
        }

        private void ChildSaved(RozliczenieSaved _)
        {
            Session.Merge(_.Item);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //txbPoDacie.Text = txbPoMandaten.Text = txbPoNazwisku.Text = txbPoSteunummer.Text = string.Empty;
            //wynikiGridView.DataSource = null;
            FrmKontoBankowe frm = new FrmKontoBankowe(null, CurrentItem);
            frm.Show();
        }

    }
}

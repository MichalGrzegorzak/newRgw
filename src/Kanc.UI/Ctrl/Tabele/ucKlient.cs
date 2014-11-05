using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Kanc.Core.Entities;
using Kanc.Core;
using NHibernate;
using NHibernate.Validator.Binding;

namespace Kanc.UI.Ctrl
{
    public partial class ucKlient : BaseUserControl, ICanAttachNavig
    {
        public ucKlient()
        {
            InitializeComponent();

            mtxbUrodz.EnableFormatDate();

            //Setting the ErrorProvider to the binder.
			SmartViewValidator vvtor = new SmartViewValidator(errorProvider1);

			//What are the Controls and who are the entity Type to bind to?
            vvtor.Bind(typeof (Klient))
                .With(idTextBox)
                .With(mtxbUrodz);

        }

        public bool CanAddNew { set { klientBindingSource.AllowNew = value; } }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Klient Klient
        {
            get
            {
                    return ((Klient)klientBindingSource.Current);
            }
            set { klientBindingSource.DataSource = value; }
        }

        public Klient GetFullData
        {
            get 
            {
                Klient.PoleconyPrzez = (Polecil)polecilBindingSource.Current;
                Klient.Plec = plecPlecComboBox.CurrentValue.Value;
                return Klient;
            }
        }

        //public Polecil Polecajacy
        //{
        //    get { return ((Polecil)polecilBindingSource.Current); }
        //}

        //public void LoadData(DBContext db)
        //{
        //    klientBindingSource.DataSource = db.Klienci.ToList();
        //    List<Polecil> polecajacy = db.Polecajacy.ToList();
            

        //    if (Klient == null)
        //    {
        //        klientBindingSource.DataSource = DataBindingFactory.Create<Klient>();
        //        nazwaComboBox.SelectedIndex = 0;
        //        cmbPlec.SelectedIndex = 0;
        //    }
        //    else
        //    {
        //        //nazwaComboBox.SetIndexByVal<Polecil>(Klient.PoleconyPrzez);
        //    }
        //}

        public void LoadData(ISession session)
        {
            var klienci = session.CreateQuery("from Klient").Future<Klient>();
            var polecajacy = session.CreateQuery("from Polecil").Future<Polecil>();

            if (klienci.ToList().Count == 0)
            {
                klientBindingSource.DataSource = DataBindingFactory.Create<Klient>();
            }
            else
            {
                klientBindingSource.DataSource = klienci;    
            }

            
            polecilBindingSource.DataSource = polecajacy;
            //nazwaComboBox.DataSource = polecajacy.Select(p=>p.Nazwa).ToList();

            if (Klient != null)
            {
                if(Klient.PoleconyPrzez != null)
                    nazwaComboBox.SetIndexByText(Klient.PoleconyPrzez.Nazwa);
                
                int v = (int)Klient.Plec;
                //cmbPlec.SelectedIndex = (v == 2) ? 1 : 0;
            }
        }

        public void AttachNavig(BindingNavigator navig)
        {
            navig.BindingSource = klientBindingSource;
        }
        
        private void klientBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            Klient k = DataBindingFactory.Create<Klient>();
            k.Urodz = new DateTime(1980, 01, 01);

            e.NewObject = k;
        }

        private void klientBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if(Klient != null && Klient.PoleconyPrzez != null)
                nazwaComboBox.SetIndexByText(Klient.PoleconyPrzez.Nazwa);

            //if (cmbPlec.DataSource != null)
            //{
            //    int v = (int)Klient.Plec;
            //    cmbPlec.SelectedIndex = (v == 2) ? 1 : 0;
            //}
        }

    }
}

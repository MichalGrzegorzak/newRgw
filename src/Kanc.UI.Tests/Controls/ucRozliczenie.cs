using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;
using Kanc.Commons;
using Kanc.UI.Tests;
using NHibernate;
using NHibernate.Validator.Engine;

namespace Kanc.UI.Tests.Controls
{
    public partial class ucRozliczenie : UserControl
    {
        public ucRozliczenie()
        {
            InitializeComponent();
        }

        //BindingSource roz
        public ISession Session { get; set; }
        private BindingSource source;

        //public void LoadData(Binder binder)
        //{
        //    source = binder.source;

        //    //rozliczenieBindingSource = s;
        //    //rozliczenieBindingSource.ResetCurrentItem();

        //    // Associate each text box with a column from the data source.
        //    //nameTextBox.DataBindings.Clear();

        //    nameTextBox.DataBindings.Add("Text", s, GetMemberName((Rachunek_A r) => r.Name), true, DataSourceUpdateMode.OnPropertyChanged);
        //    nameTextBox1.DataBindings.Add("Text", s, GetMemberName((Rachunek_A r) => r.KlientA.Name), true, DataSourceUpdateMode.OnPropertyChanged);
        //    //skrotTextBox.DataBindings.Add("Text", s, GetMemberName((Rachunek_A r) => r.KlientA.KrajA.Name), true, DataSourceUpdateMode.OnPropertyChanged);

        //    rachunekBindingNavigator.BindingSource = s;
        //    errorProvider1.DataSource = s;

        //    s.AddingNew += new AddingNewEventHandler(rozliczenieBindingSource_AddingNew);
        //}

        void rozliczenieBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = DataBindingFactory.Create<Rachunek_A>();
            //IList<Rachunek_A> list = source.DataSource as IList<Rachunek_A>;
            //list.Add(e.NewObject as Rachunek_A);
        }



        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            //IList<Rachunek_A> list = source.DataSource as IList<Rachunek_A>;
            //list.Add(new  Rachunek_A() );
            source.ResetCurrentItem();
        }

        private void rachunekBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            source.EndEdit();

            Rachunek_A r = source.Current as Rachunek_A;
            //var kraj = r.KlientA.KrajA;
            if(r.IsValid())
            {
                using (ITransaction tx = Session.BeginTransaction())
                {
                    Session.SaveOrUpdate(r);
                    Session.Flush();
                    tx.Commit();
                }
            }
            else
            {
                //validator.ValidatorEngine.Validate(r).ToList();
                IList<InvalidValue> errors = r.GetErrors();
                string s = errors.Select(x => x.Message + "\n").Aggregate((i, j) => i + "\n" + j);
                MessageBox.Show(s);
                return;
            }
            
        }
    }
}

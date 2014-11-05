using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;
using NHibernate;
using NHibernate.Linq;
using NHibernate.Validator.Binding;
using NHibernate.Validator.Engine;

namespace Kanc.UI.Tests
{
    /// <summary>
    /// 1) sypie sie przy przesuwaniu moveNext - SOLVED - validateChildren
    /// 2) sprawdzic czy obsluguje puste relacje / brak relacji
    /// </summary>
    public partial class Binding_SmartValidator_emptyEntities : BaseFormSession
    {
        IList<Rachunek_B> lista = new List<Rachunek_B>();
        private BindingSource source = new BindingSource();


        public Binding_SmartValidator_emptyEntities()
        {
            InitializeComponent();
            if (!DesignMode) this.Load += FormLoad;

            source.AddingNew += new AddingNewEventHandler(rachunek_BBindingSource_AddingNew);
        }

        void rachunek_BBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = new Rachunek_B();
            //DataBindingFactory.Create<Rachunek_B>();
        }

        public void FormLoad(object sender, EventArgs e)
        {
            //urodzDateTimePicker.NullValue = "Wybierz date";
            
            lista = LoadAll();

            source.DataSource = lista;
            rachunek_BBindingNavigator.BindingSource = source;

            Binder binder = new Binder(source, new SmartViewValidator(errorProvider1));
            
            //errorProvider1.DataSource = source; //nie idzcie ta droga !!
            
            //ucKlient1.LoadData(rozliczenieBindingSource);
            //ucKlient1.AttachValidation(validator);
            //ucRozliczenie1.LoadData(rachunekBindingSource);
            //ucRozliczenie1.Session = Session;

            //txtId.Validating += new EventValidation(validator).ValidatingHandler;
            
            binder.Bind(txtName, (Rachunek_B r) => r.Name).ValidateWithEvent();
            binder.Bind(txtklientName, (Rachunek_B r) => r.Klient.Name).ValidateWithEvent();
            binder.Bind(txtId, (Rachunek_B r) => r.Id).ValidateWithEvent();
            //binder.Bind(idTextBox1, (Rachunek_B r) => r.KlientB.Id).ValidateWithEvent();
            binder.Bind(urodzDateTimePicker, (Rachunek_B r) => r.Klient.Urodz, "Value").ValidateWithEvent();

        }

        private IList<Rachunek_B> LoadAll()
        {
            IList<Rachunek_B> results = null;
            using (ITransaction tx = Session.BeginTransaction())
            {
                results = Session.QueryOver<Rachunek_B>().List();
                //Rachunek_B rr = Session.Load<Rachunek_B>(1);
                Session.Flush();
                tx.Commit();
            }
            return results;
        }

        private void rachunek_BBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Rachunek_B r = source.Current as Rachunek_B;
            bool ch = ValidateChildren();
            //if (!r.IsValid())
            //{
            //    IList<InvalidValue> errors = r.GetErrors();
            //    string s = errors.Select(x => x.Message + "\n").Aggregate((i, j) => i + "\n" + j);
            //    MessageBox.Show(s);
            //}
            //else
            {
                using (ITransaction tx = Session.BeginTransaction())
                {
                    Session.SaveOrUpdate(r);
                    Session.Flush();
                    tx.Commit();
                }
                source.ResetBindings(false); //discard other changes
            }
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            //this.Validate();
            this.ValidateChildren();
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            //this.Validate();
            this.ValidateChildren();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ITransaction tx = Session.BeginTransaction())
            {
                //szukaj po nazwisku
                {
                    //QueryOver<>.
                    var wyniki =
                        (from r in Session.Query<Rachunek_B>()
                         //where r.Rok == 1981
                         where r.Klient.Name == "bbb"
                         select r);

                    var pod = (from w in wyniki
                               select new {w.Id, w.Klient.Urodz}).ToList().Distinct();
                }
            }
        }
    }

}

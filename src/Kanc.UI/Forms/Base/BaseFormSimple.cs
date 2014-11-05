using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Kanc.Core;
using Kanc.Core.Entities;
using Kanc.UI.Ctrl;
using Kanc.UI.Forms.Base;
using NHibernate;
using NHibernate.Validator.Binding;
using log4net;
using Binder = Kanc.Core.Binder;

namespace Kanc.UI.Forms
{
    public class BaseFormSimple : BaseSession
    {
        protected static ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        protected BindingSource MainBindingSrc { get; set; }
        protected ErrorProvider errorProvider1;
        protected Binder binder;
        private IContainer components;

        public bool SuccessfullSave = true;

        protected Rozliczenie r;
        Rozliczenie _currentItem = null;
        public Rozliczenie CurrentItem
        {
            get { return _currentItem; }
            set { _currentItem = value; }
        }

        protected bool IsValid
        {
            get
            {
                MainBindingSrc.EndEdit(); //aby odpalily wszystkie notifychanged
                return CurrentItem.IsValid();
                //&& ValidateChildren(); // nie wiem czemu to nie dziala juz !!!
            }
        }

        #region .ctor
        public BaseFormSimple()
            : base()
        {
            InternalInit();
        }

        public BaseFormSimple(ISession session, Rozliczenie roz)
            : base(session)
        {
            this.CurrentItem = r = roz;

            InternalInit();
        } 
        #endregion

        private void InternalInit()
        {
            if (IsInDesignMode) return;
            
            components = new Container();
            errorProvider1 = new ErrorProvider(components);
            errorProvider1.ContainerControl = this;

            MainBindingSrc = new BindingSource(); //zeby nie sprawdzac wszedzie null`a
            MainBindingSrc.DataSource = CurrentItem;

            binder = new Binder(MainBindingSrc, new SmartViewValidator(errorProvider1));
            //binder.source = MainBindingSrc;

            if (CanAttachLoadEvent)
            {
                Debug.WriteLine("BaseFormSimple -> odpalil LOAD!");
                this.Load += OnFormLoad;
            }
        }

        protected bool CanAttachLoadEvent
        {
            get { return !DesignMode && Context.SessionFactory != null; } // && !Context.TestingMode; }
        }

        #region Metody musza byc przeciazone !!

        protected virtual void Binding()
        {
            throw new Exception("Must be overrided!");
        }
        protected virtual void Init()
        {
            throw new Exception("Need to be overriden!");
        }
        #endregion

        public virtual void OnFormLoad(object sender, EventArgs e)
        {
            Init();

            RefreshBindingSource();

            //binduj dane jesli dostepne 
            if (CurrentItem != null)
            {
                Binding();
                //CurrentItem.EnableTracking(); //bajer, wlacz monitorowanie zmian w encjach
            }
        }

        protected virtual void RefreshBindingSource()
        {
            //MainBindingSrc.DataSource = CurrentItem;
            MainBindingSrc.ResetCurrentItem(); //odswiez binding
        }

        #region fix do kolejnosci zamykania form

        public bool IsTestMode
        {
            get { return Context.IsTestingMode; }
        }

        protected IList<Form> _openedForms = new List<Form>();
        protected override void Dispose(bool disposing)
        {
            if (!IsTestMode)
            {
                bool ok = SaveItem(true);
                if (!ok)
                {
                    if (AskDiscardChangesAndClose() == DialogResult.No)
                        return;
                }
            }

            //closing & discarding changes
            for (int i = 0; i < _openedForms.Count; i++)
            {
                _openedForms[i].Dispose();
            }
            //if (tabForms.SelectedIndex > 0)
            //    tabForms.SelectedIndex--;
            base.Dispose(disposing);
            
        }

        #endregion

        private DialogResult AskDiscardChangesAndClose()
        {
            return MessageBox.Show("Czy jestes pewien ze chcesz zamknac formularz?", "Uwaga! Nie zapisano zmian.",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public void LoadItemById(int id)
        {
            Contract.Requires(id > 0, "LoadItemById, ladujesz item o ID: 0");

            CurrentItem = GetItem(id);
        }

        #region Nhibernate - Save, Delete, Get

        protected virtual bool SaveItem(bool forceFlush = false)
        {
            ValidateChildren(); //refresh errorProvider

            if (IsValid)
            {
                if (IsStandAlone || forceFlush)
                {
                    using (ITransaction tx = Session.BeginTransaction())
                    {
                        Session.SaveOrUpdate(CurrentItem);
                        Session.Flush();
                        tx.Commit();
                    }
                }
                else
                {
                    Session.SaveOrUpdate(CurrentItem);
                }

                SuccessfullSave = true;
                RefreshBindingSource();
                return true;
            }
            else
            {
                SuccessfullSave = false;
                ShowErrorIfAny();
                return false;
            }

        }

        protected virtual void DeleteItem()
        {
            string message = "Usunieto item.";
            if (CurrentItem.Id > 0)
            {
                try
                {
                    using (ITransaction tx = Session.BeginTransaction())
                    {
                        Session.Delete(CurrentItem);
                        Session.Flush();
                        tx.Commit();
                    }
                    //MoveItem(); //trzeba 'zejsc' z obecnego elemntu -> navigation
                }
                catch (Exception e)
                {
                    log.Error("Wyjatek przy Delete.", e);
                    message = "Nie mozna usunac elementu, istnieje dowiazanie do niego.";

                    CreateSession(); //zawsze po wyjatku z NH, trzeba odtworzyc sesje
                }
            }

            RefreshBindingSource();
            MessageBox.Show(message);


            //string query = string.Format("from {0} o where o.Id = {1}", typeof(T).Name, itemId);
            //Session.Delete(query);
            //_lastId = itemId;
        }

        protected Rozliczenie GetItem(int id)
        {
            Rozliczenie item = new Rozliczenie();
            if (id > 0)
            {
                using (ITransaction tx = Session.BeginTransaction())
                {
                    item = Session.Load<Rozliczenie>(id);
                    tx.Commit();
                }
            }
            return item;
        }

        protected IList<int> GetListOfIds()
        {
            string query = string.Format(@"select item.Id from {0} item", typeof(Rozliczenie).Name);

            IList results = Session.CreateQuery(query).List();
            IList<int> final = new List<int>();
            foreach (var result in results)
            {
                final.Add((int)result);
            }
            return final;
        }

        #endregion

        protected void ShowErrorIfAny()
        {
            string err = "";
            CurrentItem.GetErrors().ToList().ForEach(a => err += a.PropertyName + " " + a.Message + "\n");
            if (err.Length > 0)
                MessageBox.Show(err);
        }


        protected void ShowModalForm<T>() where T : BaseSession, new()
        {
            //object item = ((IEntity)MainBindingSrc.DataSource).Clone();
            var clon = CurrentItem.Clone() as Rozliczenie;

            BaseSession frm = null;
            if (typeof(T) == typeof(FrmEuEwr))
            {
                frm = new FrmEuEwr(session, clon);
            }
            if (typeof(T) == typeof(FrmPodatekStrona))
            {
                frm = new FrmPodatekStrona(session, clon);
            }
            if (typeof(T) == typeof(FrmEuEwr))
            {
                //frm = new FrmEuEwr(session, clon);
            }


            frm.ShowDialog(this);
        }



  

    }
}
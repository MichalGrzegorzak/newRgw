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
    public class BaseFormSessionRozlicz : BaseSession
    {
        protected static ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        //public event EventHandler<RozliczenieArgs> Saved

        public BindingSource MainBindingSrc { get; set; }
        //public BindingNavigator navigator = null;
        public ErrorProvider errorProvider1 = null;
        public Binder binder;
        private IContainer components;

        public bool NavigatorEnabled { get; set; }

        public bool SuccessfullSave = true;

        private int _lastPosition = 0;

        Rozliczenie _currentItem = null;
        public Rozliczenie CurrentItem
        {
            get { return _currentItem; }
            set { _currentItem = value; }
        }

        public BaseFormSessionRozlicz()
        {
            InternalInit();
            AttachEvents();
            
            IdsBindingSource.CurrentChanged += new EventHandler(IdsBindingSource_CurrentChanged);
        }

        void IdsBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            _lastPosition = IdsBindingSource.Position;
        }


        public BaseFormSessionRozlicz(ISession session, Rozliczenie roz) : base(session)
        {
            Contract.Requires(roz != null);

            //this.CurrentItem = roz;
            //this.CurrentItem = _startingItem = roz;
            //if (session == null)
            //{
            
            //}
            
            Session.Merge(roz);
            this.CurrentItem = Session.Load<Rozliczenie>(roz.Id);

            InternalInit();
            AttachEvents();
        }

        private void InternalInit()
        {
            Debug.WriteLine("TRYB: " + DesignMode);
            if (IsInDesignMode || Context.SessionFactory == null)
                return;


            components = new Container();
            errorProvider1 = new ErrorProvider(components);
            errorProvider1.ContainerControl = this;

            //NavigatorEnabled = true;
            KeyPreview = true;
            //ResetTabIndex();

            MainBindingSrc = new BindingSource(); //zeby nie sprawdzac wszedzie null`a
            binder = new Binder(MainBindingSrc, new SmartViewValidator(errorProvider1));
        }

        protected virtual void InitForm()
        {
            throw new Exception("Need to be overriden!");
        }

        private void AttachEvents()
        {
            //if (NavigatorEnabled)
            IdsBindingSource.AddingNew += new AddingNewEventHandler(IdsBindingSource_AddingNew);
            
            
            this.Load += OnFormLoad;
        }

        public virtual void OnFormLoad(object sender, EventArgs e)
        {
            if (IsInDesignMode || UIContext.UITesting) return;

            InitForm();

            //pokaz wybrany item
            //if (_startingItem != null && _startingItem.Id > 0)
                //_lastId = _startingItem.Id; //wczyta go z sesji

            if (NavigatorEnabled)
            {
                Navigator_LoadAndBind();

                if (NavigatorEnabled && CurrentItem.Id == 0)
                    IdsBindingSource.AddNew();
            }

            //if (_startingItem != null && _startingItem.Id == 0) //odpala dodanie nowego item`a
            //{
            //    if (NavigatorEnabled && CurrentItem.Id == 0)
            //        IdsBindingSource.AddNew();
            //    CurrentItem = _newAddedItem = _startingItem;
            //}

            MainBindingSrc.DataSource = CurrentItem;
            MainBindingSrc.ResetCurrentItem(); //odswiez binding
            binder.source = MainBindingSrc;

            //binduj dane jesli dostepne 
            if (CurrentItem != null)
            {
                BindControlsOnForm();
                //CurrentItem.EnableTracking(); //bajer, wlacz monitorowanie zmian w encjach
            }
        }

        private DialogResult AskDiscardChangesAndClose()
        {
            return MessageBox.Show("Czy jestes pewien ze chcesz zamknac formularz?", "Uwaga! Nie zapisano zmian.",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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


     

        protected bool IsValid
        {
            get
            {
                MainBindingSrc.EndEdit(); //aby odpalily wszystkie notifychanged
                return CurrentItem.IsValid();
                //&& ValidateChildren(); // nie wiem czemu to nie dziala juz !!!
            }
        }

        protected virtual void LoadAndBind()
        {
            
        }

        #region Metody musza byc przeciazone !!

        public IList<int> _idki = new List<int>();
        public BindingSource IdsBindingSource = new BindingSource();
        public BindingNavigator navigator = null;

        //private int _lastId = 0; //do nawigacji
        //protected Rozliczenie _startingItem = null; //od tego wystartuj - nowy, badz stary z wyszukiwania
        //protected Rozliczenie _newAddedItem = null; //nowy, sam sie dodaje, przekazuyjemy tylko starting

        public virtual void Navigator_LoadAndBind()
        {
            using (ITransaction tx = Session.BeginTransaction())
            {
                _idki = GetListOfIds();
                if (_idki.Count == 0) return;

                //_lastId = _lastId == -1 ? _idki.Last() : _lastId; //zaladuje ostatni Id`k lub I-szy z listy
                //_lastId = _lastId == 0 ? _idki.First() : _lastId;

                if(CurrentItem == null)
                    CurrentItem = Session.Load<Rozliczenie>(_idki.Last());

                tx.Commit();
            }

            //lista id`kow do nawgigacji
            IdsBindingSource.DataSource = _idki;
            IdsBindingSource.AllowNew = true;

            navigator.BindingSource = IdsBindingSource;

            //maintainPosition
            //_idki.Len.L.IndexOf(_lastId);
            IdsBindingSource.Position = _idki.Count - 1;
        }

        protected virtual void BindControlsOnForm()
        {
            throw new Exception("Must be overrided!");
        }

        #endregion


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

                EventPublisher.Publish(new RozliczenieSaved(CurrentItem), this);

                SuccessfullSave = true;
                LoadAndBind();
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
                    MoveItem(); //trzeba 'zejsc' z obecnego elemntu
                }
                catch (Exception e)
                {
                    log.Error("Wyjatek przy Delete.", e);
                    message = "Nie mozna usunac elementu, istnieje dowiazanie do niego.";

                    CreateSession(); //zawsze po wyjatku z NH, trzeba odtworzyc sesje
                }
            }

            LoadAndBind();
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


        protected void MoveItemClicked(object sender, EventArgs e)
        {
            //wykryj czy modyfikowany obiekt ?? tylko jak

            //if (SaveItem()) //jak jest zapisany i zwalidowany to idz dalej
            if (CurrentItem.IsValid())
            {
                MoveItem();
                //wyczyscic status - czy zapisany czy zbledem
            }
            else
            {
                IdsBindingSource.Position = _lastPosition;
                ShowErrorIfAny();    
            }
            

        }

        protected void MoveItem()
        {
            if (IdsBindingSource.Position < 0)
                return;

            int id = _idki[IdsBindingSource.Position];
            _lastPosition = id;

            //if (id == -1 && _newAddedItem != null)
            //    CurrentItem = _newAddedItem;
            //else
            //    CurrentItem = GetItem(id); //jesli 0, to tworzy nowy pusty

            CurrentItem = GetItem(id);

            MainBindingSrc.DataSource = CurrentItem;
            MainBindingSrc.ResetBindings(true);
            
            //IdsBindingSource.ResetBindings(false);

            ValidateChildren();
        }

        protected void NewItemClicked(object sender, EventArgs e)
        {
            //int id = -1;
            //_idki.Add(id);
            //IdsBindingSource.MoveLast();
            //this.navigator.AddNewItem.Enabled = false;
            //IdsBindingSource.MoveLast();

            int id = _idki[IdsBindingSource.Position];
            CurrentItem = GetItem(id);

            MainBindingSrc.DataSource = CurrentItem;
            MainBindingSrc.ResetBindings(true);

            //CurrentItem = GetItem(id);
            //MainBindingSrc.DataSource = CurrentItem;
            //this.navigator.AddNewItem.Enabled = false;
        }

        protected void IdsBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = -1;
        }
        //protected void IdsBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        //{
        //    //e.NewObject = -1;
        //    Rozliczenie r = new Rozliczenie();
        //    e.NewObject = r.Id;

        //    _idki.Add(-1);
        //    //_lastId = -1; //nawigacja przewinie na ostatnie elemnt

        //    CurrentItem = r;
        //    //_newAddedItem = r;

        //    //this.navigator.AddNewItem.Enabled = false;
        //    IdsBindingSource.MoveLast();

        //    MainBindingSrc.DataSource = CurrentItem;
        //    MainBindingSrc.MoveLast();
            
        //    //MoveItem();
        //    //MainBindingSrc.DataSource = CurrentItem;
        //    //IdsBindingSource.MoveLast();

        //    this.navigatorMoveLastItem.Click += new System.EventHandler(MoveItemClicked);
        //    this.navigatorMoveFirstItem.Click += new System.EventHandler(MoveItemClicked);
        //    this.navigatorMovePreviousItem.Click += new System.EventHandler(MoveItemClicked);
        //    this.navigatorMoveNextItem.Click += new System.EventHandler(MoveItemClicked);
        //    ////NewItemClicked
        //    this.navigatorAddNewItem.Click += new System.EventHandler(MoveItemClicked);
        //}

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

    //public class RozliczenieSaved
    //{
    //    public RozliczenieArgs() {}
    //    public RozliczenieArgs(Rozliczenie rozliczenie) { this.Rozliczenie = rozliczenie; }
    //    public Rozliczenie Rozliczenie { get; set; }
    //}
    public class RozliczenieSaved
    {
        public RozliczenieSaved(Rozliczenie roz) { this.Item = roz; }
        public Rozliczenie Item { get; set; }
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Kanc.Core;
using Kanc.Core.Entities;
using NHibernate;

namespace Kanc.UI.Forms
{
    public abstract class NavigationBaseFormSession<T> : BaseFormSessionGeneric<T>
         where T : class, IEntity, new()
    {
        public IList<int> _idki = new List<int>();
        public BindingSource IdsBindingSource = new BindingSource();
        public BindingNavigator navigator = new BindingNavigator();

        private int _lastId = 0; //do nawigacji
        protected T _startingItem = null; //od tego wystartuj - nowy, badz stary z wyszukiwania
        protected T _newAddedItem = null; //nowy, sam sie dodaje, przekazuyjemy tylko starting

        #region .CTORs

        public NavigationBaseFormSession()  : base() { Constructor(); }
        public NavigationBaseFormSession(ISession session) : base(session)  { Constructor(); }
        private void Constructor()
        {
            MainBindingSrc = new BindingSource(); //zeby nie sprawdzac wszedzie null`a
            this.Load += OnFormLoad;
            IdsBindingSource.AddingNew += new AddingNewEventHandler(IdsBindingSource_AddingNew);
        }

        #endregion

        private void NewItemSetDataSources()
        {
            //MainBindingSrc.AddNew();
            
            //
            this.navigator.AddNewItem.Enabled = false;
            //MainBindingSrc.DataSource = CurrentItem;
            //MainBindingSrc.MoveLast();
            IdsBindingSource.MoveLast();
        }

        public virtual void OnFormLoad(object sender, EventArgs e)
        {
            if (DesignMode) return;
            if (Context.IsTestingMode) return;

            //pokaz wybrany item
            if (_startingItem != null && _startingItem.Id > 0)
                _lastId = _startingItem.Id; //wczyta go z sesji
            
            LoadAndBind();

            if (_startingItem != null && _startingItem.Id == 0) //odpala dodanie nowego item`a
            {
                IdsBindingSource.AddNew();
                MainBindingSrc.DataSource = CurrentItem = _newAddedItem = _startingItem;
                //NewItemSetDataSources();
            }

            //binduj dane jesli dostepne 
            if (CurrentItem != null)
            {
                BindControls();
                //CurrentItem.EnableTracking(); //bajer, wlacz monitorowanie zmian w encjach
            }

            //if (_newAddedItem != null)
            //{
            //    this.navigator.AddNewItem.Enabled = false;
            //}
        }

        public override void General_LoadData()
        {
            using (ITransaction tx = Session.BeginTransaction())
            {
                _idki = GetListOfIds();
                if (_idki.Count == 0) return;

                _lastId = _lastId == -1 ? _idki.Last() : _lastId; //zaladuje ostatni Id`k lub I-szy z listy
                _lastId = _lastId == 0 ? _idki.First() : _lastId;
                
                CurrentItem = Session.Get<T>(_lastId);
                tx.Commit();
            }
        }

        protected override void General_BindData()
        {
            MainBindingSrc.DataSource = CurrentItem;

            //lista id`kow do nawgigacji
            IdsBindingSource.DataSource = _idki;
            IdsBindingSource.AllowNew = true;

            navigator.BindingSource = IdsBindingSource;

            //maintainPosition
            IdsBindingSource.Position = _idki.IndexOf(_lastId);
        }

        protected virtual void BindControls()
        {
            throw new Exception("Must be overrided!");
        }

        #region Navigation

        protected void MoveItemClicked(object sender, EventArgs e)
        {
            //wykryj czy modyfikowany obiekt ?? tylko jak

            //if (SaveItem()) //jak jest zapisany i zwalidowany to idz dalej
            if(CurrentItem.IsValid())
            {
                MoveItem();
                //wyczyscic status - czy zapisany czy zbledem
            }
                
        }

        protected override void MoveItem()
        {
            if(IdsBindingSource.Position < 0)
                return;

            int id = _idki[IdsBindingSource.Position];
            _lastId = id;

            if (id == -1 && _newAddedItem != null)
                CurrentItem = _newAddedItem;
            else
                CurrentItem = GetItem(id); //jesli 0, to tworzy nowy pusty

            MainBindingSrc.DataSource = CurrentItem;
            MainBindingSrc.ResetBindings(true);
            
            ValidateChildren();
        }

        private void IdsBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            T r = new T();
            e.NewObject = r.Id;

            _idki.Add(-1);
            _lastId = -1; //nawigacja przewinie na ostatnie elemnt

            //CurrentItem = r;
            _newAddedItem = r;
            NewItemSetDataSources();

            //MainBindingSrc.DataSource = CurrentItem;
            //IdsBindingSource.MoveLast();
        }

        #endregion

    }
}

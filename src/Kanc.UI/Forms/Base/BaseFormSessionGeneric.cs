using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Windows.Forms;
using Kanc.Core.Entities;
using Kanc.UI.Forms.Base;
using NHibernate;

namespace Kanc.UI.Forms
{
    public class BaseFormSessionGeneric<T> : BaseFormSession, ICurrentItem<T>
        where T : class, IEntity, new()
    {
        #region .CTORs

        public BaseFormSessionGeneric() : base() { }

        public BaseFormSessionGeneric(ISession session) : base(session) { }

        #endregion

        public bool SuccessfullSave = true;

        T _currentItem = null;
        public T CurrentItem
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

        protected virtual void LoadAndBind()
        {
            General_LoadData();
            General_BindData();

            MainBindingSrc.ResetCurrentItem(); //odswiez binding
            binder.source = MainBindingSrc;
        }

        #region Metody musza byc przeciazone !!

        public virtual void General_LoadData()
        {
            throw new NotImplementedException("Musi byc przeciazone!");
        }
        protected virtual void General_BindData()
        {
            throw new NotImplementedException("Musi byc przeciazone!");
        }

        protected virtual void MoveItem()
        {
            throw new NotImplementedException("Musi byc przeciazone!");
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

        protected T GetItem(int id)
        {
            T item = new T();
            if (id > 0)
            {
                using (ITransaction tx = Session.BeginTransaction())
                {
                    item = Session.Load<T>(id);
                    tx.Commit();
                }
            }
            return item;
        }

        protected IList<int> GetListOfIds()
        {
            string query = string.Format(@"select item.Id from {0} item", typeof(T).Name);

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
    }
}
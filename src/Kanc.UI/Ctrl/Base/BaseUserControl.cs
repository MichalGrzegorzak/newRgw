using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;
using Kanc.Core;
using Kanc.Core.Entities;
using Kanc.UI.Forms;
using NHibernate;
using NHibernate.Validator.Binding;

namespace Kanc.UI.Ctrl
{
    public interface ILoadable
    {
        void LoadData(Binder binder, bool option = false);

    }

    public partial class BaseUserControl : UserControl, ILoadable
    {
        public void ResetTabIndex()
        {
            foreach (Control control in this.Controls)
            {
                control.TabIndex = 9999;
            }
        }

        public BaseUserControl()
        {
            InitializeComponent();
            //
            if (DesignMode) return;
            this.Load += new EventHandler(BaseUserControl_Load);
        }

        void BaseUserControl_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;

            if (this.ParentForm is BaseFormSession)
                Session = (this.ParentForm as BaseFormSession).Session;
            if (this.ParentForm is BaseFormSessionRozlicz)
                Session = (this.ParentForm as BaseFormSessionRozlicz).Session;
        }

        public ISession Session { get; set; }
        public Binder Binder { get; set; }
        public Rozliczenie Rozliczenie
        {
            get { return Binder.Rozliczenie; }
        }

        //public void LoadData(Binder binder)
        //{
        //    LoadData(binder, false);
        //}

        public virtual void LoadData(Binder binder, bool option = false)
        {
            throw new NotImplementedException("This method must be overriden in child class!");
        }

        //public BindingSource Source { get; set; }
        //public T GetSourceEntity<T>() where T: Entity
        //{
        //    return Source.DataSource as T;
        //}

        public void Disabled()
        {
            foreach (Control c in Controls)
                c.Enabled = false;
        }
        
    }

    

    //public class BaseUserControlTyped<TEntity> : BaseUserControl, ILoadable<TEntity> where TEntity : class
    //{
    //    public virtual void LoadData(Binder<TEntity> binder)
    //    {
    //        throw new NotImplementedException("This method must be overriden in child class!");
    //    }
    //}
    

    

}

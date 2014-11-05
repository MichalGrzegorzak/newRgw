using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using NHibernate;
using System;

namespace Kanc.UI.Tests
{
    /// <summary>
    /// Bazowa, raczej nie uzywac
    /// </summary>
    public class BaseForm : Form
    {
        public BindingSource MainBindingSrc { get; set; }

        #region fix do kolejnosci zamykania form

        private IList<Form> _BaseForms = new List<Form>();
        protected override void Dispose(bool disposing)
        {
            for (int i = 0; i < _BaseForms.Count; i++)
            {
                _BaseForms[i].Dispose();
            }
            base.Dispose(disposing);
        }

        #endregion

        protected virtual void ShowForm<F>(bool mdi = false, BindingSource source = null) where F : BaseForm, new()
        {
            F frm = new F();
            _BaseForms.Add(frm);

            if (mdi) frm.MdiParent = this;
            if (source != null)
                frm.MainBindingSrc = source;

            frm.Show();
        }

        protected virtual void ShowForm<F>(BindingSource source) where F : BaseForm, new()
        {
            ShowForm<F>(false, source);
        }

 

        //protected void LoadDataOnAllControls()
        //{
        //    if (MainBindingSrc == null) throw new ArgumentException("Nie ustawiono MainBindingSouce!");

        //    var loadableCtrls = (from Control c in this.Controls
        //                         where c is ILoadable
        //                         select (ILoadable)c).ToList();

        //    loadableCtrls.ForEach(x => x.LoadData(MainBindingSrc));
        //}
    }

}


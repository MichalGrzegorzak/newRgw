using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Kanc.UI.Ctrl;
using NHibernate;
using Kanc.Core;
using System;
using NHibernate.Validator.Binding;
using log4net;
using Binder = Kanc.Core.Binder;

namespace Kanc.UI.Forms
{
    /// <summary>
    /// Bazowa, raczej nie uzywac
    /// </summary>
    public class BaseForm : Form
    {
        protected static ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public BindingSource MainBindingSrc { get; set; }
        public ErrorProvider errorProvider1 = null;
        protected Binder binder;

        private IContainer components;
        

        

        public BaseForm()
        {
            components = new Container();
            errorProvider1 = new ErrorProvider(components);
            errorProvider1.ContainerControl = this;
            
            KeyPreview = true;

            ResetTabIndex();

            Debug.WriteLine("TRYB: " + DesignMode);
            if(DesignMode || Context.SessionFactory == null)
                return;
            
            MainBindingSrc = new BindingSource(); //zeby nie sprawdzac wszedzie null`a
            binder = new Binder(MainBindingSrc, new SmartViewValidator(errorProvider1));
        }

        protected override void OnResize(EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        #region fix do kolejnosci zamykania form

        protected IList<Form> _openedForms = new List<Form>();
        protected override void Dispose(bool disposing)
        {
            for (int i = 0; i < _openedForms.Count; i++)
            {
                _openedForms[i].Dispose();
            }
            //if (tabForms.SelectedIndex > 0)
            //    tabForms.SelectedIndex--;
            base.Dispose(disposing);
        }

        #endregion

        protected virtual F ShowFormAsMdi<F>(bool dontDisplay = false, BindingSource source = null) where F : BaseForm, new()
        {
            if (!this.IsMdiContainer)
            {
                //MainFormBase mdi = this.MdiParent as MainFormBase;
                return UIContext.MainForm.ShowFormAsMdi<F>(dontDisplay, source);
            }

            F frm = new F();

            _openedForms.Add(frm);
            frm.MdiParent = this;
            
            if (source != null)
                frm.MainBindingSrc = source;

            if (!dontDisplay)
                Display();

            return frm;
        }

        protected virtual F ShowForm<F>(BindingSource source = null) where F : BaseForm, new()
        {
            F frm = new F();
            _openedForms.Add(frm);

            if (source != null)
                frm.MainBindingSrc = source;

            frm.WindowState = FormWindowState.Maximized;
            frm.MinimizeBox = false;
            frm.MaximizeBox = false;
            frm.AutoScaleMode = AutoScaleMode.Inherit;
            frm.Show();
            return frm;
        }

        //public Point ScrollPosition;

        public void Display()
        {
            WindowState = FormWindowState.Maximized;
            MinimizeBox = false;
            MaximizeBox = false;
            AutoScaleMode = AutoScaleMode.Inherit;
            Size s = MdiParent.DesktopBounds.Size;
            Size ss = new Size(s.Width + 1, s.Height + 1);
            MinimumSize = MaximumSize = Size = ss;
            Show();
            

            //fucking HACK, for scrollbar
            var x = MdiParent.Size;
            MdiParent.Size = new Size(x.Width + 1, x.Height);
            MdiParent.Size = new Size(x.Width - 1, x.Height);
            //ScrollPosition = AutoScrollPosition;
            //WindowState = FormWindowState.Normal; //niby to mialo pomoc, ale nic z tego
            //WindowState = FormWindowState.Maximized;


            //sype sie - can`t create a handle ??
            //try
            //{ frm.Focus(); }
            //catch (Exception) {}
        }

        protected void LoadDataOnAllControls()
        {
            if (MainBindingSrc == null) throw new ArgumentException("Nie ustawiono MainBindingSouce!");

            var loadableCtrls = (from Control c in this.Controls
                                 where c is ILoadable
                                 select (ILoadable)c).ToList();

            binder.source = MainBindingSrc;
            loadableCtrls.ForEach(x => x.LoadData(binder));
        }

        protected void ResetTabIndex()
        {
            foreach (Control control in this.Controls)
            {
                control.TabIndex = 9999;
            }
        }
    }
}


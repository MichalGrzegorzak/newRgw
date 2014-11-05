using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Kanc.Core;
using Kanc.Core.Entities;
using Kanc.Core.Features;
using NHibernate;
using log4net;

namespace Kanc.UI.Forms.Base
{
    public partial class MainFormBase : Form
    {
        protected static ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        protected IList<Form> _BaseForms = new List<Form>();
        protected TabControl _tabForm = null;
        protected int _lastSelectedTabIndex;

        protected override void Dispose(bool disposing)
        {
            for (int i = 0; i < _BaseForms.Count; i++)
            {
                _BaseForms[i].Dispose();
            }
            //if (_tabForm.SelectedIndex > 0)
            //    _tabForm.SelectedIndex--;
            base.Dispose(disposing);
        }

        public virtual F ShowFormAsMdi<F>(bool dontDisplay = false, BindingSource source = null) where F : BaseForm, new()
        {
            if (!this.IsMdiContainer)
            {
                //BaseForm mdi = this.MdiParent as BaseForm;
                return UIContext.MainForm.ShowFormAsMdi<F>(dontDisplay, source);
            }

            F frm = new F();
            _BaseForms.Add(frm);
            frm.MdiParent = this;

            if (source != null)
                frm.MainBindingSrc = source;

            if (!dontDisplay)
                frm.Display();

            return frm;
        }

        public virtual F ShowForm<F>(BindingSource source = null) where F : BaseForm, new()
        {
            F frm = new F();
            _BaseForms.Add(frm);

            if (source != null)
                frm.MainBindingSrc = source;

            frm.WindowState = FormWindowState.Maximized;
            frm.MinimizeBox = false;
            frm.MaximizeBox = false;
            frm.AutoScaleMode = AutoScaleMode.Inherit;
            frm.Show();
            return frm;
        }

        #region Tabs functionality

        private const int WM_SETREDRAW = 11;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, Int32 wMsg, bool wParam, Int32 lParam);

        protected override void OnLoad(EventArgs e)
        {
            if (!DesignMode)
            {
                MdiScroller.Install(this);

                //nie dziala prawdopodobnie przez PINVOKE NA KOLKO MYSZKI
                //foreach (Form ff in this.MdiChildren)
                //{
                //    (ff as BaseForm).Scroll += MainForm_Scroll;
                //}
                //this.Scroll += MainForm_Scroll;
            }
            base.OnLoad(e);
        }

        //protected void MainForm_Scroll(object sender, ScrollEventArgs e)
        //{
        //    (ActiveMdiChild as BaseForm).ScrollPosition = AutoScrollPosition;
        //}

        protected void tabForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((_tabForm.SelectedTab != null) && (_tabForm.SelectedTab.Tag != null))
            {
                SendMessage(this.Handle, WM_SETREDRAW, false, 0);
                (_tabForm.SelectedTab.Tag as Form).Select();
                SendMessage(this.Handle, WM_SETREDRAW, true, 0);
                this.Refresh();
            }
        }

        protected void MainForm_MdiChildActivate(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                _tabForm.Visible = false; // If no any child form, hide tabControl
            }
            else
            {
                this.ActiveMdiChild.WindowState = FormWindowState.Maximized; // Child form always maximized
                // If child form is new and no has tabPage, create new tabPage
                if (this.ActiveMdiChild.Tag == null)
                {
                    // Add a tabPage to tabControl with child form caption
                    TabPage tp = new TabPage(this.ActiveMdiChild.Text);
                    tp.Tag = this.ActiveMdiChild;
                    tp.Parent = _tabForm;
                    _tabForm.SelectedTab = tp;

                    this.ActiveMdiChild.Tag = tp;
                    this.ActiveMdiChild.FormClosed += new FormClosedEventHandler(ActiveMdiChild_FormClosed);
                    //(this.ActiveMdiChild as BaseForm).ScrollPosition = AutoScrollPosition;
                }

                if (!_tabForm.Visible)
                    _tabForm.Visible = true;

                this.ActiveMdiChild.Focus();
                _lastSelectedTabIndex = _tabForm.SelectedIndex;
            }

        }

        // If child form closed, remove tabPage
        protected void ActiveMdiChild_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((sender as Form).Tag as TabPage).Dispose();
        }
        #endregion


        #region Keys pressed handling

        enum MsgCodes
        {
            KeyDown = 0x100,
            KeyUp = 0x101,
            AltKeyDown = 0x104,
            AltKeyUp = 0x105
        }
        MsgCodes[] ExaminedKeyActions = (MsgCodes[])Enum.GetValues(typeof(MsgCodes));

        /// <summary>Trap any keypress before child controls get hold of them</summary>
        /// <returns>True if the keypress is handled</returns>
        protected override bool ProcessKeyPreview(ref Message m)
        {
            if (_tabForm == null)
                return false;

            //for debugging only
            MsgCodes MsgCode = (MsgCodes)m.Msg;
            Keys Key = (Keys)((int)(m.WParam)) | Control.ModifierKeys;
            if (Array.IndexOf(ExaminedKeyActions, MsgCode) >= 0)
            {
                Debug.WriteLine(string.Concat(MsgCode, " ", Key));
            }

            if ((m.Msg == 0x100) || (m.Msg == 0x104))
            {
                KeyEventArgs e = new KeyEventArgs(((Keys)((int)(m.WParam))) | Control.ModifierKeys);
                TrappedKeyDown(e);
                if (e.Handled)
                {
                    Debug.WriteLine("Trapped");
                    return true;
                }
            }

            return base.ProcessKeyPreview(ref m);
        }

        private void TrappedKeyDown(KeyEventArgs e)
        {
            if (_tabForm == null)
                return;

            if (e.Alt)
            {
                int max = _tabForm.TabCount;
                int curr = _tabForm.SelectedIndex + 1;

                if (e.KeyCode == Keys.Right)
                {
                    if (curr < max)
                        _tabForm.SelectedIndex++;
                    if (curr == max)
                        _tabForm.SelectedIndex = 0;
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.Left)
                {
                    if (curr > 0)
                        _tabForm.SelectedIndex--;
                    if (curr == 1)
                        _tabForm.SelectedIndex = max - 1;
                    e.Handled = true;
                }
            }
        } 
        #endregion


        protected void PutTestDataToDB()
        {
            GenerateDBData gen = new GenerateDBData();
            var list = gen.GenerateList(10);

            foreach (Rozliczenie rozliczenie in list)
            {
                using (var session = Context.SessionFactory.OpenSession())
                using (ITransaction tx = session.BeginTransaction())
                {
                    session.SaveOrUpdate(rozliczenie);
                    session.Flush();
                    tx.Commit();
                }
            }
        }

        protected void CloaseAllBaseForms()
        {
            foreach (Form mdiChild in MdiChildren)
            {
                mdiChild.Close();
            }
        }
    }
}

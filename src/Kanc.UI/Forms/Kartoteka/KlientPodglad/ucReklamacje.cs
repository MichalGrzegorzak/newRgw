using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Kanc.Core;
using Kanc.UI.Forms.Modalne;

namespace Kanc.UI.Ctrl
{
    public partial class ucReklamacje : BaseUserControl
    {
        public ucReklamacje()
        {
            InitializeComponent();
        }

        public override void LoadData(Binder binder, bool option = false)
        {
            //nie ma co podpinac
            //Session = binder.S
            Binder = binder;
        }

        private void btnPiszReklamacje_Click(object sender, EventArgs e)
        {
            // otworz worda & wklej bookmarki
        }

        private void btnReklamator_Click(object sender, EventArgs e)
        {
            //Contract.Requires<ArgumentNullException>(Session != null);
            Contract.Requires<ArgumentNullException>(Binder.Rozliczenie != null);

            //otworz nowa formatke - REKLAMATOR
            FrmReklamator frm = new FrmReklamator(Binder.Rozliczenie);
            frm.ShowDialog(this.ParentForm);
            //frmDodajBank.FormClosing += new FormClosingEventHandler(form_FormClosing); //przypisz nam spowrotem obiekt z formatki
        }

        private void btnInformator_Click(object sender, EventArgs e)
        {
            //Contract.Requires<ArgumentNullException>(Session != null);
            Contract.Requires<ArgumentNullException>(Binder.Rozliczenie != null);

            FrmInformator frm = new FrmInformator(Binder.Rozliczenie);
            frm.ShowDialog(this.ParentForm);
        }

        //void form_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    FrmDodajBank form = (FrmDodajBank) sender;
        //    //((Rozliczenie)Source.DataSource).Konto = form.CurrentItem;
        //    //Source.ResetBindings(true); //odswiez binding
        //}
    }
}

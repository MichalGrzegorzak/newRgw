using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Kanc.Core;
using Kanc.Core.Entities;
using NHibernate;
using NHibernate.Validator.Binding;

namespace Kanc.UI.Forms
{
    public partial class EdycjaKlienta : BaseFormSessionRozlicz
    {
        public EdycjaKlienta() : base()
        {
            InitializeComponent();
        }

        public EdycjaKlienta(ISession session, Rozliczenie roz) : base(session, roz)
        {
            InitializeComponent();
        }

        protected override void BindControlsOnForm()
        {
            _ucEdycjaKlient1.LoadData(binder);
        }

        protected override void InitForm()
        {
 	        this.DoubleBuffered = true; 

            InitNavigator(true);
        }

        private void InitNavigator(bool visible)
        {
            navigator = bindingNavigator1;
            navigator.Visible = visible;
            navigator.BindingSource = IdsBindingSource;

            if (!visible)
                return;

            if (NavigatorEnabled)
            {
                this.bindingNavigatorMoveLastItem.Click += new System.EventHandler(MoveItemClicked);
                this.bindingNavigatorMoveFirstItem.Click += new System.EventHandler(MoveItemClicked);
                this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(MoveItemClicked);
                this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(MoveItemClicked);
                //NewItemClicked
                this.bindingNavigatorAddNewItem.Click += new System.EventHandler(NewItemClicked);
            }
        }


        //private void button1_Click(object sender, EventArgs e)
        //{
        //    SaveItem(false);
        //}

        private void btnEuEwr_Click(object sender, EventArgs e)
        {
            ShowModalForm<FrmEuEwr>();
        }

        private void btnPodatek_Click(object sender, EventArgs e)
        {
            ShowModalForm<FrmPodatekStrona>();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            SaveItem(true);
        }

        
    }
}

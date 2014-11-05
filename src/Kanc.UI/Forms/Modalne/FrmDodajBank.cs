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
    public partial class FrmDodajBank : FrmDodajBankChild
    {
        #region .CTORs

        public FrmDodajBank()
        {
            InitializeComponent();
            Init();
        }

        public FrmDodajBank(ISession session, Bank bnk) : base(session)
        {
            _startingItem = bnk;
            
            InitializeComponent();
            Init();
        }

        #endregion

        private void Init()
        {
            //podepnij navigator
            InitNavigator();

            //errorProvider1.DataSource = MainBindingSrc;
            binder = new Binder(MainBindingSrc, new SmartViewValidator(errorProvider1));
        }

        private bool IsNewItemAdded
        {
            get { return _startingItem != null && _startingItem.Id == 0; }
        }

        private void InitNavigator()
        {
            if (IsNewItemAdded)
            {
                this.saveToolStripButton.BackColor = Color.Red;
                saveToolStripButton.Invalidate();
                this.bindingNavigatorAddNewItem.BackColor = Color.Green;
                bindingNavigatorAddNewItem.Invalidate();
            }

            navigator = bindingNavigator1;

            this.bindingNavigatorMoveLastItem.Click += new EventHandler(MoveItemClicked);
            this.bindingNavigatorMoveFirstItem.Click += new EventHandler(MoveItemClicked);
            this.bindingNavigatorAddNewItem.Click += new EventHandler(MoveItemClicked);
            this.bindingNavigatorMovePreviousItem.Click += new EventHandler(MoveItemClicked);
            this.bindingNavigatorMoveNextItem.Click += new EventHandler(MoveItemClicked);
        }

        protected override void BindControls()
        {
            binder.Bind(idTextBox, (Bank bb) => bb.Id);
            binder.Bind(blzTextBox, (Bank bb) => bb.Blz).ValidateWithEvent();
            binder.Bind(nazwaTextBox, (Bank bb) => bb.Nazwa).ValidateWithEvent();
            binder.Bind(swiftTextBox, (Bank bb) => bb.Swift).ValidateWithEvent();
            binder.Bind(adresTextBox, (Bank bb) => bb.Adres).ValidateWithEvent();
            binder.Bind(krajKrajeDDL, (Bank bb) => bb.Kraj, "SetValue");
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DeleteItem();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveItem();
            this.navigator.AddNewItem.Enabled = true;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
    }

    public class FrmDodajBankChild : NavigationBaseFormSession<Bank>
    {
        public FrmDodajBankChild() {}
        public FrmDodajBankChild(ISession session) : base(session) {}
    }
}

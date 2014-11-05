using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Kanc.Commons;
using Kanc.MVP.Controllers;
using Kanc.MVP.Domain;
using Kanc.MVP.Engine.Tasks;
using Kanc.MVP.Engine.View;
using MVCSharp.Winforms;

namespace Kanc.MVP.Presentation.Client
{
    [ViewEx(typeof(TaskEditOrder), TaskEditOrder.EditOrder, "New")]
    public partial class EditOrder : ucEditOrder, IViewEditOrder
    {
        public EditOrder()
        {
            InitializeComponent();
        }

        public int Id
        {
            get { return txbId.Text.Parse<int>(); }
            set { txbId.Text = value.ToString(); }
        }
        public string Desc
        {
            get { return txbDesc.Text; }
            set { txbDesc.Text = value; }
        }
        public string Owner
        {
            get { return txbOwner.Text; }
            set { txbOwner.Text = value; }
        }
        public string Message
        {
            get { return lblMessage.Text; }
            set { lblMessage.Text = value; }
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            Controller.Save();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Controller.Cancel();
        }

        //public Order CurrentOrder
        //{
        //    get { throw new NotImplementedException(); }
        //}

    }

    public class ucEditOrder : WinUserControlView<EditOrderController>
    { }
}

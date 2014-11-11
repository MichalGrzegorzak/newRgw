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
using Kanc.MVP.Presentation.Customers;
using MVCSharp.Winforms;

namespace Kanc.MVP.Presentation.Client
{
    [ViewEx(typeof(MainTask), MainTask.EditOrder, "New")]
    public partial class EditOrderView : ucEditOrder, IEditOrderView
    {
        public EditOrderView()
        {
            InitializeComponent();

            txbId.Validating += ValidateInput;
            txbDesc.Validating += ValidateInput;
            txbOwner.Validating += ValidateInput;
        }

        public int Id
        {
            get { return txbId.Text.Trim().ParseSafe<int>(); }
            set { txbId.Text = value.ToString(); }
        }
        public string Desc
        {
            get { return txbDesc.Text.Trim(); }
            set { txbDesc.Text = value; }
        }
        public string Owner
        {
            get { return txbOwner.Text.Trim(); }
            set { txbOwner.Text = value; }
        }
        public string Message
        {
            get { return lblMessage.Text.Trim(); }
            set { lblMessage.Text = value; }
        }

        public void Close()
        {
            this.Hide();
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            Controller.Next();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Controller.Previous();
            
        }

        //public Order CurrentOrder
        //{
        //    get { throw new NotImplementedException(); }
        //}

        private void ValidateInput(object sender, CancelEventArgs e)
        {
            Control ctrl = (Control)sender;

            errorProvider1.SetError(ctrl, ""); //clear ctrl previous error

            if (ctrl.Name == "txbId")
            {
                if (ctrl.Text.Trim().Length == 0)
                    errorProvider1.SetError(ctrl, "Id is Required");
            }

            //MessageBox.Show("You have Input Errors, Please Correct or", "Test ErrProvider", MessageBoxButtons.OK);
            //{
            //    if (ctrl.Text.Trim().Length == 0)
            //        this.errorProvider1.SetError(ctrl, "Email is Required");
            //    else if (emailRegx.IsMatch(ctrl.Text) == false)
            //        this.errorProvider1.SetError(ctrl, "Email format is incorrect");
            //     else
            //        this.errorProvider1.SetError(ctrl, "");
            //}
            //if (ctrl.Name == "txtconfirm")
            //{
            //   if (ctrl.Text.Trim().Length == 0)
            //       this.errorProvider1.SetError(ctrl, "Password 
            //               Confirm is Required");
            //   else if (string.Compare(this.txtpassword.Text, ctrl.Text) != 0)
            //       this.errorProvider1.SetError(ctrl, "Passwords 
            //           do not Match, Please Correct");
            //   else
            //       this.errorProvider1.SetError(ctrl, "");
            //}
        }

    }

    public class ucEditOrder : MyBaseControlView<EditOrderController>
    { }
}

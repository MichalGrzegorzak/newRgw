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
    [ViewEx(typeof(MainTask), MainTask.NewCustomer, "New")]
    public partial class NewCustomerView : ucNewCustomer, INewCustomersView
    {
        public NewCustomerView()
        {
            
            InitializeComponent();

            //txbId.Validating += ValidateInput;
        }

        //public int Id
        //{
        //    get { return txbId.Text.Trim().ParseSafe<int>(); }
        //    set { txbId.Text = value.ToString(); }
        //}

        public string Name
        {
            get { return txbName.Text.Trim(); }
            set { txbName.Text = value; }
        }
        public string Message
        {
            get { return lblMessage.Text.Trim(); }
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

        private void ValidateInput(object sender, CancelEventArgs e)
        {
            Control ctrl = (Control)sender;

            errorProvider1.SetError(ctrl, ""); //clear ctrl previous error

            //if (ctrl.Name == "txbId")
            //{
            //    if (ctrl.Text.Trim().Length == 0)
            //        errorProvider1.SetError(ctrl, "Id is Required");
            //}

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

    public class ucNewCustomer : WinUserControlView<NewCustomerController>
    { }
}

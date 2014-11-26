using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Kanc.MVP.Controllers.Order;
using Kanc.MVP.Engine.Tasks;
using Kanc.MVP.Engine.Validator;
using Kanc.MVP.Engine.View;
using Kanc.MVP.Presentation.Customers;
using Utils.Features.TypesParsing;

namespace Kanc.MVP.Presentation.Order
{
    [ViewEx(typeof(MainTask), MainTask.EditOrder, "New")]
    public partial class EditOrderView : ucEditOrder, IEditOrderView
    {
        public EditOrderView()
        {
            InitializeComponent();

            txbId.Enabled = false;

            //WALIDACJA
            errorProvider = errorProvider1;

            //aby kontroler mogl uruchomic SetError na errorProviderze, bez referencji do kontrolki
            availableControls.AddRange(ControlHelper.GetAll<TextBox>(this).ToList());
            availableControls.ForEach(x => x.Validating += ValidateInput);
            //txbId.Validating += ValidateInput;
            //txbRok.Validating += ValidateInput;
            //txbOwner.Validating += ValidateInput;

            //txbUrodz.RequireValidEntry = false; //moze wyjsc z kontrolki
            //txbUrodz.InvalidDateEntered += txbUrodz_InvalidDateEntered;
        }

        public int Id
        {
            get { return txbId.Text.Trim().ParseSafe<int>(); }
            set { txbId.Text = value.ToString(); }
        }
        public int Rok
        {
            get { return txbRok.Text.Trim().ParseSafe<int>(); }
            set { txbRok.Text = value.ToString(); }
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

        public override void Activate(bool activate)
        {
            Controller.ViewActivated();
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

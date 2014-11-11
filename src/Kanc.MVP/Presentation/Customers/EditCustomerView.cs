using System;
using System.ComponentModel;
using System.Linq;
using System.Management.Instrumentation;
using System.Windows.Forms;
using System.Xml.Schema;
using Kanc.Commons;
using Kanc.MVP.Controllers;
using Kanc.MVP.Engine.Tasks;
using Kanc.MVP.Engine.View;
using MVCSharp.Core.Views;
using MVCSharp.Winforms;

namespace Kanc.MVP.Presentation.Customers
{
    [ViewEx(typeof(MainTask), MainTask.EditCustomer, "New")]
    [ViewEx(typeof(MainTask), MainTask.NewCustomer, "New")]
    public partial class EditCustomerView : ucEditCustomer, IBaseEditCustomersView
    {
        private BasicValidator<EditCustomerView> validatorHlp = null;

        public EditCustomerView()
        {
            InitializeComponent();
            txbId.Enabled = false;

            validatorHlp = new BasicValidator<EditCustomerView>(this, errorProvider1);
            validatorHlp.For(x=>x.Name).IsRequired();
            validatorHlp.For(x=>x.Age).IsRequired().IsCorrectAge();
            //validatorHlp.For("txbName", "Name").IsRequired();
            //validatorHlp.For("txbAge", "Age").IsRequired().IsCorrectAge();

            ControlHelper.GetAll<TextBox>(this).ToList()
                .ForEach(x=> x.Validating += ValidateInput);
            //txbName.Validating += ValidateInput;
            //txbAge.Validating += ValidateInput;
        }

        public override void Activate(bool activate)
        {
            Controller.ViewActivated();
        }

        public bool IsNew
        {
            get { return Id > 0; }
        }

        public int Id
        {
            get { return txbId.Text.Trim().ParseSafe<int>(); }
            set { txbId.Text = value.ToString(); }
        }
        public string NazwiskoPl
        {
            get { return txbName.Text.Trim(); }
            set { txbName.Text = value; }
        }
        public int Age
        {
            get { return txbAge.Text.Trim().ParseSafe<int>(); }
            set { txbAge.Text = value.ToString(); }
        }
        public string Message
        {
            get { return lblMessage.Text.Trim(); }
            set { lblMessage.Text = value; }
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            Controller.Next();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Controller.Previous();
        }

        private void ValidateInput(object sender, CancelEventArgs e)
        {
            Control ctrl = (Control)sender;
            errorProvider1.SetError(ctrl, ""); //clear ctrl previous error

            validatorHlp.Validate(ctrl);

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

    public class ucEditCustomer : WinUserControlView<EditCustomerController>
    { }
}

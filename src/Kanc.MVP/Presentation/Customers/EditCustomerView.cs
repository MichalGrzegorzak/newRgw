using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Management.Instrumentation;
using System.Windows.Forms;
using System.Xml.Schema;
using Kanc.MVP.Controllers.Customer;
using Kanc.MVP.Domain;
using Kanc.MVP.Engine.Tasks;
using Kanc.MVP.Engine.Validator;
using Kanc.MVP.Engine.View;
using MVCSharp.Core.Views;
using MVCSharp.Winforms;
using Utils.Features.TypesParsing;

namespace Kanc.MVP.Presentation.Customers
{
    [ViewEx(typeof(MainTask), MainTask.EditCustomer, "New")]
    [ViewEx(typeof(MainTask), MainTask.NewCustomer, "New")]
    public partial class EditCustomerView : ucEditCustomer, IBaseEditCustomersView
    {
        public EditCustomerView()
        {
            InitializeComponent();

            txbId.Enabled = false;

            //WALIDACJA
            base.errorProvider = errorProvider1;

            //aby kontroler mogl uruchomic SetError na errorProviderze, bez referencji do kontrolki
            availableControls.AddRange(ControlHelper.GetAll<TextBox>(this).ToList()); 
            availableControls.ForEach(x=> x.Validating += ValidateInput);
        }

        public override void Activate(bool activate)
        {
            Controller.ViewActivated();
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

        string IMyBaseView.Message
        {
            get { return lblMessage.Text.Trim(); }
            set { lblMessage.Text = value; }
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            ValidateChildren(); //odpala validacje dla kazdej kontrolki
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

            string message = Controller.Validate(ctrl);
            if(message == null) 
                return;
            
            errorProvider1.SetError(ctrl, message);

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

    public class ucEditCustomer : MyBaseControlView<EditCustomerController>
    { }
}

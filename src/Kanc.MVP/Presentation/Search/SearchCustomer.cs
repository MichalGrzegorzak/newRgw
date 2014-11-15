using System;
using System.Collections.Generic;
using Kanc.MVP.Controllers.Customer;
using Kanc.MVP.Controls;
using Kanc.MVP.Domain;
using Kanc.MVP.Engine.Tasks;
using Kanc.MVP.Engine.View;
using MVCSharp.Winforms;

namespace Kanc.MVP.Presentation.Search
{
    //[ViewEx(typeof(MainTask), MainTask.SearchCustomer, "New")]
    [ViewEx(typeof(SearchTask), SearchTask.SearchCustomer, "New")]
    public partial class SearchCustomer : WinUserControlView_For_MailController, ISearchCustomer
    {
        public SearchCustomer()
        {
            InitializeComponent();
        }

        public event EventHandler CloseTriggered;

        public void Close()
        {
            if(CloseTriggered != null)
                CloseTriggered.Invoke(this, null);
        }

        public Domain.Order CurrentOrder
        {
            get
            {
                return gridOrders.CurrentRow == null ? null :
                       gridOrders.CurrentRow.DataBoundItem as Domain.Order;
            }
        }

        public void SetCustomerOrders(IList<Domain.Order> orders)
        {
            gridOrders.CurrentCellChanged -= gridOrders_CurrentCellChanged;

            gridOrders.DataSource = null; //otherwise grid not refreshes
            gridOrders.DataSource = orders;

            gridOrders.CurrentCellChanged += gridOrders_CurrentCellChanged;
        }

        public void SetCustomers(IList<Customer> customers)
        {
            //cmbUsers.DataSource = new BindingSource(customers, null);
            //cmbUsers.DisplayMember = "Value";
            //cmbUsers.ValueMember = "Key";

            cmbUsers.Items.Clear();

            foreach (Customer c in customers)
            {
                var item = new ComboboxItem() { Text = c.Name, Value = c.Name };
                cmbUsers.Items.Add(item);
            }

            cmbUsers.SelectedIndex = 0;
        }

        public void RefreshView()
        {
            btnNewOrder.Enabled = (SelectedCustomerIndex > 0);
        }

        public int SelectedCustomerIndex
        {
	        get { return cmbUsers.SelectedIndex; }
	        //set { cmbUsers.SelectedItem = value; }
        }

        public string Nazwisko
        {
            get { return nameTextBox.Text; }
            set { nameTextBox.Text = value; }
        }

        public string Message
        {
            get { return errLabel.Text; }
            set { errLabel.Text = value; }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Controller.Search();
            RefreshView();
        }

        private void cmbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Controller.CurrentCustomerChanged();
        }

        private void gridOrders_CurrentCellChanged(object sender, EventArgs e)
        {
            Controller.CurrentOrderChanged();
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            Controller.NewOrder();
        }

        private void gridOrders_CellDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            Controller.CurrentOrderChanged();
        }

    }

    public class WinUserControlView_For_MailController : WinUserControlView<SearchCustomerController>
    { }
}

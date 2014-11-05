using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Kanc.MVP.Controllers;
using Kanc.MVP.Domain;
using Kanc.MVP.Engine.Tasks;
using Kanc.MVP.Engine.View;
using MVCSharp.Winforms;

namespace Kanc.MVP.Presentation.Client
{
    [ViewEx(typeof(MainTask), MainTask.SearchCustomer, "New")]
    public partial class ClientSearch : WinUserControlView_For_MailController, IClientSearch
    {
        public bool EventsAllowed { get; set; }

        public ClientSearch()
        {
            InitializeComponent();
        }

        public Order CurrentOrder
        {
            get
            {
                return gridOrders.CurrentRow == null ? null :
                       gridOrders.CurrentRow.DataBoundItem as Order;
            }
        }

        public void SetCustomerOrders(IList<Order> orders)
        {
            gridOrders.CurrentCellChanged -= gridOrders_CurrentCellChanged;

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
        }

        private void cmbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (!EventsAllowed) return;

            Controller.CurrentCustomerChanged();
        }

        private void gridOrders_CurrentCellChanged(object sender, EventArgs e)
        {
            //if (!EventsAllowed) return;

            Controller.CurrentOrderChanged();
        }

    }

    public class WinUserControlView_For_MailController : WinUserControlView<CustomerSearchController>
    { }

    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}

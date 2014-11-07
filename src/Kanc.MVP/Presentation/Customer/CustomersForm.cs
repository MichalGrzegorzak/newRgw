using System;
using System.Collections;
using System.Collections.Generic;
using Kanc.MVP.Controllers;
using Kanc.MVP.Domain;
using Kanc.MVP.Engine.Tasks;
using Kanc.MVP.Engine.View;
using MVCSharp.Core.Configuration.Views;
using MVCSharp.Winforms;

namespace Kanc.MVP.Presentation.Client
{
    //[View(typeof(MainTask), MainTask.Customers)]
    [ViewEx(typeof(MainTask), MainTask.Customers, "New")]
    public partial class CustomersForm : WinFormViewForCustomersController, ICustomersView
    {
        public CustomersForm()
        {
            InitializeComponent();
        }

        public void SetCustomersList(List<Customer> customers)
        {
            customersGridView.DataSource = customers;
        }

        public Customer CurrentCustomer
        {
            get { return customersGridView.CurrentRow == null ? null :
                         customersGridView.CurrentRow.DataBoundItem as Customer;}
            set { customersGridView.CurrentCell = customersGridView.Rows[
               (customersGridView.DataSource as IList).IndexOf(value)].Cells[0];}
        }

        private void customersGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            Controller.CurrentCustomerChanged();
        }

        private void showOrdersButton_Click(object sender, EventArgs e)
        {
            Controller.ShowOrders();
        }
    }

    // This intermediate class is used as a workaround for the bug
    // in the VS form designer when inheriting a generic form class.
    public class WinFormViewForCustomersController : WinFormView<CustomerController>
    { }
}
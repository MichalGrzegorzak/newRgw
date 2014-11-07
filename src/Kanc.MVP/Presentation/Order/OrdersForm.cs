using System;
using System.Collections.Generic;
using Kanc.MVP.Controllers;
using Kanc.MVP.Domain;
using Kanc.MVP.Engine.Tasks;
using Kanc.MVP.Engine.View;
using MVCSharp.Core.Configuration.Views;
using MVCSharp.Winforms;

namespace Kanc.MVP.Presentation.Client
{
    //[View(typeof(MainTask), MainTask.Orders)]
    [ViewEx(typeof(EditOrderTask), EditOrderTask.EditOrder, "New", MdiParent = MainTask.MainView)]
    public partial class OrdersForm : WinFormViewForOrdersController, IOrdersView
    {
        public OrdersForm()
        {
            InitializeComponent();
        }

        public void SetOrdersList(List<Order> orders)
        {
            ordersGridView.DataSource = orders;
        }

        public Order CurrentOrder
        {
            get { return ordersGridView.CurrentRow == null ? null :
                         ordersGridView.CurrentRow.DataBoundItem as Order; }
        }

        //public void Refresh()
        //{
        //    ordersGridView.Refresh();
        //}

        public void SetOperationsEnabling(bool acceptIsEnabled, bool shipIsEnabled, bool cancelIsEnabled)
        {
            acceptOrderBtn.Enabled = acceptIsEnabled;
            shipOrderBtn.Enabled = shipIsEnabled;
            cancelOrderBtn.Enabled = cancelIsEnabled;

            this.Refresh();
        }

        private void ordersGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            Controller.CurrentOrderChanged();
        }

        private void acceptOrderBtn_Click(object sender, EventArgs e)
        {
            Controller.AcceptOrder();
        }

        private void shipOrderBtn_Click(object sender, EventArgs e)
        {
            Controller.ShipOrder();
        }

        private void cancelOrderBtn_Click(object sender, EventArgs e)
        {
            Controller.CancelOrder();
        }

        private void showCustomersButton_Click(object sender, EventArgs e)
        {
            Controller.ShowCustomers();
        }
    }

    // This intermediate class is used as a workaround for the bug
    // in the VS form designer when inheriting a generic form class.
    public class WinFormViewForOrdersController : WinFormView<OrderController>
    { }
}
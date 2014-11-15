using Kanc.MVP.Controllers.Base;
using Kanc.MVP.Presentation.Order;

namespace Kanc.MVP.Controllers.Order
{
    public class EditOrderController : SubControllerBase<IEditOrderView>
    {
        public override void BindModel()
        {
            Domain.Order order = Task.CurrentOrder;

            View.Message = "";

            View.Id = order.Id;
            View.Desc = order.Desc;
            //View.Owner = 
        }

        //private void ResetView()
        //{
        //    View.Message = "";
        //}

        public override void Next()
        {
            var ord = Task.CurrentOrder;

            //uwaga - edycja przez referencje
            ord.Id = View.Id;
            ord.Desc = View.Desc;
            ord.Ship();

            //Task.Navigator.NavigateDirectly(MainTask.EditCustomer);
            base.Next();
            Task.FireOrderChanged();
        }
        public override void Previous()
        {
            base.Previous();
        }

        

        
    }
}

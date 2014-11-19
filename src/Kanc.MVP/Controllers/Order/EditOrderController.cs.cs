using Kanc.MVP.Controllers.Base;
using Kanc.MVP.Core.Domain;

using Kanc.MVP.Presentation.Order;

namespace Kanc.MVP.Controllers.Order
{
    public class EditOrderController : SubControllerBase<IEditOrderView>
    {
        public override void BindModel()
        {
            Rozliczenie rozliczenie = Task.CurrentRozliczenie;

            View.Message = "";

            View.Id = rozliczenie.Id;
            View.Rok = rozliczenie.Rok;
            //View.Owner = 
        }

        //private void ResetView()
        //{
        //    View.Message = "";
        //}

        public override void Save()
        {
            var rozlicz = Task.CurrentRozliczenie;

            //uwaga - edycja przez referencje
            //ord.Id = View.Id;
            rozlicz.Rok = View.Rok;

            Session.SaveOrUpdate(Task.CurrentRozliczenie);
        }

        public override void Next()
        {
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

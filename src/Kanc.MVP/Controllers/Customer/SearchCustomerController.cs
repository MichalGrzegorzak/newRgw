using System.Collections.Generic;
using System.Linq;

using Kanc.MVP.Core.Domain;
using Kanc.MVP.Engine.Tasks;
using Kanc.MVP.Presentation.Search;
using MVCSharp.Core;
using NHibernate.Linq;

namespace Kanc.MVP.Controllers.Customer
{
    public class SearchCustomerController : ControllerBase<SearchTask, ISearchCustomer>
    {
        public List<OsobaLookup> FoundCustomers = new List<OsobaLookup>();

        public void CurrentCustomerChanged()
        {
            var selectedUser = FoundCustomers[View.SelectedCustomerIndex];
            
            Task.CurrentOsobaLookup = selectedUser;
            View.SetCustomerOrders(selectedUser.Rozliczenies);
            View.RefreshView();
        }

        public void CurrentOrderChanged()
        {
            Task.CurrentRozliczenie = View.CurrentRozliczenie;
            UserHasSelectedOrder();
        }

        /// <summary>
        /// Finalize task - return value
        /// </summary>
        public void UserHasSelectedOrder()
        {
            Task.StatelessSession.Close();

            //Task.CurrentOsobaLookup, 
            Task.TaskResultListener.RecieveTaskResult(Task.CurrentRozliczenie);
            View.Close();
        }

        public void NewOrder()
        {
            Rozliczenie rozliczenie = new Rozliczenie();
            Task.CurrentRozliczenie = rozliczenie;

            UserHasSelectedOrder();
        }

        private void ResetView()
        {
            View.Message = "";
            //View.Name = "";
            //View.SelectedCustomer
        }

        public void Search()
        {
            ResetView();

            FoundCustomers = Task.StatelessSession.Query<OsobaLookup>()
                .FetchMany(x=> x.Rozliczenies)
                .Where(x => x.Nazwisko.StartsWith(View.Nazwisko)).ToList();
            //FoundCustomers = OsobaLookup.AllCustomers.Where(x => x.Nazwisko.StartsWith(View.Nazwisko)).ToList();
            if (FoundCustomers.Any())
            {
                View.SetCustomers(FoundCustomers);
                CurrentCustomerChanged();
            }
            else
            {
                View.Message = "Nie znaleziono usera";
            }
        }
        
    }
}

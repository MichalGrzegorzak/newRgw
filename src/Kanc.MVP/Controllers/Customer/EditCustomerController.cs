using System.Collections.Generic;
using System.Windows.Forms;
using Kanc.MVP.Controllers.Base;
using Kanc.MVP.Engine.Validator;
using Kanc.MVP.Presentation.Customers;

namespace Kanc.MVP.Controllers.Customer
{
    public class EditCustomerController : SubControllerBase<IBaseEditCustomersView>
    {
        /// <summary>
        /// Wywoluje sie za kazdym razem gdy otwieramy widok
        /// </summary>
        public override void ViewActivated()
        {
            if (View.IsNew)
            {
                ResetView(); //executed whenever NewCustomer action is clicked
            }
        }

        /// <summary>
        /// Wykonuje sie tylko 1 raz, po zaladowaniu View
        /// </summary>
        public override void ViewInitialized()
        {
            base.ViewInitialized();

            //zdefiniuj walidacje wykorzystywana przez widok i kontroler
            Validator = new BasicValidator<IBaseEditCustomersView>(View);
            Validator.For(x => x.NazwiskoPl, "txbName").IsRequired();
            Validator.For(x => x.Age).IsRequired().IsCorrectAge(); //kontrolke znajdzie z konwencji
            //  or
            //validatorHlp.For("txbName", "Name").IsRequired();
        }

        /// <summary>
        /// Pozwalamy widokowi na waliduje kontrolek
        /// </summary>
        public string Validate(Control ctrl)
        {
            return Validator.ValidateControl(ctrl);
        }

        /// <summary>
        /// Podpiete pod event zmiany Customer`a
        /// </summary>
        public override void BindModel()
        {
            var c = Task.CurrentCustomer;

            ResetView();
            View.Id = c.Id;
            View.NazwiskoPl = c.Name;
            View.Age = c.Age;
            View.IsNew = (c.Id == 0);

            if (c.Id == 0)
                View.IsNew = true;
        }

        /// <summary>
        /// Wyczysc view - generealnie dla NewController`a
        /// </summary>
        public void ResetView()
        {
            View.Message = "";
            View.Id = 0;
            View.Age = 0;
            View.NazwiskoPl = "";
        }

        /// <summary>
        /// Walidacja uruchomiana przy akcji Next
        /// </summary>
        /// <returns></returns>
        public override bool IsValid()
        {
            Errors = new List<string>();

            //walidacja viewmodel`u
            bool hasError = Validator.ValidateViewModel(View);
            Errors.AddRange(Validator.Errors);

            //a tu przyklad dodatkowej customowej walidacji
            var c = Task.CurrentCustomer;
            //if (c.Id < 1)
            //{
            //    string m = "Id can`t be 0";
            //    View.SetError("txbId", m); //wlaczanie blinkania na View
            //    Errors.Add(m);
            //    hasError = true;
            //}

            return !hasError;
        }

        public override void Next()
        {
            //uwaga - edycja przez referencje
            Domain.Customer c = (View.IsNew) ? GetNewCustomer() : Task.CurrentCustomer;
            c.Name = View.NazwiskoPl;
            c.Age = View.Age;

            if (IsValid())
            {
                Task.CurrentCustomer = c; //przypisanie odpali event
            }

            base.Next(); //odpali walidacje i wywoluje z navigatora NEXT, jesli blad to wyswietli
        }

        private Domain.Customer GetNewCustomer()
        {
            Domain.Customer c = new Domain.Customer(View.NazwiskoPl);
            c.Id = 55; //symuluje zapis do bazy - view wykrywa po Id > 0, czy to edycja czy nowy

            Domain.Order o = new Domain.Order(0, "");
            c.Orders.Add(o);

            Task.CurrentOrder = o;

            return c;
        }
        public override void Previous()
        {
            base.Previous();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Kanc.MVP.Controllers.Base;

using Kanc.MVP.Core.Domain;
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
            Validator.For(x => x.Urodzony).IsRequired(); 
            //.IsCorrectAge(); //kontrolke znajdzie z konwencji

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
            var c = Task.CurrentRozliczenie.Klient;

            ResetView();
            View.Id = c.Id;
            View.NazwiskoPl = c.Nazwisko;
            View.Urodzony = c.Urodz;
            View.IsNew = c.IsNew;
        }

        /// <summary>
        /// Wyczysc view - generealnie dla NewController`a
        /// </summary>
        public void ResetView()
        {
            View.Message = "";
            //View.Id = 0;
            View.Urodzony = null;
            View.NazwiskoPl = "";
            //View.IsNew = false;
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
            var c = Task.CurrentRozliczenie.Klient;
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
            if (!IsValid())
                return;

            //uwaga - edycja przez referencje
            //Klient c = (View.IsNew) ? GetNewCustomer() : Task.CurrentRozliczenie.Klient;
            Klient c = Task.CurrentRozliczenie.Klient;
            c.Nazwisko = View.NazwiskoPl;
            c.Urodz = View.Urodzony;
            c.IsNew = false;

            base.Next(); //odpali walidacje i wywoluje z navigatora NEXT, jesli blad to wyswietli
            Task.FireOrderChanged();
        }

        //private OsobaLookup GetNewCustomer()
        //{
        //    OsobaLookup c = new OsobaLookup(View.NazwiskoPl);
        //    //c.Id = 55; //symuluje zapis do bazy - view wykrywa po Id > 0, czy to edycja czy nowy

        //    Rozliczenie o = new Rozliczenie(0, "");
        //    c.Orders.Add(o);

        //    Task.CurrentRozliczenie = o;

        //    return c;
        //}
        public override void Previous()
        {
            base.Previous();
        }

    }
}

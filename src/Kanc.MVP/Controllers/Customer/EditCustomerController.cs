using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Kanc.MVP.Controllers.Base;

using Kanc.MVP.Core.Domain;
using Kanc.MVP.Engine.Validator;
using Kanc.MVP.Presentation.Customers;

namespace Kanc.MVP.Controllers.Customer
{
    public class EditCustomerController : SubControllerBase<IEditCustomersView>
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
            base.ViewActivated();
        }

        /// <summary>
        /// Wykonuje sie tylko 1 raz, po zaladowaniu View
        /// </summary>
        public override void ViewInitialized()
        {
            base.ViewInitialized();

            //zdefiniuj walidacje wykorzystywana przez widok i kontroler
            Validator = new BasicValidator<IEditCustomersView>(View);
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
            View.IsNew = c.IsTransient();
        }

        /// <summary>
        /// Wyczysc view - generealnie dla NewController`a
        /// </summary>
        public void ResetView()
        {
            View.Message = "";
            View.Urodzony = null;
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

        public override void Save()
        {
            //uwaga - edycja przez referencje
            Klient c = Task.CurrentRozliczenie.Klient;
            c.Nazwisko = View.NazwiskoPl;
            c.Urodz = View.Urodzony;

            Session.SaveOrUpdate(Task.CurrentRozliczenie);
        }

        public override void Next()
        {
            if (!IsValid())
                return;

            base.Next(); //odpali walidacje i wywoluje z navigatora NEXT, jesli blad to wyswietli
        }

        public override void Previous()
        {
            base.Previous();
        }

    }
}

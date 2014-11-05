using System;
using System.Diagnostics.Contracts;
using Kanc.Core.Entities;
using NHibernate.Validator.Binding.Util;

namespace Kanc.UI.Forms
{
    /// <summary>
    /// Forma tylko do prezentowania danych, ktore zaldujemy na starcie
    /// Automatycznie odpali LoadDataOnAllControls, na wszystkich childControlakach na formie
    /// </summary>
    public class PresentationForm : NavigationBaseFormSession<Rozliczenie>
    {
        public PresentationForm() : base()
        {
            if (DesignMode)
                return;

            this.Load += new EventHandler(PresentationForm_Load);
        }

        void PresentationForm_Load(object sender, EventArgs e)
        {
            Contract.EnsuresOnThrow<Exception>(MainBindingSrc.DataSource != null, "Uzyj ShowForm z MainForm, i ustaw DataSource");

            if (DesignMode)
                return;

            Check.NotNull(MainBindingSrc.DataSource, "MainBindingSrc.DataSource", 
                "Uzyj ShowForm z MainForm, i ustaw DataSource");

            object item = ((IEntity)MainBindingSrc.DataSource).Clone();
            //MainBindingSrc = new BindingSource(); //nowy, niezalezny obiekt
            MainBindingSrc.DataSource = item;
            
            LoadDataOnAllControls();
        }

         protected override void BindControls()
         {
             
         }
    }
}
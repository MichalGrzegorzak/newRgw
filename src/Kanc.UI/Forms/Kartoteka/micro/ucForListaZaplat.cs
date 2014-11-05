using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Kanc.Core;
using Kanc.Core.Entities;

namespace Kanc.UI.Ctrl
{
    public partial class ucForListaZaplat : BaseUserControl
    {
        public ucForListaZaplat()
        {
            InitializeComponent();
        }

        public override void LoadData(Binder binder, bool option = false)
        {
            binder.Bind(txbLista, (Rozliczenie r) => r.Rachunek.ListaZaplat);
            binder.Bind(txbNrKP, (Rozliczenie r) => r.Rachunek.NrKP);
            //binder.Bind(txbNrFaktury, (Rozliczenie r) => r.Rachunek.); // BRAK ?? i nie widze zeby byl wykorzystywany
            
        }
    }
}

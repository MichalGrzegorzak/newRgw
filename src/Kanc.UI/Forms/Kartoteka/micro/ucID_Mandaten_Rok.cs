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
using Kanc.UI.Ctrl;

namespace Kanc.UI.Forms.Kartoteka.KlientPodglad
{
    public partial class ucID_Mandaten_Rok : BaseUserControl
    {
        public ucID_Mandaten_Rok()
        {
            InitializeComponent();
        }

        public override void LoadData(Binder binder, bool option = false)
        {
            binder.Bind(idTextBox2, (Rozliczenie r) => r.Id);
            binder.Bind(mIdTextBox, (Rozliczenie r) => r.Klient.MandId);
            binder.Bind(RokTextBox, (Rozliczenie r) => r.Rok);
        }

        
    }
}

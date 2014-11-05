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
    public partial class ucNagrodaListy : BaseUserControl
    {
        public ucNagrodaListy()
        {
            InitializeComponent();

            ResetTabIndex();
            statusTextBox.TabIndex = 710;
            zaplaconoTextBox.TabIndex = 720;
        }

        public override void LoadData(Binder binder, bool option = false)
        {
            binder.BindRozlicz(statusTextBox, r => r.Status);
            binder.BindRozlicz(zaplaconoTextBox, r => r.Rachunek.KwotaRachunek);
        }
    }
}

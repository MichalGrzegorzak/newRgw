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
    public partial class ucPartner : BaseUserControl
    {
        public ucPartner()
        {
            InitializeComponent();

            ResetTabIndex();
            partnerImieTextBox.TabIndex = 510;
            partnerUrodzMaskedTextBoxExt.TabIndex = 520;
            partnerWyznanieTextBox.TabIndex = 530;
            partnerSlubMaskedTextBoxExt.TabIndex = 540;
        }

        public override void LoadData(Binder binder, bool option = false)
        {
            binder.Bind(partnerImieTextBox, (Rozliczenie r) => r.Partner.Imie).ValidateWithEvent();
            binder.Bind(partnerMandIdTextBox, (Rozliczenie r) => r.Partner.MandId).ValidateWithEvent();
            binder.Bind(partnerSlubMaskedTextBoxExt, (Rozliczenie r) => r.Klient.DataSlubu).ValidateWithEvent();
            binder.Bind(partnerUrodzMaskedTextBoxExt, (Rozliczenie r) => r.Partner.Urodz).ValidateWithEvent();

            //no validation
            binder.Bind(partnerWyznanieTextBox, (Rozliczenie r) => r.Partner.Religia);
        }


    }
}

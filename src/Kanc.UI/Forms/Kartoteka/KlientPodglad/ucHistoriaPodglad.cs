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
    public partial class ucHistoriaPodglad : BaseUserControl
    {
        public ucHistoriaPodglad()
        {
            InitializeComponent();
        }

        public IList<Historia> Historia { get; set; }

        public override void LoadData(Binder binder, bool option = false)
        {
            binder.Bind(dataPrzeniesieniaTextBox, (Rozliczenie r) => r.Historia.DataPrzeniesienia);
            binder.Bind(dataPrzyjeciaTextBox, (Rozliczenie r) => r.Historia.DataPrzyjecia);

            //var historiaPodglad = (from hist in Historia
            //                       select new { hist.Status, hist.CreatedOn, hist.CreatedBy });
            //OCO TU CHODZI ???
            //var historiaPodglad = ((Historia)source.DataSource).Daty;

            //historiabindingSource.DataSource = historiaPodglad;
            //historiaGridView.DataSource = historiabindingSource;
            //historiaGridView.AutoGenerateColumns = false;
        }
    }
}

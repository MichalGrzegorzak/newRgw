using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kanc.UI.Ctrl
{
    public partial class OkCancel : BaseUserControl
    {
        public OkCancel()
        {
            InitializeComponent();
        }

        public event EventHandler Zapisz;
        public event EventHandler Anuluj;

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Zapisz != null)
                Zapisz.Invoke(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (Anuluj != null)
                Anuluj.Invoke(sender, e);
        }
    }
}

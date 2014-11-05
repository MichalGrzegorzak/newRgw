using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Kanc.Commons;

namespace Kanc.UI.Forms.Kartoteka.micro
{
    [DefaultBindingProperty("SetValue")]
    public partial class uxProcPodatek : UserControl
    {
        public uxProcPodatek()
        {
            InitializeComponent();
        }

        //chyba rownie dobrze mozna by nadpisac property Text
        [Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string SetValue
        {
            get { return comboPodatek.Text; }
            set
            {
                comboPodatek.Text = value;
            }
        }

    }
}

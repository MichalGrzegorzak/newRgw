using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Castle.Core;
using Castle.Core.Internal;
using Kanc.Commons;
using Kanc.Core;
using Kanc.Core.Entities;

namespace Kanc.UI.Ctrl
{
    public partial class ucDzieciExperim : BaseUserControl
    {
        public ucDzieciExperim()
        {
            InitializeComponent();

            ResetTabIndex();
            //textBox1.Visible = false;
            //textBox1.Bin
        }

        public override void LoadData(Binder binder, bool option = false)
        {
            binder.BindRozlicz(numericUpDown1, r => r.Klient.DzieciLiczba).ValidateWithEvent();
            binder.BindRozlicz(textBox1, r => r.Klient.DzieciDaty).ValidateWithEvent();

            foreach (Binding binding in textBox1.DataBindings)
            {
                binding.Parse += new ConvertEventHandler(binding_Parse);
                binding.Format += new ConvertEventHandler(binding_Format);
            }

            //podepnij wszystkie dynamiczne textboxy pod ten event
            //pobierz z wszystkich daty i wpisz pod textbox1

            maskedTextBoxExt1.Validating += new CancelEventHandler(maskedTextBoxExt1_Validating);
            maskedTextBoxExt2.Validating += new CancelEventHandler(maskedTextBoxExt1_Validating);
            //...

            Rozliczenie roz = (binder.source.Current as Rozliczenie);
            //foreach (string s in roz.Klient.DzieciDaty.Split(';'))
            {
                //TODO: trza by to zrobic dynamicznie
                //MaskedTextBox textBox = new MaskedTextBox();
                //textBox.Text = s;

            }
            //string[] daty = roz.Klient.DzieciDaty.Split(';');
            //if(daty[0].IsNotNullOrEmpty())
            //    maskedTextBoxExt1.Tex

            //TODO: podzielic po srednikach i pododawac do odpowiednich okien
        }

        void maskedTextBoxExt1_Validating(object sender, CancelEventArgs e)
        {
            textBox1.Text = maskedTextBoxExt1.Text;
        }

        void binding_Format(object sender, ConvertEventArgs e)
        {
            //tutaj dane przychodza ze zrodla
            string[] vals = e.Value.ToString().Split(';');

        }

        void binding_Parse(object sender, ConvertEventArgs e)
        {
            //stad dane wychodza do zrodla
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            IList<Control> arr = new List<Control>();
            foreach (Control ctrl in this.Controls)
            {
                arr.Add(ctrl);
            }
            arr = arr.Where(x => x.Name.StartsWith("maskedTextBoxExt")).ToList();
            arr.ForEach(c=>c.Visible=false);
            
            int val = (int) numericUpDown1.Value;
            if (val > 6)
            {
                val = 6;
                numericUpDown1.Value = val;
            }

            for(int i=1; i <= val; i++)
            {
                string name = "maskedTextBoxExt" + i;
                this.Controls.Find(name, false)[0].Visible = true;
            }
            
        }
    }
}

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
    [System.ComponentModel.DefaultBindingProperty("Text")]
    public partial class Unwind : BaseUserControl
    {
        public delegate void ClickedDelegate(object sender, EventArgs e);
        public event ClickedDelegate Clicked;
        
        public Unwind()
        {
            InitializeComponent();
            
        }

        public string Text
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Clicked != null)
                Clicked.Invoke(this, null);
        }

        
    }
}

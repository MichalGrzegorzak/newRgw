using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Kanc.Commons;

namespace Kanc.UI.Forms.Kartoteka
{
    public partial class Form22 : Form
    {
        public Form22()
        {
            InitializeComponent();
            AddControls();
        }

        public SplitterPanel HeaderPanel
        {
            get { return splitContainer1.Panel1; }
        }
        public SplitterPanel ContentPanel
        {
            get { return splitContainer2.Panel1; }
        }
        public SplitterPanel FooterPanel
        {
            get { return splitContainer2.Panel2; }
        }

        public void AddControls()
        {
            HeaderPanel.Controls.Add(new Label() { Text = "Hello1!" });

            ContentPanel.Controls.Add(new Label() { Text = "Hello2!" });

            FooterPanel.Controls.Add(new Label() { Text = "Hello3!" });
        }


    }
}

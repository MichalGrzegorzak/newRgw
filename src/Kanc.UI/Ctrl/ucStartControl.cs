using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Kanc.Core.Infrastructure;
using Kanc.UI.Forms;

namespace Kanc.UI.Ctrl
{
    public partial class ucStartControl : UserControl
    {
        public event EventHandler<EventArgs<Form>>  ShowForm = (s, e) => { };

        public ucStartControl()
        {
            InitializeComponent();

            AddButtons();
        }

        private void AddButtons()
        {
            this.SuspendLayout();

            TableLayoutPanel panel = new TableLayoutPanel();
            panel.Dock = DockStyle.Fill;
            panel.ColumnCount = 3;
            panel.RowCount = 3;

            Button btn1 = new Button() { Name = "btnWprowadz", Text = "Kartoteka" };
            btn1.Click += (s, a) => ShowForm(this, new EventArgs<Form>(new FrmWprowadz()));
            btn1.Size = new Size(100, 33);
            btn1.Dock = DockStyle.Right | DockStyle.Top;
            panel.Controls.Add(btn1);
            //
            Button btn2 = new Button() { Name = "btnDodajBank", Text = "Dodaj bank" };
            btn2.Click += (s, a) => ShowForm(this, new EventArgs<Form>(new FrmDodajBank()));
            btn1.Size = new Size(100, 33);
            btn2.Dock = DockStyle.Right | DockStyle.Top;
            panel.Controls.Add(btn2);
            //panel.Controls.Add(btn2, 1, 2);
            //
            this.Controls.Add(panel);
            //
            this.ResumeLayout(true);
        }
    }

    //public class FormCommands : EventArgs
    //{
    //EventArgs<>    
    //}

    
}

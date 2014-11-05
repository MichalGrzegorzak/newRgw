using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NHibernate;

namespace Kanc.UI.Tests.Forms
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.ShowUpDown = false; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Context.FactoryInitializer.SetupDynamicProxy();
            new Binding_DynamicProxy_Atributes().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Context.FactoryInitializer.SetupNormal();
            new Binding_SmartValidator_emptyEntities().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Rachunek_B rach = new Rachunek_B();
            //rach.PropertyChanged += ((s, ea) =>  MessageBox.Show(ea.PropertyName + " changed"));
            rach.Name = "34234";
        }

        private void btnFlowingPanel_Click(object sender, EventArgs e)
        {

        }

        

    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Kanc.Commons.Helpers;
using Kanc.Core;
using Kanc.Core.Entities;
using Kanc.Core.Features;
using Kanc.UI.Ctrl;
using Kanc.UI.Ctrl.Klient;
using Kanc.UI.Forms.Base;
using Kanc.UI.Forms.Kartoteka;
using NHibernate;

namespace Kanc.UI.Forms
{
    public partial class MainForm : MainFormBase
    {
        //ODCZYT WYNIKU Z FORMY MODALNEJ- X zwraca false
        //public void ShowMyDialogBox()
        //{
        //    Form2 testDialog = new Form2();

        //    // Show testDialog as a modal dialog and determine if DialogResult = OK.
        //    if (testDialog.ShowDialog(this) == DialogResult.OK)
        //    {
        //        // Read the contents of testDialog's TextBox.
        //        this.txtResult.Text = testDialog.TextBox1.Text;
        //    }
        //    else
        //    {
        //        this.txtResult.Text = "Cancelled";
        //    }
        //    testDialog.Dispose();
        //}

        public void AttachEvents()
        {
            _tabForm.SelectedIndexChanged += new EventHandler(this.tabForm_SelectedIndexChanged);
            MdiChildActivate += new EventHandler(this.MainForm_MdiChildActivate);
        }

        public void Init()
        {
            this.IsMdiContainer = true;
            this.Size = new Size(1000, 700);
            //this.Location = new Point(0,0);
            _tabForm = tabForm;
        }

        private void RunDefaultActions()
        {
            List<Action<object, EventArgs>> toExecute = new List<Action<object, EventArgs>>();
            toExecute.Add(btnNew_Click);
            //toExecute.Add(form3ucKlientToolStripMenuItem_Click);
            //toExecute.Add(test1ToolStripMenuItem_Click);

            //dziala zamienic enumy na te typy! - sprawdz czy mozna tego typu uzyc w generyku
            try
            {
                ShowFormAsMdi<FrmSzukaj>();
                OpenNewRozliczenie(4);
                toExecute.ForEach(a => a.Invoke(this, null));

                Glowna glowna = new Glowna();
                glowna.Show();

                //ShowFormAsMdi<FrmWprowadz>();
                //ShowFormAsMdi<FrmSzukaj>();
                //ShowFormAsMdi<FrmPodatekStrona>();
                
                //ucStartControl1.ShowForm += new EventHandler<Core.Infrastructure.EventArgs<Form>>(ucStartControl1_ShowForm);
            }
            catch (Exception ex)
            {
                _log.Error(ex);

                PutTestDataToDB();
            }
        }
        
        public MainForm()
        {
            InitializeComponent();

            Init();
            
            AttachEvents();

            RunDefaultActions();

        }

        public void OpenNewRozliczenie(int rozliczenieId)
        {
            var f1 = ShowFormAsMdi<FrmArchiwum>(true);
            f1.RozliczenieId = rozliczenieId;
            f1.Init();
            f1.Display();

            //var f2 = ShowFormAsMdi<FrmKartotekaPodglad>(true);
            //f2.RozliczenieId = rozliczenieId;
        }

        private void mnuExit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void formWprowToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ShowForm<FrmWprowadz>();
        }

        private void form3ucKlientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm<FrmSzukaj>();
        }

        private void przegladToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm<FrmKartotekaPodglad>();
        }

        private void report1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowForm<ReportTest>();
        }

        private void report1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm<FrmDodajBank>();
        }

        private void test1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm<FrmTest1>();
        }

        private void podatekStronaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ShowForm<FrmPodatekStrona>();
        }

        

        #region Left menu actions

        private void btnNew_Click(object sender, EventArgs e)
        {
            ShowFormAsMdi<FrmWprowadz>();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            foreach (TabPage tab in tabForm.TabPages)
            {
                if (tab.Tag is FrmSzukaj)
                {
                    tabForm.SelectedTab = tab;
                    return;
                }
            }

            ShowFormAsMdi<FrmSzukaj>();
        }

        private void btnCloseAll_Click(object sender, EventArgs e)
        {
            CloaseAllBaseForms();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //ShowForm<MainForm2>();
            EdycjaKlienta v = new EdycjaKlienta();
            v.Size = new Size(800,600);
            v.AutoScroll = true;
            v.Show();
        }

        #endregion

        private void test2BazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFormAsMdi<FormTest2>();
        }

        

    }
}

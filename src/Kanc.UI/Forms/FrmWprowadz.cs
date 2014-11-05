using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Kanc.Commons;
using Kanc.Core;
using Kanc.Core.Entities;
using Kanc.UI.Ctrl;
using Kanc.UI.Forms;
using NHibernate;
using Kanc.Core.Features;
using System.Configuration;
using NHibernate.Validator.Binding;
using NHibernate.Validator.Engine;
using NHibernate.Linq;

namespace Kanc.UI.Forms
{
	public partial class FrmWprowadz : FrmWprowadzChild
	{
		private Binder binder;

		public FrmWprowadz() : base()
		{
			InitializeComponent();

			//podepnij navigator
			InitNavigator();

			ucKonto1.Session = Session;
			//ucKonto1.RereadSource += new EventHandler<EventArgs<Bank>>(ucKonto1_RereadSource);

			binder = new Binder(MainBindingSrc, new SmartViewValidator(errorProvider1));

		    ucMandatenID1.TabIndex = 9999;
		    JahrTextBox.TabIndex = 100;
		    krajeDDL1.TabIndex = 110;
		    _ucEdycjaKlient1.TabIndex = 200;
		   // ucSofiNummer1.TabIndex = 249;
		    ucAdres1.TabIndex = 250;
		    ucKonto1.TabIndex = 300;

            notkaTextBox.TabIndex = 390;
		    ucWlascicielKonta1.TabIndex = 400;
		    ucPartner1.TabIndex = 500;
		    ucDzieci1.TabIndex = 600;
		    ucNagrodaListy1.TabIndex = 700;
		    poleconyDDL1.TabIndex = 800;
		    tabControl1.TabIndex = 1000;

		    JahrTextBox.Focus();
		}

		private void InitNavigator()
		{
			navigator = rozliczenieBindingNavigator;

			//wyciete z designera
			this.bindingNavigatorMoveLastItem.Click += new System.EventHandler(MoveItemClicked);
			this.bindingNavigatorMoveFirstItem.Click += new System.EventHandler(MoveItemClicked);
			this.bindingNavigatorAddNewItem.Click += new System.EventHandler(MoveItemClicked);
			this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(MoveItemClicked);
			this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(MoveItemClicked);
		}

		//protected override void LoadData()
		//{
		//    IList<Rozliczenie> results = null;
		//    using (ITransaction tx = Session.BeginTransaction())
		//    {
		//        results = Session.QueryOver<Rozliczenie>().List();
		//        Session.Flush();
		//        tx.Commit();
		//    }

		//    MainBindingSrc.DataSource = results;
		//    navigator.BindingSource = MainBindingSrc;

		//}

		protected override void BindControls()
		{
			log.Debug("BindControls begin");

			_ucEdycjaKlient1.LoadData(binder);

			ucAdres1.LoadData(binder, false);
			ucKonto1.LoadData(binder);
			ucPartner1.LoadData(binder);
			ucWlascicielKonta1.LoadData(binder);
			ucMandatenID1.LoadData(binder);

			//ucDzieciExperim1.LoadData(binder); to kiedys indziej
			ucDzieci1.LoadData(binder);
			ucNagrodaListy1.LoadData(binder);
			//ucSofiNummer1.LoadData(binder);


            binder.Bind(JahrTextBox, (Rozliczenie r) => r.Rok).ValidateWithEvent();
            
            //bez walidacji
			binder.Bind(typyListGrpBox1, (Rozliczenie r) => r.Status, "Selected"); //??? czy to napewno jest ok
			binder.Bind(notkaTextBox, (Rozliczenie r) => r.Klient.Notka);
            binder.Bind(krajeDDL1, (Rozliczenie r) => r.Kraj);
            binder.Bind(poleconyDDL1, (Rozliczenie r) => r.Klient.Polecil);
            

			//oldtimes
			//notkaTextBox.DataBindings.Add("Text", MainBindingSrc, GetMemberName((Rozliczenie rr) => rr.Podatek.Notka), true, DataSourceUpdateMode.OnPropertyChanged);
		}

		private void DrukujEstkButton_Click(object sender, EventArgs e)
		{
			//RaportFactory.Niemcy
			
			//RaportGenerator generator = new RaportGenerator();
			//generator.Typ = TypRaportu.PodatekNiemcy;
			//generator.TemplatePath = ConfigurationSettings.AppSettings["RaportTemplatePathPodatekNiemcy"];
			//generator.Jezyk = RptLang.Obcy;
			//generator.Rok = this.JahrTextBox.Text;

			//IDictionary<string, string> dictionary = new Dictionary<string, string>();

			

			//generator.FieldsToFill = dictionary;
			//generator.GenerateReport();
		}

		private void EuEwrButton_Click(object sender, EventArgs e)
		{
			//ShowForm<FrmEuEwr>(MainBindingSrc);
		}

		private void PodatekStrona_Click(object sender, EventArgs e)
		{
			//ShowForm<FrmPodatekStrona>(MainBindingSrc);
		}

		private void bindingNavigatorSavetItem_Click(object sender, EventArgs e)
		{
			bool ok = SaveItem();

            if (ok)
            {
                lblStatus.Text = "Zapisano OK";
                lblStatus.ForeColor = Color.Green;
            }
            else
            {
                lblStatus.Text = "Nie mozna zapisac!";
                lblStatus.ForeColor = Color.Red;
            }
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			string mandId = toolStripTextBox1.Text;
			var rozliczenia = Session.Query<Rozliczenie>().Where(x => x.Klient.MandId == mandId).ToList();
			//var list = Session.QueryOver<Rozliczenie>().Where(x => x.MandId == mandId).SelectList();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{

		}


	}

	public class FrmWprowadzChild : NavigationBaseFormSession<Rozliczenie>
	{
	}
}

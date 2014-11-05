using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Kanc.Commons;
using Kanc.Core;
using Kanc.Core.Entities;
using Kanc.Core.Features;
using Kanc.Core.Features.Raporty;

namespace Kanc.UI.Forms
{
    public partial class FrmArchiwum : FrmArchiwumChild
    {
        public int RozliczenieId;
        
        public FrmArchiwum()
        {
            InitializeComponent();
            //InitForm();
            Context.IsTestingMode = true;
            Closed += new EventHandler(FrmArchiwum_Closed);
        }

        void FrmArchiwum_Closed(object sender, EventArgs e)
        {
            Context.IsTestingMode = false;
        }

        private Rozliczenie CreateStubRozliczenie()
        {
            Rozliczenie roz = new Rozliczenie();
            //
            roz.PoprzedniId = 098765;
            roz.Rok = 2011;
            roz.Status = Status.s333;
            //
            roz.Klient.MandId = "12345 W";
            roz.Klient.DataSlubu = new DateTime(2010, 10, 26);
            roz.Klient.Steuernummer = "stęu12345678";
            roz.Klient.Telefon = "tel12345678";
            roz.Klient.Urodz = new DateTime(1981, 12, 30);
            roz.Klient.Religia = 2;
            roz.Klient.Zawod = "hydraulik";
            roz.Klient.DzieciLiczba = 12;
            roz.Klient.DzieciDaty = "2008-01-01;2007-01-01;2006-01-01;";
            roz.Klient.Email = "elv@o2.pl";
            roz.Klient.Imie = "ĄąćęĘłŁŃńóÓŚśŹźŻż";
            roz.Klient.ImieDe = "ĄąćęĘłŁŃńóÓŚśŹźŻż";
            roz.Klient.Nazwisko = "ĄąćęĘłŁŃńóÓŚśŹźŻż";
            roz.Klient.NazwiskoDe = "ĄąćęĘłŁŃńóÓŚśŹźŻż";
            roz.Klient.Komorka = "kom123456789";

            roz.CreatedBy = "operator_11";

            //
            roz.Konto.KontoLk = "11";
            roz.Konto.KontoNr = "123456";
            roz.Konto.KontoWlasciciel = "moje wlasnie";
            roz.Konto.BankAdres = "adres banku";
            roz.Konto.BankBLZ = "blz banku";
            roz.Konto.BankKraj = Kraje.PL;
            roz.Konto.BankNazwa = "Comerzbank";
            roz.Konto.BankSwift = "swift banku";
            //
            roz.Kraj = Kraje.DE;
            roz.Partner.Imie = "Ewa";
            roz.Partner.Nazwisko = "Ziomko";
            roz.Partner.MandId = "12345mand";
            roz.Partner.Plec = Plec.Kobieta;
            //roz.Partner.IsPresent = true;
            roz.Partner.Religia = 3;
            roz.Partner.Urodz = new DateTime(1981, 6, 16);
            roz.Partner.Zawod = "boss";
            //
            roz.Podatek.Auto = "ma auto";
            roz.Podatek.Do1M = "do 1m";
            roz.Podatek.Do1W = null;
            roz.Podatek.Do3W = DateTime.Now;
            roz.Podatek.DoXM = "do XM";
            
            //
            roz.Klient.AdresZameld.Kod = "58-260";
            roz.Klient.AdresZameld.Miasto = "Bielawa";
            roz.Klient.AdresZameld.Kraj = Kraje.PL;
            roz.Klient.AdresZameld.Miejsce = "miejsce Bielawa";
            roz.Klient.AdresZameld.Ulica = "Młóśćźżodyuch 25";
            //
            roz.Historia.DataPrzeniesienia = new DateTime(2005,01,01);
            roz.Historia.DataPrzyjecia = new DateTime(2004, 04,04);
            roz.Historia.Daty = "2009-01-01;2010-01-01";
            roz.Historia.Operatorzy = "Marian; Iwona";
            roz.Historia.Statusy = "066;077";

            return roz;
        }

        public void Init()
        {
            Contract.Requires(RozliczenieId > 0, "Archiwum Init(), ladujesz item o ID: 0");

            //Rok = 2011;
            //if(Roz)
            //rozliczenie = CreateStubRozliczenie();
            this.LoadItemById(RozliczenieId);
            MainBindingSrc.DataSource = CurrentItem;
            binder.source = MainBindingSrc;

            List<Button> buttons = CreateButtons();
            foreach (Button btn in buttons)
            {
                flowLayoutPanel1.Controls.Add(btn);
            }

            //RaportFactory.Niemcy.Volmacht.Create(2011, new Rozliczenie());
        }

        private List<Button> CreateButtons()
        {
            List<Button> buttons = new List<Button>();

            Type reportTypes = typeof(RptNiemcy);
            foreach (FieldInfo property in reportTypes.GetFields())
            {
                buttons.Add(MakeButton(property.Name));
            }
            //buttons.Add(MakeButton("Volmacht"));
            //buttons.Add(MakeButton("UmowaDe"));

            //buttons.Add(MakeButton("Bestatigung"));
            //buttons.Add(MakeButton("KontoBankowe"));
            //buttons.Add(MakeButton("StronaNiemcy"));
            //buttons.Add(MakeButton("Estk"));
            //buttons.Add(MakeButton("BrakKarty"));

            //buttons.Add(MakeButton("UmowaDe"));
            //buttons.Add(MakeButton("UmowaDe"));
            //buttons.Add(MakeButton("UmowaDe"));

            return buttons;
        }

        private Button MakeButton(string name)
        {
            Button btn = new Button();
            btn.Name = "btn" + name;
            btn.Text = name;
            btn.Click += new EventHandler(delegate(object sender, EventArgs args)
                                              {
                                                  Button b = (sender as Button);
                                                  CreateReportByName(name);
                                              });
            return btn;
        }


        //from t in Assembly.GetExecutingAssembly().GetTypes() where t.IsSubclassOf(typeof(BaseRpt)) select t

        private void CreateReportByName(string name)
        {
            Contract.Requires(binder.Rozliczenie.Rok > 0);
            
            if(binder.Rozliczenie.Rok < 1990)
                throw new Exception("Nie prawidlowy rok w rozliczeniu! Brak danych!");
            
            Type reportTypes = typeof(RptNiemcy);
            foreach (FieldInfo property in reportTypes.GetFields())
            {
                if (property.Name == name)
                {
                    BaseRpt rr = (BaseRpt)Activator.CreateInstance(property.FieldType);
                    //rr.
                    rr.Map(binder.Rozliczenie.Rok, binder.Rozliczenie);
                    rr.Genereate();
                }
            }
        }

        private void btnUmowaDe_Click(object sender, EventArgs e)
        {

        }
    }

    public class FrmArchiwumChild : BaseFormSessionGeneric<Rozliczenie>
    {
    }
}

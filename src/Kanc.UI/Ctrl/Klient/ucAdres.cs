using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Kanc.Core;
using Kanc.Core.Entities;

namespace Kanc.UI.Ctrl
{
    public partial class ucAdres : BaseUserControl
    {
        public ucAdres()
        {
            InitializeComponent();

            ResetTabIndex();
            kodTextBox1.TabIndex = 250;
            miastoTextBox1.TabIndex = 260;
            ulicaTextBox1.TabIndex = 270;
            krajeDDL1.TabIndex = 280;
            miejsceTextBox1.TabIndex = 290;

        }

        public override void LoadData(Binder binder, bool option = false)
        {
            //if (!option)
            {
                binder.Bind(kodTextBox1, (Rozliczenie r) => r.Klient.AdresZameld.Kod).ValidateWithEvent(); ;
                binder.Bind(miastoTextBox1, (Rozliczenie r) => r.Klient.AdresZameld.Miasto).ValidateWithEvent();
                binder.Bind(miejsceTextBox1, (Rozliczenie r) => r.Klient.AdresZameld.Miejsce).ValidateWithEvent(); ;
                binder.Bind(ulicaTextBox1, (Rozliczenie r) => r.Klient.AdresZameld.Ulica).ValidateWithEvent(); ;

                binder.Bind(idTextBox2, (Rozliczenie r) => r.Klient.AdresZameld.Id);
                binder.Bind(krajeDDL1, (Rozliczenie r) => r.Klient.AdresZameld.Kraj); 
            }
            //else
            //{
            //    binder.Bind(idTextBox2,(Rozliczenie r) => r.Klient.AdresKoresp.Id);
            //    binder.Bind(kodTextBox1, (Rozliczenie r) => r.Klient.AdresKoresp.Kod).ValidateWithEvent(); ;
            //    binder.Bind(miastoTextBox1, (Rozliczenie r) => r.Klient.AdresKoresp.Miasto).ValidateWithEvent(); ;
            //    binder.Bind(miejsceTextBox1, (Rozliczenie r) => r.Klient.AdresKoresp.Miejsce).ValidateWithEvent(); ;
            //    binder.Bind(ulicaTextBox1, (Rozliczenie r) => r.Klient.AdresKoresp.Ulica).ValidateWithEvent(); ;
            //    binder.Bind(krajeDDL1, (Rozliczenie r) => r.Klient.AdresKoresp.Kraj); 
            //}
        }

        
        //public void LoadData2(Adres source)
        //{
        //    idTextBox2.DataBindings.Add("Text", source, GetMemberName((Adres r) => r.Id), true, DataSourceUpdateMode.OnPropertyChanged);
        //    kodTextBox1.DataBindings.Add("Text", source, GetMemberName((Adres r) => r.Kod), true, DataSourceUpdateMode.OnPropertyChanged);
        //    miastoTextBox1.DataBindings.Add("Text", source, GetMemberName((Adres r) => r.Miasto), true, DataSourceUpdateMode.OnPropertyChanged);
        //    miejsceTextBox1.DataBindings.Add("Text", source, GetMemberName((Adres r) => r.Miejsce), true, DataSourceUpdateMode.OnPropertyChanged);
        //    ulicaTextBox1.DataBindings.Add("Text", source, GetMemberName((Adres r) => r.Ulica), true, DataSourceUpdateMode.OnPropertyChanged);
        //    krajeDDL1.DataBindings.Add("SetValue", source, GetMemberName((Adres r) => r.Kraj), true, DataSourceUpdateMode.OnPropertyChanged);
        //}
    
    }
}

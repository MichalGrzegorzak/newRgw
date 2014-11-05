using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Kanc.Core;
using Kanc.Core.Entities;
using NHibernate;
using NHibernate.Validator.Binding;

namespace Kanc.UI.Forms.Modalne
{
    /// <summary>
    /// formatka do budowania odpowiedzi
    /// </summary>
    public partial class FrmKsiegowanie : SimpleForm
    {
        public FrmKsiegowanie(int rozId) : base()
        {
            InitializeComponent();
            RozId = rozId;
        }

        public int RozId;
        public bool SavedSucessfull = false;

        public FrmKsiegowanie(Rozliczenie roz) : base(roz)
        {
            InitializeComponent();
        }
        public FrmKsiegowanie(ISession session, Rozliczenie roz) : base(session, roz)
        {
            InitializeComponent();
        }

        public override void General_LoadData()
        {
            LoadItemById(RozId);

            if (!CurrentItem.Rachunek.Data.HasValue)
            {
                CurrentItem.Rachunek.Data = DateTime.Now;
            }
            if (CurrentItem.Rachunek.PodatekProcent == 0)
                CurrentItem.Rachunek.PodatekProcent = 19;


            MainBindingSrc.DataSource = CurrentItem;

            ucKsiegowanie.LoadData(binder);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool forceFlush = true;

            if (SaveItem(forceFlush))
            {
                SavedSucessfull = true; //parent wyciaga sobie dane z tej formatki, jesli zapisano OK
                this.Close();
            }
                

        }
    }
}

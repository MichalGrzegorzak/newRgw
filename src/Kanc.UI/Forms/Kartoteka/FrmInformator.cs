using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Kanc.Core.Entities;
using NHibernate;

namespace Kanc.UI.Forms.Modalne
{
    /// <summary>
    /// wybor 3 dokumentow i proste przenoszenie dancyh
    /// </summary>
    public partial class FrmInformator : SimpleForm
    {
        public FrmInformator()
        {
            InitializeComponent();
        }
        public FrmInformator(Rozliczenie roz) : base(roz)
        {
            InitializeComponent();
        }
        public FrmInformator(ISession session, Rozliczenie roz) : base(session, roz)
        {
            InitializeComponent();
        }

        public override void General_LoadData()
        {
            string w = "";
        }
    }
}

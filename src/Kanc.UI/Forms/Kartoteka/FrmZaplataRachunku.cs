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
    /// formatka do budowania odpowiedzi
    /// </summary>
    public partial class FrmZaplataRachunku : SimpleForm
    {
        public FrmZaplataRachunku(Rozliczenie roz) : base(roz)
        {
            InitializeComponent();
        }

        public FrmZaplataRachunku(ISession session, Rozliczenie roz) : base(session, roz)
        {
            InitializeComponent();
        }

        public override void General_LoadData()
        {
            string w = "";
        }
    }
}

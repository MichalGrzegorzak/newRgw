using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;
using Kanc.Core;
using Kanc.Core.Entities;
using NHibernate;

namespace Kanc.UI.Forms
{
    public partial class FrmKontoBankowe : BaseFormSessionRozlicz
    {
        public FrmKontoBankowe()
        {
            InitializeComponent();
        }
        public FrmKontoBankowe(ISession session, Rozliczenie roz) : base(session, roz)
        {
            InitializeComponent();
        }

        private MultiLabelWithInput multi = null;

        protected override void InitForm()
        {
            //binder null ???
            
        }

        protected override void BindControlsOnForm()
        {
            //base.BindControlsOnForm();
            multi = new MultiLabelWithInput(groupBox1, binder, new Point(15, 23), 100, 60);
            multi.TextBoxSize = new Size(250, 40);
            multi.Add(new LabelWithInput(binder, "Numer banku:").Bind(x => x.Konto.KontoWlasciciel));
            multi.Add(new LabelWithInput(binder, "Numer konta:").Bind(x => x.Konto.BankAdres));
            multi.Add(new LabelWithInput(binder, "IBAN:").Bind(x => x.Konto.BankAdres));
            multi.Add(new LabelWithInput(binder, "Nazwisko i imię:").Bind(x => x.Konto.BankAdres));

            multi.Init();
        }
    }

    public class MultiLabelWithInput
    {
        public Binder binder;
        //public int startX;
        //public int startY;
        //public int offsetX = 50;
        public int offsetY = 30;
        public Point startLabel;
        public Point startTextBox;
        public Control Parent;

        public Size LabelSize = new Size(90, 15);
        public Size TextBoxSize = new Size(250, 20);


        //private List<string> _labelki = new List<string>();
        List<LabelWithInput> Labels = new List<LabelWithInput>();

        public void Add(LabelWithInput s)
        {
            Labels.Add(s);
        }

        public MultiLabelWithInput(Control parent, Binder binder, Point startLabel, int oddalenie, int przesuniecieWdol = 30)
        {
            this.binder = binder;
            this.startLabel = startLabel;
            this.startTextBox = new Point(startLabel.X + oddalenie, startLabel.Y - 3);
            this.Parent = parent;
            this.offsetY = przesuniecieWdol;
        }

        public void Init()
        {
            foreach (LabelWithInput lbl in Labels)
            {
                lbl.labelsList[0].Location = startLabel;
                lbl.labelsList[0].Size = LabelSize;
                lbl.labelsList[0].Name = "lbl_1_" + startLabel.Y;
                lbl.labelsList[0].Name = "txt_1_" + startLabel.Y;
                Parent.Controls.Add(lbl.labelsList[0]);

                if (lbl.HasTwo)
                {
                    var newLoc = new Point(startLabel.X, startLabel.Y + 15);

                    lbl.labelsList[1].Location = newLoc;
                    lbl.labelsList[1].Size = LabelSize;
                    lbl.labelsList[1].Name = "lbl_2_" + startLabel.Y;
                    lbl.labelsList[1].Name = "txt_2_" + startLabel.Y;
                    Parent.Controls.Add(lbl.labelsList[1]);
                }

                lbl.txtBox.Size = TextBoxSize;
                lbl.txtBox.Location = startTextBox;
                Parent.Controls.Add(lbl.txtBox);

                //move both lower
                startLabel.Offset(0, offsetY); //move lower
                startTextBox.Offset(0, offsetY);
            }
        }

    }

    public class LabelWithInput
    {
        private Binder binder;
        //private var expression;

        public LabelWithInput(Binder bind, params string[] labelText)
        {
            foreach (string s in labelText)
            {
                labelsList.Add(new Label() { Text = s, TextAlign = ContentAlignment.MiddleCenter});
            }
            //label.Location = pLabel;
            //txtBox.Location = pTextBox;

            this.binder = bind;
        }

        public LabelWithInput Bind<TProperty>(Expression<Func<Rozliczenie, TProperty>> expression)
        {
            binder.BindRozlicz(txtBox, expression);
            return this;
        }

        public List<Label> labelsList = new List<Label>();
        public TextBox txtBox = new TextBox();

        public bool HasTwo
        {
            get { return labelsList.Count == 2; }
            
        }
    }
}

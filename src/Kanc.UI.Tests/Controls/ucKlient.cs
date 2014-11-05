using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Kanc.UI.Tests;
using NHibernate.Validator.Binding;
//using OX.Strongbind;

namespace Kanc.UI.Tests.Controls
{
    public partial class ucKlient : UserControl
    {
        public ucKlient()
        {
            InitializeComponent();
        }



        static void SetAllProperty(object source, ControlCollection controls)
        {
            Type type = source.GetType();
            foreach (PropertyInfo info in type.GetProperties())
            {
                //if (info.GetCustomAttributes(typeof(TextProperyAttribute), true).Length > 0)
                foreach (Control control in controls)
                {
                    if(control.Name.StartsWith(info.Name, StringComparison.OrdinalIgnoreCase))
                    {
                        control.Text = info.GetValue(source, null).ToString();
                        //if(control.Name.Contains("TextBox"))
                        //MOZNA BY ZROBIC BINDING Z REFLEKSJI ALE
                        //control.DataBindings.Add("Text", source, "Klint.Urodz", true, DataSourceUpdateMode.OnPropertyChanged);
                    }
                }
            }

        }

        public void AttachValidation(SmartViewValidator validator)
        {
            validator.Bind(imieTextBox, typeof(Klient_A), "Name");
            validator.Bind(idTextBox, typeof(Klient_A), "Id");
            validator.Bind(urodzDateTimePicker, typeof(Klient_A), "Urodz");
            
            //validator.Bind(krajIdTextBox, typeof(Kraj_A), "Id");
            //validator.Bind(txtSkrot, typeof(Kraj_A), "Skrot");
            //validator.Bind(txtNazwaEU, typeof(Kraj_A), "NazwaEU");
            //validator.Bind(txtNazwaPL, typeof(Kraj_A), "NazwaPL");

            //txtSkrot.Validating += new EventValidation(validator).ValidatingHandler;
            //validator.Bind(typeof (Klient))
            //    .With(idTextBox)
            //    .With(imieTextBox);
        }

        public void LoadData(BindingSource source)
        {
            //SetAllProperty(source.Current as Rozliczenie, Controls);

//            krajeDDL1.DataBindings.Add("SetValue", source, GetMemberName((Rozliczenie r) => r.Kraj_A), true, DataSourceUpdateMode.OnPropertyChanged);

            //BEZ BINDERA
            //urodzDateTimePicker.DataBindings.Add("Text", source, GetMemberName((Klient_A r) => r.Urodz), true, DataSourceUpdateMode.OnPropertyChanged);
            //idTextBox.DataBindings.Add("Text", source, GetMemberName((Klient_A r) => r.Id), true, DataSourceUpdateMode.OnPropertyChanged);
            //imieTextBox.DataBindings.Add("Text", source, GetMemberName((Klient_A r) => r.Name), true, DataSourceUpdateMode.OnPropertyChanged);
            
            //krajIdTextBox.DataBindings.Add("Text", source, GetMemberName((Klient_A r) => r.KrajA.Id), true, DataSourceUpdateMode.OnPropertyChanged);
            //txtSkrot.DataBindings.Add("Text", source, GetMemberName((Klient_A r) => r.KrajA.Name), true, DataSourceUpdateMode.OnPropertyChanged);
            //txtNazwaEU.DataBindings.Add("Text", source, GetMemberName((Klient_A r) => r.KrajA.NazwaEU), true, DataSourceUpdateMode.OnPropertyChanged);
            //txtNazwaPL.DataBindings.Add("Text", source, GetMemberName((Klient_A r) => r.KrajA.NazwaPL), true, DataSourceUpdateMode.OnPropertyChanged);
            
            //STRONGBIND
            //IRozliczenie biznesObj = source.Current as Rozliczenie;
            //// Create binding scope to start binding
            //using (BindingScope binder = new BindingScope())
            //{
            //    // Declare binding source to use when binding
            //    IRozliczenie source = binder.CreateSource(biznesObj);

            //    // Declare binding target to use when binding
            //    TextBox textBox1Proxy = binder.CreateTarget(textBox1);

            //    // Bind
            //    binder.Bind(source.Imie).To(textBox1Proxy.Text);
            //    //binder.Bind(source.Selected).To(target.Checked);
            //}
        }
    }
}

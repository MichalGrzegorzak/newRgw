using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Kanc.Commons;
using Kanc.Commons;

namespace Kanc.Commons
{
    public class KrajeTest2DDL : GenericEnumDDL<EmailTemplate>
    {
    }

    [DefaultBindingProperty("SetValue")]
    public class GenericEnumDDL<T> : ComboBox
        where T : IEmailTemplate
    {
        private static IEmailTemplate item;

        public GenericEnumDDL()
        {
            this.DropDownStyle = ComboBoxStyle.DropDownList;
            this.ValueMember = "numericKey";
            this.DisplayMember = "Value"; //value lub key = Polska or PL - ustaw na designerze

            if (!typeof(IEmailTemplate).IsInterface)
                throw new Exception("dfds");

            if (item == null)
            {
                item = Activator.CreateInstance<T>();
            }
        }

        private bool _isLoaded = false;
        public void LoadData()
        {
            if (_isLoaded) 
                return;

           
            IList list = item.GetNames();
            
            foreach (var obj in list)
            {
                this.Items.Add(obj);
            }
            _isLoaded = true;
        }

        [Browsable(true)]
        public bool DisplayShortcut
        {
            set
            {
                if (value == true)
                    this.DisplayMember = "Key";
            }
        }

        [System.ComponentModel.Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public T SetValue
        {
            get
            {
                if (SelectedIndex == -1) //jak to sie moze bindowac w ogole
                    SelectedIndex = 0;

                string name = this.Items[SelectedIndex].ToString();
                IEmailTemplate v = item.Parse2(name);
                return (T)v;
            }
            set
            {
                LoadData();

                IEmailTemplate cc = value;
                int i = 0;
                foreach (var o in Items)
                {
                    string s = o.ToString();
                    if (s == cc.GetName(cc.Val))
                        this.SelectedIndex = i;
                    i++;
                }
            }
        }

    }
}



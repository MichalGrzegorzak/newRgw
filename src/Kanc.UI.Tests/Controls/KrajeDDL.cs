using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Kanc.UI.Tests;

namespace Kanc.UI.Tests.Controls
{
    [DefaultBindingProperty("SetValue")]
    public class KrajeDDL : ComboBox
    {
        public KrajeDDL() : base()
        {
            this.DropDownStyle = ComboBoxStyle.DropDownList;
            this.ValueMember = "numericKey";
            this.DisplayMember = "Value";
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
        public Kraje? SetValue
        {
            get
            {
                Enum k = ((KeyValueTriplet<Enum, int, string>)this.Items[SelectedIndex]).Key;
                return (Kraje)k;
            }
            set
            {
               
                if(Items.Count == 0) //loading itemsow z enuma
                {
                    IList list = typeof(Kraje).ToExtendedList<int>();
                    foreach (var obj in list)
                    {
                        this.Items.Add(obj);
                    }
                }
                

                this.SelectedIndex = GetIndex((int)value.Value);
            }
        }

        private int GetIndex(int enumValue)
        {
            int i = 0;
            foreach (var item in this.Items)
            {
                KeyValueTriplet<Enum, int, string> krj = (KeyValueTriplet<Enum, int, string>)item;
                if (krj.NumericKey == enumValue)
                    return i;
                i++;
            }
            return 0;
        }

    }
}



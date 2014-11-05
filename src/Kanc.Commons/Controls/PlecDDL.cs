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

namespace Kanc.Commons
{
    [DefaultBindingProperty("SetValue")]
    public class PlecDDL : ComboBox
    {
        public PlecDDL() : base()
        {
            this.DropDownStyle = ComboBoxStyle.DropDownList;
            this.ValueMember = "numericKey";
            this.DisplayMember = "Value";
        }

        private int _lastSelectedIndex;
        private bool _isLoaded = false;
        public void LoadData()
        {
            if (_isLoaded)
                return;

            IList list = typeof(Plec).ToExtendedList<int>();
            foreach (var obj in list)
            {
                this.Items.Add(obj);
            }
            this.SelectedIndex = _lastSelectedIndex = 1;
            _isLoaded = true;
        }

        [System.ComponentModel.Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Plec SetValue
        {
            get
            {
                Enum k = ((KeyValueTriplet<Enum, int, string>)this.Items[SelectedIndex]).Key;
                return (Plec)k;
            }
            set
            {
                LoadData();
                //if (Items.Count == 0) //loading itemsow z enuma
                //{
                //    IList list = typeof(Plec).ToExtendedList<int>();
                //    foreach (var obj in list)
                //    {
                //        this.Items.Add(obj);
                //    }
                //}


                this.SelectedIndex = GetIndex((int)value);
                //int val = (int) value - 1;
                //this.SelectedIndex = val;
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



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
    
    [DefaultBindingProperty("SetValue")]
    public class KrajeBankiDDL : ComboBox
    {
        public KrajeBankiDDL() : base()
        {
            this.DropDownStyle = ComboBoxStyle.DropDownList;
            this.ValueMember = "numericKey";
            this.DisplayMember = "Value"; //value lub key = Polska or PL - ustaw na designerze
        }

        private int _lastSelectedIndex;
        private bool _isLoaded = false;
        public void LoadData()
        {
            if (_isLoaded) 
                return;

            IList list = typeof(KrajeBanki).ToExtendedList<int>();
            foreach (var obj in list)
            {
                this.Items.Add(obj);
            }
            this.SelectedIndex = _lastSelectedIndex = 1;
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
        public KrajeBanki SetValue
        {
            get
            {
               if(this.Items.Count == 0)
                   return KrajeBanki.brak;

               if (SelectedIndex == -1) //jak to sie moze bindowac w ogole
                    SelectedIndex = 0;

                Enum k = ((KeyValueTriplet<Enum, int, string>)this.Items[SelectedIndex]).Key;
                return (KrajeBanki)k;
            }
            set
            {
                LoadData();

                int val = (int) value - 1;
                if (_lastSelectedIndex != val) //nie wiem czemu wola to ze 4 razy
                {
                    this.SelectedIndex = val;
                    _lastSelectedIndex = val;
                }
            }
        }

    }
}



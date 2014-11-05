using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kanc.Commons
{
    [DefaultBindingProperty("SetValue")]
    public class TypyListGrpBox : RadioGroupBox
    {
        public TypyListGrpBox() : base()
        {
            this.Width = 200;
            this.Height = 250;
            this.Text = "Wybór listy";
        }

        private bool _isLoaded = false;
        public void LoadData()
        {
            if (_isLoaded)
                return;

            Array enumValues = Enum.GetValues(typeof(TypListy));
            foreach (Enum value in enumValues)
            {
                int idx = (int)((TypListy)value);
                AddRadioButton("RadioButton", value.ToString(), idx);
            }
            _isLoaded = true;
        }

        [System.ComponentModel.Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public TypListy SetValue
        {
            get
            {
                if (Selected == -1) //jak to sie moze bindowac w ogole
                    Selected = 0;

                Array enumValues = Enum.GetValues(typeof (TypListy));
                foreach (Enum value in enumValues)
                {
                    int val = (int) (TypListy) value;
                    if (val == Selected)
                        return (TypListy) value;
                }
                return (TypListy) enumValues.GetValue(0);
            }
            set
            {
                LoadData();

                int val = (int)value - 1;
                Selected = val;
            }
        }

        

       


   }
}


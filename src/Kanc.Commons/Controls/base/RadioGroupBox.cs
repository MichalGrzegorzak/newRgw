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
   public class RadioGroupBox : GroupBox
   {
        public event EventHandler SelectedChanged = delegate { };

        public RadioGroupBox()
        {
        }

        private int _countButton = 0;
        int _selected;
        public int Selected
        {
            get
            {
                return _selected;
            }
            set
            {
                int val = 0;
                var radioButton = this.Controls.OfType<RadioButton>()
                    .FirstOrDefault(radio =>
                        radio.Tag != null 
                       && int.TryParse(radio.Tag.ToString(), out val) && val == value);

                if (radioButton != null)
                {
                    radioButton.Checked = true;
                    _selected = val;
                }
            }
        }

        #region rzucamy event SelectedChanged
        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);

            var radioButton = e.Control as RadioButton;
            if (radioButton != null)
                radioButton.CheckedChanged += radioButton_CheckedChanged;
        }

        protected void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            var radio = (RadioButton)sender;
            int val = 0;
            if (radio.Checked && radio.Tag != null
                 && int.TryParse(radio.Tag.ToString(), out val))
            {
                _selected = val;
                SelectedChanged(this, new EventArgs());
            }
        } 
        #endregion

        protected void AddRadioButton(string name, string text, object tag)
        {
            RadioButton rdo = new RadioButton();
            rdo.Name = name + _countButton;
            rdo.Text = text;
            rdo.Tag = tag;

            rdo.Location = new Point(5, (30 * _countButton) + 30);
            rdo.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            rdo.AutoSize = true;
            this.Controls.Add(rdo);
            _countButton++;
        }

    }
}


﻿using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace Kanc.MVP.UIControls
{
    public class MaskedDateTextBox : MaskedTextBox
    {
        // Set up custom event to handle invalid entry:
        public delegate void InvalidDateEntryHandler(object sender, InvalidDateTextEventArgs e);
        public event InvalidDateEntryHandler InvalidDateEntered;

        // Default setting is to require a valid date string before allowing 
        // the user to navigate away from the control:
        public bool _RequireValidEntry = true;

        private string DateSeparator = "-";

        // The default mask is traditional - dd/mm/yyyy format. 
        private const string DEFAULT_MASK = "00/00/0000";
        private const char DEFAULT_PROMPT = '_';

        // A flag is set when control initialization is complete. This 
        // will be used to determine if the Mask property of the control
        // (inherited from the Base class) can be changed. 
        private bool _Initialized = false;


        public MaskedDateTextBox() : this(true) { }


        public MaskedDateTextBox(bool RequireValidEntry = true) : base()
        {
            // This is the only mask that will work in the current implementation:
            Mask = DEFAULT_MASK;
            PromptChar = DEFAULT_PROMPT;

            // Handle Events:
            Enter +=new EventHandler(MaskedDateTextBox_SelectAllOnEnter);
            PreviewKeyDown +=new PreviewKeyDownEventHandler(MaskedDateBox_PreviewKeyDown);

            DateSeparator = Thread.CurrentThread.CurrentCulture.DateTimeFormat.DateSeparator;

            // prevent further changes to the mask:
            _Initialized = true;
        }


        /// <summary>
        /// This control is based on text entry of dates in mm/dd/yyyy format. Other masks
        /// are not allowed at this time. 
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMaskChanged(EventArgs e)
        {
            if (_Initialized)
            {
                throw new NotImplementedException("The Mask is not chageable in this control");
            }
        }


        /// <summary>
        /// Adjust the text entry to maintain proper date string formatting. 
        /// </summary>
        /// <param name="dateTextBox"></param>
        void CorrectDateText(MaskedTextBox dateTextBox)
        {
            // Replace any odd date separators with the mm/dd/yyyy Standard:
            Regex rgx = new Regex(@"(\\|-|\.)");
            string FormattedDate = rgx.Replace(dateTextBox.Text, @"/");

            // Separate the date components as delimmited by standard mm/dd/yyyy formatting:
            string[] dateComponents = FormattedDate.Split('/');
            string day = dateComponents[0].Trim();
            string month = dateComponents[1].Trim(); ;
            string year = dateComponents[2].Trim();

            // We require a two-digit month. If there is only one digit, add a leading zero:
            if (month.Length == 1)
                month = "0" + month;

            // We require a two-digit day. If there is only one digit, add a leading zero:
            if (day.Length == 1)
                day = "0" + day;

            // We require a four-digit year. If there are only two digits, add 
            // two digits denoting the current century as leading numerals:
            if (year.Length == 2)
                year = "19" + year;

            // Put the date back together again with proper delimiters, and 
            dateTextBox.Text = day + "/" + month + "/" + year;
        }


        /// <summary>
        /// Test for entry of common date-delimiting characters, and apply adjustment as needed to 
        /// maintain proper date formatting:
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void MaskedDateBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            MaskedTextBox txt = (MaskedTextBox)sender;

            // Check for common date delimiting characters. When encountered, 
            // adjust the text entry for proper date formatting:
            if (e.KeyCode == Keys.Divide
                || e.KeyCode == Keys.Oem5
                || e.KeyCode == Keys.OemQuestion
                || e.KeyCode == Keys.OemPeriod
                || e.KeyValue == 190
                || e.KeyValue == 110)

                // If any of the above key values are encountered, apply a formatting 
                // check to the text entered so far, and make adjustments as needed. 
                CorrectDateText(txt);
        }

        public bool IsValid
        {
            get { return DateHelper.ValidateDate(Text.Trim(), DateSeparator); }
        }

        protected override void OnLeave(EventArgs e)
        {
            // Perform a final adjustment of the text entry to fit the mm/dd/yyyy format:
            CorrectDateText(this);

            // If the entry is a valid date, fire the leave event. We are done here. 
            if (IsValid)
            {
                base.OnLeave(e);
            }
            else
            {
                OnInvalidDateEntry(this, new InvalidDateTextEventArgs(this.Text.Trim()));

                // if a valid date entry is not required, the user is free to navigate away
                // from the control:
                if (!_RequireValidEntry)
                {
                    base.OnLeave(e);
                }
            }
        }


        protected virtual void OnInvalidDateEntry(object sender, InvalidDateTextEventArgs e)
        {
            if (_RequireValidEntry)
            {
                // Force the user to address the problem before navigating away from the control:
                MessageBox.Show(e.Message);
                this.Focus();
                this.MaskedDateTextBox_SelectAllOnEnter(this, new EventArgs());
            }

            // Raise the invalid entry event either way. Client code can determine if and
            // how invalid entry should be dealt with:
            if (InvalidDateEntered != null)
                InvalidDateEntered(this, e);
        }


        /// <summary>
        /// Gets or sets a boolean value indicating whether a valid date string is required
        /// in order to leave the control. Default is true. Invalid date strings which are not empty will
        /// force the user to correct the issue before navigating away from the MaskedDateTextBox. 
        /// </summary>
        public bool RequireValidEntry
        {
            get { return _RequireValidEntry; }
            set { _RequireValidEntry = value; }
        }


        /// <summary>
        /// Required to address a flaw in the implementation of the base MaskedTextBox control provided
        /// with the .net framework. Allows automatic selection of text within the control while the 
        /// mask is set. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void MaskedDateTextBox_SelectAllOnEnter(object sender, EventArgs e)
        {
            MaskedTextBox m = (MaskedTextBox)sender;
            this.BeginInvoke((MethodInvoker)delegate()
            {
                m.SelectAll();
            });
        }


        public DateTime? DateValue
        {
            get
            {
                DateTime d;
                DateTime? Result = null;
                if (DateTime.TryParseExact(Text, "dd-MM-yyyy",
                                               CultureInfo.InvariantCulture,
                                               DateTimeStyles.None,
                                               out d))
                {
                    Result = d;
                }
                return Result;
            }
            set 
            {
                string DateString = "";
                if (value.HasValue)
                    DateString = value.Value.ToString("dd-MM-yyyy");
                Text = DateString;
            }
        }
    }

    public class InvalidDateTextEventArgs : EventArgs
    {
        private string _Message = ""
            + "Text does not resolve to a valid date. "
            + "Enter a date in dd-MM-yyyy format, or clear the text to represent an empty date.";

        private string _InvalidDateString = "";


        public InvalidDateTextEventArgs(string InvalidDateString)
        {
            _InvalidDateString = InvalidDateString;
        }


        public InvalidDateTextEventArgs(string InvalidDateString, string Message)
            : this(InvalidDateString)
        {
            _Message = Message;
        }


        public String Message
        {
            get { return _Message; }
            set { _Message = value; }
        }

        public String InvalidDateString
        {
            get { return _InvalidDateString; }
        }

    }
}

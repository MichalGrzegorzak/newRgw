using System;
using System.Windows.Forms;
using Utils.Extensions;
using Utils.Features.TypesParsing;

namespace Kanc.MVP.Controls
{
    public class MaskedTextBoxExt : MaskedTextBox
    {
        public MaskedTextBoxExt() : base()
        {
            //EnableFormatDate();
        }

        public DateTime? Date
        {
            get
            {
                DateTime result = this.Text.ParseSafe<DateTime>();
                if (result == default(DateTime))
                    return null;
                return result;
            }
            set
            {
                this.Text = value.IfValueThenShortDate();
            }
        }

        //public void EnableFormatDate()
        //{
        //    FormatDate(this);
        //}

        //public static void FormatDate(MaskedTextBox c) {
        //    c.DataBindings[0].Format += new ConvertEventHandler(Date_Format);
        //    c.DataBindings[0].Parse += new ConvertEventHandler(Date_Parse);
        //}

        //private static void Date_Format(object sender, ConvertEventArgs e) {
        //    if (e.Value == null)
        //        e.Value = "";
        //    else
        //        e.Value = ((DateTime)e.Value).ToString("MM/dd/yyyy");
        //}

        //static void Date_Parse(object sender, ConvertEventArgs e) {
        //    if (e.Value.ToString() == "  /  /")
        //        e.Value = null;
        //}


    }
}

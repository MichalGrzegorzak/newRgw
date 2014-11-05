using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;
using System.Windows.Forms;
using System.Configuration;
using Kanc.Core.Features.Raporty;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Font = System.Drawing.Font;

namespace Kanc.Core.Features
{
    public class RaportGenerator
    {
        private static log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public RaportGenerator()
        {
            SaveDialogFilter = "txt files (*.pdf)|*.pdf|All files (*.*)|*.*";
        }

        #region report settings

        public string ReportPath { get; set; }
        public string InitialFolderToSave { get; set; }
        public string SaveDialogFilter { get; set; }

        //public TypRaportu Typ { get; set; }
        //public string Rok { get; set; }
        //public RptLang Jezyk { get; set; }
        //public IDictionary<string, string> FieldsToFill { get; set; }

        #endregion

        #region methods

        public void GenerateReport(IRaport raport)
        {
            //Stream myStream;
            //SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            //saveFileDialog1.Filter = SaveDialogFilter;
            //saveFileDialog1.InitialDirectory = InitialFolderToSave;
            //saveFileDialog1.FilterIndex = 2;
            //saveFileDialog1.RestoreDirectory = true;
            //if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            //if ((myStream = saveFileDialog1.OpenFile()) != null)


            //BaseFont bfR = BaseFont.CreateFont("C:\\Windows\\Fonts\\ARIALUNI.TTF", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA_OBLIQUE, BaseFont.CP1257, BaseFont.EMBEDDED);
            //var fontTimes = FontFactory.GetFont(BaseFont.COURIER, BaseFont.CP1257, 12, iTextSharp.text.Font.NORMAL);
            //FontFactory.Register("C:\\Windows\\Fonts\\ARIALUNI.TTF", "arial unicode ms");
            //Font fnt = FontFactory.GetFont(FontFactory.HELVETICA, "CP1250", iTextSharp.text.Font.NORMAL, new Color(0, 0, 0));

            string path = Directory.GetCurrentDirectory() + ReportPath + raport.ResolveReportPath();
                    
            using (PdfMaker maker = new PdfMaker(path, @"C:\druk\" + raport.FileName))
            {
                AcroFields af = maker.AcroFields; // retrieve properties of PDF form w/AcroFields object
                // fill in PDF fields by parameter -> field name / text to insert
                //var keys = af.GetAppearanceStates("rbZonatyTak");
                foreach (KeyValuePair<string, string> item in raport.Fields)
                {
                    //if (item.Key.Contains("rbZonaty"))
                    //{ string g = "dsf"; }

                    af.SetFieldProperty(item.Key, "textfont", bf, null); //kolejnosc jest wazna!!!
                    af.SetField(item.Key, item.Value);
                }

                maker.Stamper.FormFlattening = true; // make resultant PDF read-only for end-user
                // forget to close() PdfStamper, you end up with a corrupted file!
            }
        }

        //private string ResolveName(TypRaportu typRaportu, string rok, RptLang jezyk)
        //{
        //    string rokRaportu = string.Empty;
        //    if (rok != null)
        //    {
        //        rokRaportu = "_" + rok;
        //    }

        //    string jezykRaportu = string.Empty;
        //    switch (jezyk)
        //    {
        //        case RptLang.Polski:
        //            jezykRaportu = "_1";
        //            break;
        //        case RptLang.Obcy:
        //            jezykRaportu = "_2";
        //            break;
        //        case RptLang.PolskiIObcy:
        //            jezykRaportu = "_3";
        //            break;
        //    }

        //    string reportKey = string.Empty;

        //    switch (typRaportu)
        //    {
        //        case TypRaportu.EuEwr:
        //            reportKey = "EUEWR" + rokRaportu + jezykRaportu;
        //            break;
        //        case TypRaportu.PodatekNiemcy:
        //            reportKey = "PodatekNiemcy" + rokRaportu + jezykRaportu;
        //            break;
        //        case TypRaportu.StronaNiemcy:
        //            reportKey = "StronaNiemcy" + rokRaportu + jezykRaportu;
        //            break;
        //        default:
        //            break;
        //    }

        //    var reportName = ConfigurationSettings.AppSettings[reportKey];
        //    return reportName;
        //}

        #endregion
    }
}

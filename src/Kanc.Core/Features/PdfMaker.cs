using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Kanc.Core.Features
{
    public class PdfMaker : IDisposable
    {
        private static log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private Stream fileStream = null;
        public PdfStamper Stamper = null;
        private PdfReader reader = null;

        public AcroFields AcroFields
        {
            get { return Stamper.AcroFields; }
        }

        public PdfMaker(string readPdfPath, string writeToPath)
        {
            if (!File.Exists(readPdfPath))
            {
                log.Error("Nie znaleziono pliku raportu: " + readPdfPath);
                throw new Exception("Nie znaleziono pliku: " + readPdfPath);
            }
            
            reader = new PdfReader(readPdfPath);
            fileStream = File.Create(writeToPath);
            Stamper = new PdfStamper(reader, fileStream);
        }
        
        public void Dispose()
        {
            reader.Close();
            Stamper.Close();
            fileStream.Close();
        }
    }
}

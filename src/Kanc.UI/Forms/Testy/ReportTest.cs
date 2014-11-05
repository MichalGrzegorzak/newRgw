using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Threading;


namespace Kanc.UI.Forms
{
    public partial class ReportTest : BaseForm
    {
        public ReportTest()
        {
            InitializeComponent();
        }

        private System.IO.Stream streamToPrint;

        private void printDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            System.Drawing.Image image = Image.FromFile(@"c:\combined.jpg");
                //System.Drawing.Image.FromStream(this.streamToPrint); //pozniej stream

            e.PageSettings.Landscape = false;
            int x = e.MarginBounds.X; ;
            int y = e.MarginBounds.Y;
            int width = image.Width;
            int height = image.Height;
           
            int nWidth = 763; //approx pixel dimensions of A4 763
            int nHeight = 1084; // approx pixel dimensions of A4
            System.Drawing.Rectangle destRect = new System.Drawing.Rectangle(35, 35, nWidth, nHeight);
            e.Graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, System.Drawing.GraphicsUnit.Pixel);
        }

        private void ScrollMe(int offset)
        {
            Point t = AutoScrollOffset;
            this.AutoScrollPosition = new Point(0, (AutoScrollPosition.Y)*-1 + offset);
            this.Refresh();
            Thread.Sleep(200);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.BorderStyle = BorderStyle.None;
                }
                if (c is Button)
                {
                    c.Visible = false;
                }
            }
            Refresh();
            Thread.Sleep(200);

            //var dlg = new PrintDialog();
            //if (dlg.ShowDialog() == DialogResult.OK)
            //{
            //    printForm1.PrinterSettings = dlg.PrinterSettings;
            //    printForm1.Print(this, PrintForm.PrintOption.FullWindow);
            //}
            
            Rectangle ctlR = panel1.ClientRectangle;				//   get rectangle in control coordinates
            int bitmapsCount = (int)(panel1.ClientRectangle.Height / ClientRectangle.Height);
            List<string> fileNames = new List<string>();
            for (int i = 0; i < bitmapsCount; i++)
            {
                Bitmap b1 = Commons.DLL.Capture.Window(this.Handle, ctlR);
                string file = "c:\\" + i + ".jpg";
                fileNames.Add(file);
                b1.Save(file, ImageFormat.Jpeg);
                if (i + 1 < bitmapsCount)
                    ScrollMe(ClientRectangle.Height);
            }

            Bitmap bAll = Combine(fileNames.ToArray());
            bAll.Save("c:\\combined.jpg", ImageFormat.Jpeg);
            //return;

            //zapodawac memoryStream`a
            StartPrint(new MemoryStream());
        }

        public static System.Drawing.Bitmap Combine(string[] files)
        {
            //read all images into memory
            List<System.Drawing.Bitmap> images = new List<System.Drawing.Bitmap>();
            System.Drawing.Bitmap finalImage = null;

            try
            {
                int width = 0;
                int height = 0;

                foreach (string image in files)
                {
                    //create a Bitmap from the file and add it to the list
                    System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(image);

                    //update the size of the final bitmap
                    //width += bitmap.Width;
                    //height = bitmap.Height > height ? bitmap.Height : height;

                    width = bitmap.Width;
                    height = bitmap.Height;

                    images.Add(bitmap);
                }

                //create a bitmap to hold the combined image
                finalImage = new System.Drawing.Bitmap(width, height);

                //get a graphics object from the image so we can draw on it
                using (System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(finalImage))
                {
                    //set background color
                    g.Clear(System.Drawing.Color.Black);

                    //go through each image and draw it on the final image
                    int offset = 0;
                    foreach (System.Drawing.Bitmap image in images)
                    {
                        g.DrawImage(image,
                          new System.Drawing.Rectangle(0, offset, image.Width, image.Height));
                        offset += 572;
                    }
                }

                return finalImage;
            }
            catch (Exception ex)
            {
                if (finalImage != null)
                    finalImage.Dispose();

                throw ex;
            }
            finally
            {
                //clean up memory
                foreach (System.Drawing.Bitmap image in images)
                {
                    image.Dispose();
                }
            }
            return finalImage;
        }

        public void StartPrint(Stream streamToPrint)
        {
            this.printDoc.PrintPage += new PrintPageEventHandler(printDoc_PrintPage);
            this.streamToPrint = streamToPrint;

            System.Windows.Forms.PrintDialog PrintDialog1 = new PrintDialog();
            PrintDialog1.AllowSomePages = true;
            PrintDialog1.ShowHelp = true;
            PrintDialog1.Document = printDoc;
            DialogResult result = PrintDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDoc.Print();
                //docToPrint.Print();
            }
        }


    }
}

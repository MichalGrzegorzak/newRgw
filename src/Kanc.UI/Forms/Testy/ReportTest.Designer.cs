namespace Kanc.UI.Forms
{
    partial class ReportTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportTest));
            this.lblImie = new System.Windows.Forms.Label();
            this.lblNazwisko = new System.Windows.Forms.Label();
            this.lblUrodzony = new System.Windows.Forms.Label();
            this.txb1 = new System.Windows.Forms.TextBox();
            this.txtKodPocztowy = new System.Windows.Forms.TextBox();
            this.txbUlica = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDoc = new System.Drawing.Printing.PrintDocument();
            this.btnPrint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblImie
            // 
            this.lblImie.AutoSize = true;
            this.lblImie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblImie.Location = new System.Drawing.Point(57, 279);
            this.lblImie.Name = "lblImie";
            this.lblImie.Size = new System.Drawing.Size(69, 24);
            this.lblImie.TabIndex = 0;
            this.lblImie.Text = "Michał";
            // 
            // lblNazwisko
            // 
            this.lblNazwisko.AutoSize = true;
            this.lblNazwisko.BackColor = System.Drawing.Color.Transparent;
            this.lblNazwisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazwisko.Location = new System.Drawing.Point(57, 229);
            this.lblNazwisko.Name = "lblNazwisko";
            this.lblNazwisko.Size = new System.Drawing.Size(106, 24);
            this.lblNazwisko.TabIndex = 1;
            this.lblNazwisko.Text = "Grzegorzak";
            // 
            // lblUrodzony
            // 
            this.lblUrodzony.AutoSize = true;
            this.lblUrodzony.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUrodzony.Location = new System.Drawing.Point(57, 330);
            this.lblUrodzony.Name = "lblUrodzony";
            this.lblUrodzony.Size = new System.Drawing.Size(102, 24);
            this.lblUrodzony.TabIndex = 2;
            this.lblUrodzony.Text = "30-12-1981";
            // 
            // txb1
            // 
            this.txb1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txb1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txb1.Location = new System.Drawing.Point(59, 375);
            this.txb1.Name = "txb1";
            this.txb1.Size = new System.Drawing.Size(496, 22);
            this.txb1.TabIndex = 8;
            this.txb1.Text = "jakieś miasto";
            // 
            // txtKodPocztowy
            // 
            this.txtKodPocztowy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtKodPocztowy.Location = new System.Drawing.Point(59, 424);
            this.txtKodPocztowy.Name = "txtKodPocztowy";
            this.txtKodPocztowy.Size = new System.Drawing.Size(496, 29);
            this.txtKodPocztowy.TabIndex = 9;
            this.txtKodPocztowy.Text = "kod pocztowy";
            // 
            // txbUlica
            // 
            this.txbUlica.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txbUlica.Location = new System.Drawing.Point(59, 474);
            this.txbUlica.Name = "txbUlica";
            this.txbUlica.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txbUlica.Size = new System.Drawing.Size(496, 29);
            this.txbUlica.TabIndex = 10;
            this.txbUlica.Text = "jakaś ulica 23/1";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1103, 1750);
            this.panel1.TabIndex = 11;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(0, 0);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 12;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // ReportTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1138, 573);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txbUlica);
            this.Controls.Add(this.txtKodPocztowy);
            this.Controls.Add(this.txb1);
            this.Controls.Add(this.lblUrodzony);
            this.Controls.Add(this.lblNazwisko);
            this.Controls.Add(this.lblImie);
            this.Controls.Add(this.panel1);
            this.Name = "ReportTest";
            this.Text = "ReportTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblImie;
        private System.Windows.Forms.Label lblNazwisko;
        private System.Windows.Forms.Label lblUrodzony;
        private System.Windows.Forms.TextBox txb1;
        private System.Windows.Forms.TextBox txtKodPocztowy;
        private System.Windows.Forms.TextBox txbUlica;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDoc;
        private System.Windows.Forms.Button btnPrint;
    }
}
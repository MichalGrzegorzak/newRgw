namespace Kanc.UI.Ctrl
{
    partial class ucRachunekPodglad
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOdeslanie = new System.Windows.Forms.Button();
            this.ZaplataButton = new System.Windows.Forms.Button();
            this.KsiegowanieButton = new System.Windows.Forms.Button();
            this.DoZaplatyTextBox = new System.Windows.Forms.TextBox();
            this.RechnungsbetragTextBox = new System.Windows.Forms.TextBox();
            this.UmsatzsteuerTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BetragTextBox = new System.Windows.Forms.TextBox();
            this.NrRachunkuTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ucForListaZaplat1 = new ucForListaZaplat();
            this.SuspendLayout();
            // 
            // btnOdeslanie
            // 
            this.btnOdeslanie.Location = new System.Drawing.Point(351, 180);
            this.btnOdeslanie.Name = "btnOdeslanie";
            this.btnOdeslanie.Size = new System.Drawing.Size(133, 23);
            this.btnOdeslanie.TabIndex = 12;
            this.btnOdeslanie.Text = "Odesłanie rachunku";
            this.btnOdeslanie.UseVisualStyleBackColor = true;
            this.btnOdeslanie.Click += new System.EventHandler(this.OdeslanieButton_Click);
            // 
            // ZaplataButton
            // 
            this.ZaplataButton.Location = new System.Drawing.Point(351, 113);
            this.ZaplataButton.Name = "ZaplataButton";
            this.ZaplataButton.Size = new System.Drawing.Size(133, 23);
            this.ZaplataButton.TabIndex = 11;
            this.ZaplataButton.Text = "Zapłata rachunku";
            this.ZaplataButton.UseVisualStyleBackColor = true;
            this.ZaplataButton.Click += new System.EventHandler(this.ZaplataButton_Click);
            // 
            // KsiegowanieButton
            // 
            this.KsiegowanieButton.Location = new System.Drawing.Point(351, 25);
            this.KsiegowanieButton.Name = "KsiegowanieButton";
            this.KsiegowanieButton.Size = new System.Drawing.Size(133, 23);
            this.KsiegowanieButton.TabIndex = 10;
            this.KsiegowanieButton.Text = "Księgowanie";
            this.KsiegowanieButton.UseVisualStyleBackColor = true;
            this.KsiegowanieButton.Click += new System.EventHandler(this.KsiegowanieButton_Click);
            // 
            // DoZaplatyTextBox
            // 
            this.DoZaplatyTextBox.Enabled = false;
            this.DoZaplatyTextBox.Location = new System.Drawing.Point(133, 116);
            this.DoZaplatyTextBox.Name = "DoZaplatyTextBox";
            this.DoZaplatyTextBox.Size = new System.Drawing.Size(124, 20);
            this.DoZaplatyTextBox.TabIndex = 9;
            // 
            // RechnungsbetragTextBox
            // 
            this.RechnungsbetragTextBox.Enabled = false;
            this.RechnungsbetragTextBox.Location = new System.Drawing.Point(133, 93);
            this.RechnungsbetragTextBox.Name = "RechnungsbetragTextBox";
            this.RechnungsbetragTextBox.Size = new System.Drawing.Size(124, 20);
            this.RechnungsbetragTextBox.TabIndex = 8;
            // 
            // UmsatzsteuerTextBox
            // 
            this.UmsatzsteuerTextBox.Enabled = false;
            this.UmsatzsteuerTextBox.Location = new System.Drawing.Point(133, 69);
            this.UmsatzsteuerTextBox.Name = "UmsatzsteuerTextBox";
            this.UmsatzsteuerTextBox.Size = new System.Drawing.Size(124, 20);
            this.UmsatzsteuerTextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Do zapłaty:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Rechnungsbetrag:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "+19% Umsatzsteuer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Betrag:";
            // 
            // BetragTextBox
            // 
            this.BetragTextBox.Enabled = false;
            this.BetragTextBox.Location = new System.Drawing.Point(133, 47);
            this.BetragTextBox.Name = "BetragTextBox";
            this.BetragTextBox.Size = new System.Drawing.Size(124, 20);
            this.BetragTextBox.TabIndex = 2;
            // 
            // NrRachunkuTextBox
            // 
            this.NrRachunkuTextBox.Location = new System.Drawing.Point(133, 25);
            this.NrRachunkuTextBox.Name = "NrRachunkuTextBox";
            this.NrRachunkuTextBox.Size = new System.Drawing.Size(124, 20);
            this.NrRachunkuTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numer rachunku:";
            // 
            // ucForListaZaplat1
            // 
            this.ucForListaZaplat1.Binder = null;
            this.ucForListaZaplat1.Location = new System.Drawing.Point(6, 155);
            this.ucForListaZaplat1.Name = "ucForListaZaplat1";
            this.ucForListaZaplat1.Session = null;
            this.ucForListaZaplat1.Size = new System.Drawing.Size(228, 48);
            this.ucForListaZaplat1.TabIndex = 15;
            // 
            // ucRachunekPodglad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucForListaZaplat1);
            this.Controls.Add(this.btnOdeslanie);
            this.Controls.Add(this.ZaplataButton);
            this.Controls.Add(this.KsiegowanieButton);
            this.Controls.Add(this.DoZaplatyTextBox);
            this.Controls.Add(this.RechnungsbetragTextBox);
            this.Controls.Add(this.UmsatzsteuerTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BetragTextBox);
            this.Controls.Add(this.NrRachunkuTextBox);
            this.Controls.Add(this.label1);
            this.Name = "ucRachunekPodglad";
            this.Size = new System.Drawing.Size(510, 226);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NrRachunkuTextBox;
        private System.Windows.Forms.TextBox BetragTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox UmsatzsteuerTextBox;
        private System.Windows.Forms.TextBox RechnungsbetragTextBox;
        private System.Windows.Forms.TextBox DoZaplatyTextBox;
        private System.Windows.Forms.Button KsiegowanieButton;
        private System.Windows.Forms.Button ZaplataButton;
        private System.Windows.Forms.Button btnOdeslanie;
        private ucForListaZaplat ucForListaZaplat1;
    }
}

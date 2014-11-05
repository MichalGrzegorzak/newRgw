using Kanc.Commons;

namespace Kanc.UI.Ctrl
{
    partial class ucKontoPodglad
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
            System.Windows.Forms.Label kontoLabel;
            System.Windows.Forms.Label skrotLabel;
            System.Windows.Forms.Label adresLabel;
            System.Windows.Forms.Label blzLabel;
            System.Windows.Forms.Label nazwaLabel;
            System.Windows.Forms.Label swiftLabel;
            this.krajeDDL1 = new Kanc.Commons.KrajeDDL();
            this.kontoLkTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.swiftCombo = new System.Windows.Forms.ComboBox();
            this.adresCombo = new System.Windows.Forms.ComboBox();
            this.nazwaCombo = new System.Windows.Forms.ComboBox();
            this.kontoTextBox = new System.Windows.Forms.TextBox();
            this.blzTextBox = new System.Windows.Forms.TextBox();
            kontoLabel = new System.Windows.Forms.Label();
            skrotLabel = new System.Windows.Forms.Label();
            adresLabel = new System.Windows.Forms.Label();
            blzLabel = new System.Windows.Forms.Label();
            nazwaLabel = new System.Windows.Forms.Label();
            swiftLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kontoLabel
            // 
            kontoLabel.AutoSize = true;
            kontoLabel.Location = new System.Drawing.Point(201, 13);
            kontoLabel.Name = "kontoLabel";
            kontoLabel.Size = new System.Drawing.Size(38, 13);
            kontoLabel.TabIndex = 63;
            kontoLabel.Text = "Konto:";
            // 
            // skrotLabel
            // 
            skrotLabel.AutoSize = true;
            skrotLabel.Location = new System.Drawing.Point(15, 13);
            skrotLabel.Name = "skrotLabel";
            skrotLabel.Size = new System.Drawing.Size(35, 13);
            skrotLabel.TabIndex = 62;
            skrotLabel.Text = "Skrot:";
            // 
            // adresLabel
            // 
            adresLabel.AutoSize = true;
            adresLabel.Location = new System.Drawing.Point(16, 106);
            adresLabel.Name = "adresLabel";
            adresLabel.Size = new System.Drawing.Size(37, 13);
            adresLabel.TabIndex = 55;
            adresLabel.Text = "Adres:";
            // 
            // blzLabel
            // 
            blzLabel.AutoSize = true;
            blzLabel.Location = new System.Drawing.Point(95, 13);
            blzLabel.Name = "blzLabel";
            blzLabel.Size = new System.Drawing.Size(24, 13);
            blzLabel.TabIndex = 56;
            blzLabel.Text = "Blz:";
            // 
            // nazwaLabel
            // 
            nazwaLabel.AutoSize = true;
            nazwaLabel.Location = new System.Drawing.Point(136, 61);
            nazwaLabel.Name = "nazwaLabel";
            nazwaLabel.Size = new System.Drawing.Size(43, 13);
            nazwaLabel.TabIndex = 60;
            nazwaLabel.Text = "Nazwa:";
            // 
            // swiftLabel
            // 
            swiftLabel.AutoSize = true;
            swiftLabel.Location = new System.Drawing.Point(15, 61);
            swiftLabel.Name = "swiftLabel";
            swiftLabel.Size = new System.Drawing.Size(33, 13);
            swiftLabel.TabIndex = 61;
            swiftLabel.Text = "Swift:";
            // 
            // krajeDDL1
            // 
            this.krajeDDL1.DisplayMember = "Key";
            this.krajeDDL1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.krajeDDL1.FormattingEnabled = true;
            this.krajeDDL1.Location = new System.Drawing.Point(19, 29);
            this.krajeDDL1.Name = "krajeDDL1";
            this.krajeDDL1.Size = new System.Drawing.Size(40, 21);
            this.krajeDDL1.TabIndex = 71;
            this.krajeDDL1.ValueMember = "numericKey";
            // 
            // kontoLkTextBox
            // 
            this.kontoLkTextBox.Location = new System.Drawing.Point(65, 29);
            this.kontoLkTextBox.Name = "kontoLkTextBox";
            this.kontoLkTextBox.Size = new System.Drawing.Size(29, 20);
            this.kontoLkTextBox.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 69;
            this.label1.Text = "Lk";
            // 
            // swiftCombo
            // 
            this.swiftCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.swiftCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.swiftCombo.FormattingEnabled = true;
            this.swiftCombo.Location = new System.Drawing.Point(19, 77);
            this.swiftCombo.Name = "swiftCombo";
            this.swiftCombo.Size = new System.Drawing.Size(104, 21);
            this.swiftCombo.TabIndex = 68;
            // 
            // adresCombo
            // 
            this.adresCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.adresCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.adresCombo.FormattingEnabled = true;
            this.adresCombo.Location = new System.Drawing.Point(18, 122);
            this.adresCombo.Name = "adresCombo";
            this.adresCombo.Size = new System.Drawing.Size(416, 21);
            this.adresCombo.TabIndex = 67;
            // 
            // nazwaCombo
            // 
            this.nazwaCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.nazwaCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.nazwaCombo.FormattingEnabled = true;
            this.nazwaCombo.Location = new System.Drawing.Point(139, 77);
            this.nazwaCombo.Name = "nazwaCombo";
            this.nazwaCombo.Size = new System.Drawing.Size(295, 21);
            this.nazwaCombo.TabIndex = 66;
            // 
            // kontoTextBox
            // 
            this.kontoTextBox.Location = new System.Drawing.Point(204, 30);
            this.kontoTextBox.Name = "kontoTextBox";
            this.kontoTextBox.Size = new System.Drawing.Size(230, 20);
            this.kontoTextBox.TabIndex = 64;
            // 
            // blzTextBox
            // 
            this.blzTextBox.Location = new System.Drawing.Point(98, 30);
            this.blzTextBox.Name = "blzTextBox";
            this.blzTextBox.Size = new System.Drawing.Size(100, 20);
            this.blzTextBox.TabIndex = 57;
            // 
            // ucKontoPodglad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.krajeDDL1);
            this.Controls.Add(this.kontoLkTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.swiftCombo);
            this.Controls.Add(this.adresCombo);
            this.Controls.Add(this.nazwaCombo);
            this.Controls.Add(kontoLabel);
            this.Controls.Add(this.kontoTextBox);
            this.Controls.Add(skrotLabel);
            this.Controls.Add(adresLabel);
            this.Controls.Add(blzLabel);
            this.Controls.Add(this.blzTextBox);
            this.Controls.Add(nazwaLabel);
            this.Controls.Add(swiftLabel);
            this.Name = "ucKontoPodglad";
            this.Size = new System.Drawing.Size(450, 162);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KrajeDDL krajeDDL1;
        private System.Windows.Forms.TextBox kontoLkTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox swiftCombo;
        private System.Windows.Forms.ComboBox adresCombo;
        private System.Windows.Forms.ComboBox nazwaCombo;
        private System.Windows.Forms.TextBox kontoTextBox;
        private System.Windows.Forms.TextBox blzTextBox;
    }
}

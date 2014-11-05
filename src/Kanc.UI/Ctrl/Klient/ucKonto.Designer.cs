using Kanc.Commons;

namespace Kanc.UI.Ctrl
{
    partial class ucKonto
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
            System.Windows.Forms.Label adresLabel;
            System.Windows.Forms.Label blzLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nazwaLabel;
            System.Windows.Forms.Label swiftLabel;
            System.Windows.Forms.Label skrotLabel;
            System.Windows.Forms.Label kontoLabel;
            this.blzTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.kontoTextBox = new System.Windows.Forms.TextBox();
            this.btnDodajBank = new System.Windows.Forms.Button();
            this.nazwaCombo = new System.Windows.Forms.TextBox();
            this.adresCombo = new System.Windows.Forms.TextBox();
            this.swiftCombo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.kontoLkTextBox = new System.Windows.Forms.TextBox();
            this.krajeBankiDDL1 = new Kanc.Commons.KrajeBankiDDL();
            adresLabel = new System.Windows.Forms.Label();
            blzLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            nazwaLabel = new System.Windows.Forms.Label();
            swiftLabel = new System.Windows.Forms.Label();
            skrotLabel = new System.Windows.Forms.Label();
            kontoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // adresLabel
            // 
            adresLabel.AutoSize = true;
            adresLabel.Location = new System.Drawing.Point(120, 48);
            adresLabel.Name = "adresLabel";
            adresLabel.Size = new System.Drawing.Size(37, 13);
            adresLabel.TabIndex = 1;
            adresLabel.Text = "Adres:";
            // 
            // blzLabel
            // 
            blzLabel.AutoSize = true;
            blzLabel.Location = new System.Drawing.Point(83, 0);
            blzLabel.Name = "blzLabel";
            blzLabel.Size = new System.Drawing.Size(24, 13);
            blzLabel.TabIndex = 3;
            blzLabel.Text = "Blz:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(343, 20);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 5;
            idLabel.Text = "Id:";
            // 
            // nazwaLabel
            // 
            nazwaLabel.AutoSize = true;
            nazwaLabel.Location = new System.Drawing.Point(4, 48);
            nazwaLabel.Name = "nazwaLabel";
            nazwaLabel.Size = new System.Drawing.Size(43, 13);
            nazwaLabel.TabIndex = 7;
            nazwaLabel.Text = "Nazwa:";
            // 
            // swiftLabel
            // 
            swiftLabel.AutoSize = true;
            swiftLabel.Location = new System.Drawing.Point(264, 48);
            swiftLabel.Name = "swiftLabel";
            swiftLabel.Size = new System.Drawing.Size(33, 13);
            swiftLabel.TabIndex = 9;
            swiftLabel.Text = "Swift:";
            // 
            // skrotLabel
            // 
            skrotLabel.AutoSize = true;
            skrotLabel.Location = new System.Drawing.Point(3, 0);
            skrotLabel.Name = "skrotLabel";
            skrotLabel.Size = new System.Drawing.Size(35, 13);
            skrotLabel.TabIndex = 17;
            skrotLabel.Text = "Skrot:";
            // 
            // kontoLabel
            // 
            kontoLabel.AutoSize = true;
            kontoLabel.Location = new System.Drawing.Point(189, 0);
            kontoLabel.Name = "kontoLabel";
            kontoLabel.Size = new System.Drawing.Size(38, 13);
            kontoLabel.TabIndex = 19;
            kontoLabel.Text = "Konto:";
            // 
            // blzTextBox
            // 
            this.blzTextBox.Location = new System.Drawing.Point(86, 17);
            this.blzTextBox.Name = "blzTextBox";
            this.blzTextBox.Size = new System.Drawing.Size(100, 20);
            this.blzTextBox.TabIndex = 4;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(377, 17);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(45, 20);
            this.idTextBox.TabIndex = 6;
            // 
            // kontoTextBox
            // 
            this.kontoTextBox.Location = new System.Drawing.Point(192, 17);
            this.kontoTextBox.Name = "kontoTextBox";
            this.kontoTextBox.Size = new System.Drawing.Size(134, 20);
            this.kontoTextBox.TabIndex = 20;
            // 
            // btnDodajBank
            // 
            this.btnDodajBank.Location = new System.Drawing.Point(377, 64);
            this.btnDodajBank.Name = "btnDodajBank";
            this.btnDodajBank.Size = new System.Drawing.Size(45, 23);
            this.btnDodajBank.TabIndex = 29;
            this.btnDodajBank.Text = "Dodaj bank";
            this.btnDodajBank.UseVisualStyleBackColor = true;
            this.btnDodajBank.Click += new System.EventHandler(this.btnDodajBank_Click);
            // 
            // nazwaCombo
            // 
            this.nazwaCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.nazwaCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.nazwaCombo.Location = new System.Drawing.Point(7, 64);
            this.nazwaCombo.Name = "nazwaCombo";
            this.nazwaCombo.Size = new System.Drawing.Size(100, 20);
            this.nazwaCombo.TabIndex = 30;
            // 
            // adresCombo
            // 
            this.adresCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.adresCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.adresCombo.Location = new System.Drawing.Point(123, 64);
            this.adresCombo.Name = "adresCombo";
            this.adresCombo.Size = new System.Drawing.Size(121, 20);
            this.adresCombo.TabIndex = 31;
            // 
            // swiftCombo
            // 
            this.swiftCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.swiftCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.swiftCombo.Location = new System.Drawing.Point(267, 64);
            this.swiftCombo.Name = "swiftCombo";
            this.swiftCombo.Size = new System.Drawing.Size(104, 20);
            this.swiftCombo.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Lk";
            // 
            // kontoLkTextBox
            // 
            this.kontoLkTextBox.Location = new System.Drawing.Point(53, 16);
            this.kontoLkTextBox.Name = "kontoLkTextBox";
            this.kontoLkTextBox.Size = new System.Drawing.Size(29, 20);
            this.kontoLkTextBox.TabIndex = 53;
            // 
            // krajeBankiDDL1
            // 
            this.krajeBankiDDL1.DisplayMember = "Key";
            this.krajeBankiDDL1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.krajeBankiDDL1.FormattingEnabled = true;
            this.krajeBankiDDL1.Location = new System.Drawing.Point(6, 15);
            this.krajeBankiDDL1.Name = "krajeBankiDDL1";
            this.krajeBankiDDL1.Size = new System.Drawing.Size(40, 21);
            this.krajeBankiDDL1.TabIndex = 55;
            this.krajeBankiDDL1.ValueMember = "numericKey";
            // 
            // ucKonto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.krajeBankiDDL1);
            this.Controls.Add(this.kontoLkTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.swiftCombo);
            this.Controls.Add(this.adresCombo);
            this.Controls.Add(this.nazwaCombo);
            this.Controls.Add(this.btnDodajBank);
            this.Controls.Add(kontoLabel);
            this.Controls.Add(this.kontoTextBox);
            this.Controls.Add(skrotLabel);
            this.Controls.Add(adresLabel);
            this.Controls.Add(blzLabel);
            this.Controls.Add(this.blzTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nazwaLabel);
            this.Controls.Add(swiftLabel);
            this.Name = "ucKonto";
            this.Size = new System.Drawing.Size(446, 103);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox blzTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox kontoTextBox;
        private System.Windows.Forms.Button btnDodajBank;
        private System.Windows.Forms.TextBox nazwaCombo;
        private System.Windows.Forms.TextBox adresCombo;
        private System.Windows.Forms.TextBox swiftCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kontoLkTextBox;
        private KrajeBankiDDL krajeBankiDDL1;
    }
}

using Kanc.Commons;

namespace Kanc.UI.Ctrl
{
    partial class ucRodzinaPodglad
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
            System.Windows.Forms.Label dzieciDatyLabel;
            System.Windows.Forms.Label dzieciLiczbaLabel;
            System.Windows.Forms.Label partnerWyznanieLabel;
            System.Windows.Forms.Label partnerUrodzLabel;
            System.Windows.Forms.Label partnerSlubLabel;
            System.Windows.Forms.Label partnerMandIdLabel;
            System.Windows.Forms.Label partnerImieLabel;
            this.dzieciDatyTextBox = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.partnerUrodzMaskedTextBoxExt = new Kanc.Commons.MaskedTextBoxExt();
            this.partnerSlubMaskedTextBoxExt = new Kanc.Commons.MaskedTextBoxExt();
            this.partnerWyznanieTextBox = new System.Windows.Forms.TextBox();
            this.partnerMandIdTextBox = new System.Windows.Forms.TextBox();
            this.partnerImieTextBox = new System.Windows.Forms.TextBox();
            dzieciDatyLabel = new System.Windows.Forms.Label();
            dzieciLiczbaLabel = new System.Windows.Forms.Label();
            partnerWyznanieLabel = new System.Windows.Forms.Label();
            partnerUrodzLabel = new System.Windows.Forms.Label();
            partnerSlubLabel = new System.Windows.Forms.Label();
            partnerMandIdLabel = new System.Windows.Forms.Label();
            partnerImieLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dzieciDatyLabel
            // 
            dzieciDatyLabel.AutoSize = true;
            dzieciDatyLabel.Location = new System.Drawing.Point(113, 115);
            dzieciDatyLabel.Name = "dzieciDatyLabel";
            dzieciDatyLabel.Size = new System.Drawing.Size(103, 13);
            dzieciDatyLabel.TabIndex = 25;
            dzieciDatyLabel.Text = "Daty urodzeń dzieci:";
            // 
            // dzieciLiczbaLabel
            // 
            dzieciLiczbaLabel.AutoSize = true;
            dzieciLiczbaLabel.Location = new System.Drawing.Point(15, 114);
            dzieciLiczbaLabel.Name = "dzieciLiczbaLabel";
            dzieciLiczbaLabel.Size = new System.Drawing.Size(73, 13);
            dzieciLiczbaLabel.TabIndex = 24;
            dzieciLiczbaLabel.Text = "Dzieci Liczba:";
            // 
            // partnerWyznanieLabel
            // 
            partnerWyznanieLabel.AutoSize = true;
            partnerWyznanieLabel.Location = new System.Drawing.Point(358, 14);
            partnerWyznanieLabel.Name = "partnerWyznanieLabel";
            partnerWyznanieLabel.Size = new System.Drawing.Size(94, 13);
            partnerWyznanieLabel.TabIndex = 20;
            partnerWyznanieLabel.Text = "Partner Wyznanie:";
            // 
            // partnerUrodzLabel
            // 
            partnerUrodzLabel.AutoSize = true;
            partnerUrodzLabel.Location = new System.Drawing.Point(220, 14);
            partnerUrodzLabel.Name = "partnerUrodzLabel";
            partnerUrodzLabel.Size = new System.Drawing.Size(75, 13);
            partnerUrodzLabel.TabIndex = 19;
            partnerUrodzLabel.Text = "Partner Urodz:";
            // 
            // partnerSlubLabel
            // 
            partnerSlubLabel.AutoSize = true;
            partnerSlubLabel.Location = new System.Drawing.Point(13, 63);
            partnerSlubLabel.Name = "partnerSlubLabel";
            partnerSlubLabel.Size = new System.Drawing.Size(188, 13);
            partnerSlubLabel.TabIndex = 18;
            partnerSlubLabel.Text = "Data zawarcia związku małżeńskiego:";
            // 
            // partnerMandIdLabel
            // 
            partnerMandIdLabel.AutoSize = true;
            partnerMandIdLabel.Location = new System.Drawing.Point(358, 64);
            partnerMandIdLabel.Name = "partnerMandIdLabel";
            partnerMandIdLabel.Size = new System.Drawing.Size(124, 13);
            partnerMandIdLabel.TabIndex = 15;
            partnerMandIdLabel.Text = "Numer Mand. małżonka:";
            // 
            // partnerImieLabel
            // 
            partnerImieLabel.AutoSize = true;
            partnerImieLabel.Location = new System.Drawing.Point(13, 14);
            partnerImieLabel.Name = "partnerImieLabel";
            partnerImieLabel.Size = new System.Drawing.Size(66, 13);
            partnerImieLabel.TabIndex = 14;
            partnerImieLabel.Text = "Partner Imie:";
            // 
            // dzieciDatyTextBox
            // 
            this.dzieciDatyTextBox.Location = new System.Drawing.Point(116, 131);
            this.dzieciDatyTextBox.Name = "dzieciDatyTextBox";
            this.dzieciDatyTextBox.Size = new System.Drawing.Size(366, 20);
            this.dzieciDatyTextBox.TabIndex = 27;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Location = new System.Drawing.Point(16, 131);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(54, 20);
            this.numericUpDown1.TabIndex = 26;
            // 
            // partnerUrodzMaskedTextBoxExt
            // 
            this.partnerUrodzMaskedTextBoxExt.Date = null;
            this.partnerUrodzMaskedTextBoxExt.Location = new System.Drawing.Point(223, 30);
            this.partnerUrodzMaskedTextBoxExt.Name = "partnerUrodzMaskedTextBoxExt";
            this.partnerUrodzMaskedTextBoxExt.Size = new System.Drawing.Size(100, 20);
            this.partnerUrodzMaskedTextBoxExt.TabIndex = 23;
            this.partnerUrodzMaskedTextBoxExt.Text = "0001-01-01";
            // 
            // partnerSlubMaskedTextBoxExt
            // 
            this.partnerSlubMaskedTextBoxExt.Date = null;
            this.partnerSlubMaskedTextBoxExt.Location = new System.Drawing.Point(16, 79);
            this.partnerSlubMaskedTextBoxExt.Name = "partnerSlubMaskedTextBoxExt";
            this.partnerSlubMaskedTextBoxExt.Size = new System.Drawing.Size(100, 20);
            this.partnerSlubMaskedTextBoxExt.TabIndex = 22;
            this.partnerSlubMaskedTextBoxExt.Text = "0001-01-01";
            // 
            // partnerWyznanieTextBox
            // 
            this.partnerWyznanieTextBox.Location = new System.Drawing.Point(361, 30);
            this.partnerWyznanieTextBox.Name = "partnerWyznanieTextBox";
            this.partnerWyznanieTextBox.Size = new System.Drawing.Size(91, 20);
            this.partnerWyznanieTextBox.TabIndex = 21;
            // 
            // partnerMandIdTextBox
            // 
            this.partnerMandIdTextBox.Location = new System.Drawing.Point(361, 80);
            this.partnerMandIdTextBox.Name = "partnerMandIdTextBox";
            this.partnerMandIdTextBox.Size = new System.Drawing.Size(121, 20);
            this.partnerMandIdTextBox.TabIndex = 17;
            // 
            // partnerImieTextBox
            // 
            this.partnerImieTextBox.Location = new System.Drawing.Point(16, 30);
            this.partnerImieTextBox.Name = "partnerImieTextBox";
            this.partnerImieTextBox.Size = new System.Drawing.Size(185, 20);
            this.partnerImieTextBox.TabIndex = 16;
            // 
            // ucRodzinaPodglad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.partnerSlubMaskedTextBoxExt);
            this.Controls.Add(this.partnerWyznanieTextBox);
            this.Controls.Add(this.partnerUrodzMaskedTextBoxExt);
            this.Controls.Add(this.partnerMandIdTextBox);
            this.Controls.Add(this.partnerImieTextBox);
            this.Controls.Add(this.dzieciDatyTextBox);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(dzieciDatyLabel);
            this.Controls.Add(dzieciLiczbaLabel);
            this.Controls.Add(partnerWyznanieLabel);
            this.Controls.Add(partnerUrodzLabel);
            this.Controls.Add(partnerSlubLabel);
            this.Controls.Add(partnerMandIdLabel);
            this.Controls.Add(partnerImieLabel);
            this.Name = "ucRodzinaPodglad";
            this.Size = new System.Drawing.Size(507, 178);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaskedTextBoxExt partnerUrodzMaskedTextBoxExt;
        private MaskedTextBoxExt partnerSlubMaskedTextBoxExt;
        private System.Windows.Forms.TextBox partnerWyznanieTextBox;
        private System.Windows.Forms.TextBox partnerMandIdTextBox;
        private System.Windows.Forms.TextBox partnerImieTextBox;
        private System.Windows.Forms.TextBox dzieciDatyTextBox;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

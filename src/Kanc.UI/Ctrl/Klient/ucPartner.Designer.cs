

using Kanc.Commons;

namespace Kanc.UI.Ctrl
{
    partial class ucPartner
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
            System.Windows.Forms.Label partnerImieLabel;
            System.Windows.Forms.Label partnerMandIdLabel;
            System.Windows.Forms.Label partnerSlubLabel;
            System.Windows.Forms.Label partnerUrodzLabel;
            System.Windows.Forms.Label partnerWyznanieLabel;
            this.partnerImieTextBox = new System.Windows.Forms.TextBox();
            this.partnerMandIdTextBox = new System.Windows.Forms.TextBox();
            this.partnerWyznanieTextBox = new System.Windows.Forms.TextBox();
            this.partnerSlubMaskedTextBoxExt = new Kanc.Commons.MaskedTextBoxExt();
            this.partnerUrodzMaskedTextBoxExt = new Kanc.Commons.MaskedTextBoxExt();
            partnerImieLabel = new System.Windows.Forms.Label();
            partnerMandIdLabel = new System.Windows.Forms.Label();
            partnerSlubLabel = new System.Windows.Forms.Label();
            partnerUrodzLabel = new System.Windows.Forms.Label();
            partnerWyznanieLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // partnerImieLabel
            // 
            partnerImieLabel.AutoSize = true;
            partnerImieLabel.Location = new System.Drawing.Point(3, 6);
            partnerImieLabel.Name = "partnerImieLabel";
            partnerImieLabel.Size = new System.Drawing.Size(66, 13);
            partnerImieLabel.TabIndex = 1;
            partnerImieLabel.Text = "Partner Imie:";
            // 
            // partnerMandIdLabel
            // 
            partnerMandIdLabel.AutoSize = true;
            partnerMandIdLabel.Location = new System.Drawing.Point(229, 29);
            partnerMandIdLabel.Name = "partnerMandIdLabel";
            partnerMandIdLabel.Size = new System.Drawing.Size(86, 13);
            partnerMandIdLabel.TabIndex = 2;
            partnerMandIdLabel.Text = "Partner Mand Id:";
            // 
            // partnerSlubLabel
            // 
            partnerSlubLabel.AutoSize = true;
            partnerSlubLabel.Location = new System.Drawing.Point(112, 45);
            partnerSlubLabel.Name = "partnerSlubLabel";
            partnerSlubLabel.Size = new System.Drawing.Size(68, 13);
            partnerSlubLabel.TabIndex = 4;
            partnerSlubLabel.Text = "Partner Slub:";
            // 
            // partnerUrodzLabel
            // 
            partnerUrodzLabel.AutoSize = true;
            partnerUrodzLabel.Location = new System.Drawing.Point(112, 6);
            partnerUrodzLabel.Name = "partnerUrodzLabel";
            partnerUrodzLabel.Size = new System.Drawing.Size(75, 13);
            partnerUrodzLabel.TabIndex = 6;
            partnerUrodzLabel.Text = "Partner Urodz:";
            // 
            // partnerWyznanieLabel
            // 
            partnerWyznanieLabel.AutoSize = true;
            partnerWyznanieLabel.Location = new System.Drawing.Point(3, 45);
            partnerWyznanieLabel.Name = "partnerWyznanieLabel";
            partnerWyznanieLabel.Size = new System.Drawing.Size(94, 13);
            partnerWyznanieLabel.TabIndex = 8;
            partnerWyznanieLabel.Text = "Partner Wyznanie:";
            // 
            // partnerImieTextBox
            // 
            this.partnerImieTextBox.Location = new System.Drawing.Point(3, 22);
            this.partnerImieTextBox.Name = "partnerImieTextBox";
            this.partnerImieTextBox.Size = new System.Drawing.Size(100, 20);
            this.partnerImieTextBox.TabIndex = 2;
            // 
            // partnerMandIdTextBox
            // 
            this.partnerMandIdTextBox.Location = new System.Drawing.Point(232, 45);
            this.partnerMandIdTextBox.Name = "partnerMandIdTextBox";
            this.partnerMandIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.partnerMandIdTextBox.TabIndex = 3;
            // 
            // partnerWyznanieTextBox
            // 
            this.partnerWyznanieTextBox.Location = new System.Drawing.Point(3, 61);
            this.partnerWyznanieTextBox.Name = "partnerWyznanieTextBox";
            this.partnerWyznanieTextBox.Size = new System.Drawing.Size(100, 20);
            this.partnerWyznanieTextBox.TabIndex = 9;
            // 
            // partnerSlubMaskedTextBoxExt
            // 
            this.partnerSlubMaskedTextBoxExt.Date = null;
            this.partnerSlubMaskedTextBoxExt.Location = new System.Drawing.Point(115, 61);
            this.partnerSlubMaskedTextBoxExt.Name = "partnerSlubMaskedTextBoxExt";
            this.partnerSlubMaskedTextBoxExt.Size = new System.Drawing.Size(100, 20);
            this.partnerSlubMaskedTextBoxExt.TabIndex = 11;
            this.partnerSlubMaskedTextBoxExt.Text = "01/01/0001";
            // 
            // partnerUrodzMaskedTextBoxExt
            // 
            this.partnerUrodzMaskedTextBoxExt.Date = null;
            this.partnerUrodzMaskedTextBoxExt.Location = new System.Drawing.Point(115, 22);
            this.partnerUrodzMaskedTextBoxExt.Name = "partnerUrodzMaskedTextBoxExt";
            this.partnerUrodzMaskedTextBoxExt.Size = new System.Drawing.Size(100, 20);
            this.partnerUrodzMaskedTextBoxExt.TabIndex = 13;
            this.partnerUrodzMaskedTextBoxExt.Text = "01/01/0001";
            // 
            // ucPartner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.partnerUrodzMaskedTextBoxExt);
            this.Controls.Add(this.partnerSlubMaskedTextBoxExt);
            this.Controls.Add(partnerWyznanieLabel);
            this.Controls.Add(this.partnerWyznanieTextBox);
            this.Controls.Add(partnerUrodzLabel);
            this.Controls.Add(partnerSlubLabel);
            this.Controls.Add(partnerMandIdLabel);
            this.Controls.Add(this.partnerMandIdTextBox);
            this.Controls.Add(partnerImieLabel);
            this.Controls.Add(this.partnerImieTextBox);
            this.Name = "ucPartner";
            this.Size = new System.Drawing.Size(347, 108);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox partnerImieTextBox;
        private System.Windows.Forms.TextBox partnerMandIdTextBox;
        private System.Windows.Forms.TextBox partnerWyznanieTextBox;
        private MaskedTextBoxExt partnerSlubMaskedTextBoxExt;
        private MaskedTextBoxExt partnerUrodzMaskedTextBoxExt;
    }
}

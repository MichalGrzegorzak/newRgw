namespace Kanc.UI.Ctrl
{
    partial class ucWlascicielKonta
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
            System.Windows.Forms.Label kontoWlascicielLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucWlascicielKonta));
            this.kontoWlascicielTextBox = new System.Windows.Forms.TextBox();
            this.wlascicielKontaDDL1 = new Kanc.Commons.WlascicielKontaDDL();
            kontoWlascicielLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kontoWlascicielLabel
            // 
            kontoWlascicielLabel.AutoSize = true;
            kontoWlascicielLabel.Location = new System.Drawing.Point(130, 6);
            kontoWlascicielLabel.Name = "kontoWlascicielLabel";
            kontoWlascicielLabel.Size = new System.Drawing.Size(88, 13);
            kontoWlascicielLabel.TabIndex = 1;
            kontoWlascicielLabel.Text = "Wlasciciel konta:";
            // 
            // kontoWlascicielTextBox
            // 
            this.kontoWlascicielTextBox.Location = new System.Drawing.Point(225, 4);
            this.kontoWlascicielTextBox.Name = "kontoWlascicielTextBox";
            this.kontoWlascicielTextBox.Size = new System.Drawing.Size(302, 20);
            this.kontoWlascicielTextBox.TabIndex = 2;
            // 
            // wlascicielKontaDDL1
            // 
            this.wlascicielKontaDDL1.DisplayMember = "Value";
            this.wlascicielKontaDDL1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.wlascicielKontaDDL1.FormattingEnabled = true;
            this.wlascicielKontaDDL1.Location = new System.Drawing.Point(3, 3);
            this.wlascicielKontaDDL1.Name = "wlascicielKontaDDL1";
            this.wlascicielKontaDDL1.Size = new System.Drawing.Size(121, 21);
            this.wlascicielKontaDDL1.TabIndex = 4;
            this.wlascicielKontaDDL1.ValueMember = "numericKey";
            // 
            // ucWlascicielKonta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.wlascicielKontaDDL1);
            this.Controls.Add(kontoWlascicielLabel);
            this.Controls.Add(this.kontoWlascicielTextBox);
            this.Name = "ucWlascicielKonta";
            this.Size = new System.Drawing.Size(530, 28);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kontoWlascicielTextBox;
        private Commons.WlascicielKontaDDL wlascicielKontaDDL1;
    }
}

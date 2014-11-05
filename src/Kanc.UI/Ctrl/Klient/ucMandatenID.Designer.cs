namespace Kanc.UI.Ctrl.Klient
{
    partial class ucMandatenID
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
            System.Windows.Forms.Label mandIdLabel;
            this.mIdTextBox = new System.Windows.Forms.TextBox();
            mandIdLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mIdTextBox
            // 
            this.mIdTextBox.Location = new System.Drawing.Point(59, 3);
            this.mIdTextBox.Name = "mIdTextBox";
            this.mIdTextBox.Size = new System.Drawing.Size(79, 20);
            this.mIdTextBox.TabIndex = 122;
            // 
            // mandIdLabel
            // 
            mandIdLabel.AutoSize = true;
            mandIdLabel.Location = new System.Drawing.Point(4, 6);
            mandIdLabel.Name = "mandIdLabel";
            mandIdLabel.Size = new System.Drawing.Size(49, 13);
            mandIdLabel.TabIndex = 121;
            mandIdLabel.Text = "Mand Id:";
            // 
            // ucMandatenID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mIdTextBox);
            this.Controls.Add(mandIdLabel);
            this.Name = "ucMandatenID";
            this.Size = new System.Drawing.Size(146, 29);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mIdTextBox;
    }
}

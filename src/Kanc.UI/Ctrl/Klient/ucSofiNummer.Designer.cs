namespace Kanc.UI.Ctrl.Klient
{
    partial class ucSofiNummer
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
            System.Windows.Forms.Label sofinummerLabel;
            this.sofinummerTextBox = new System.Windows.Forms.TextBox();
            sofinummerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sofinummerTextBox
            // 
            this.sofinummerTextBox.Location = new System.Drawing.Point(3, 22);
            this.sofinummerTextBox.Name = "sofinummerTextBox";
            this.sofinummerTextBox.Size = new System.Drawing.Size(144, 20);
            this.sofinummerTextBox.TabIndex = 122;
            // 
            // sofinummerLabel
            // 
            sofinummerLabel.AutoSize = true;
            sofinummerLabel.Location = new System.Drawing.Point(3, 6);
            sofinummerLabel.Name = "sofinummerLabel";
            sofinummerLabel.Size = new System.Drawing.Size(124, 13);
            sofinummerLabel.TabIndex = 121;
            sofinummerLabel.Text = "Steuemmer - Sofinummer";
            // 
            // ucSofiNummer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sofinummerTextBox);
            this.Controls.Add(sofinummerLabel);
            this.Name = "ucSofiNummer";
            this.Size = new System.Drawing.Size(150, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sofinummerTextBox;
    }
}

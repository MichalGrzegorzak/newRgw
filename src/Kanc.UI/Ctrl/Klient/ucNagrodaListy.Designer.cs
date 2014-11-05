namespace Kanc.UI.Ctrl
{
    partial class ucNagrodaListy
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
            System.Windows.Forms.Label zaplaconoLabel;
            System.Windows.Forms.Label statusLabel;
            this.zaplaconoTextBox = new System.Windows.Forms.TextBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            zaplaconoLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // zaplaconoLabel
            // 
            zaplaconoLabel.AutoSize = true;
            zaplaconoLabel.Location = new System.Drawing.Point(156, 6);
            zaplaconoLabel.Name = "zaplaconoLabel";
            zaplaconoLabel.Size = new System.Drawing.Size(61, 13);
            zaplaconoLabel.TabIndex = 2;
            zaplaconoLabel.Text = "Zaplacono:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(5, 7);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(40, 13);
            statusLabel.TabIndex = 4;
            statusLabel.Text = "Status:";
            // 
            // zaplaconoTextBox
            // 
            this.zaplaconoTextBox.Location = new System.Drawing.Point(223, 3);
            this.zaplaconoTextBox.Name = "zaplaconoTextBox";
            this.zaplaconoTextBox.Size = new System.Drawing.Size(80, 20);
            this.zaplaconoTextBox.TabIndex = 3;
            // 
            // statusTextBox
            // 
            this.statusTextBox.Location = new System.Drawing.Point(51, 3);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(80, 20);
            this.statusTextBox.TabIndex = 5;
            // 
            // ucNagrodaListy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(zaplaconoLabel);
            this.Controls.Add(this.zaplaconoTextBox);
            this.Name = "ucNagrodaListy";
            this.Size = new System.Drawing.Size(323, 31);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox zaplaconoTextBox;
        private System.Windows.Forms.TextBox statusTextBox;

    }
}



namespace Kanc.UI.Ctrl
{
    partial class ucDzieci
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
            System.Windows.Forms.Label dzieciLiczbaLabel;
            System.Windows.Forms.Label dzieciDatyLabel;
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dzieciDatyTextBox = new System.Windows.Forms.TextBox();
            dzieciLiczbaLabel = new System.Windows.Forms.Label();
            dzieciDatyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dzieciLiczbaLabel
            // 
            dzieciLiczbaLabel.AutoSize = true;
            dzieciLiczbaLabel.Location = new System.Drawing.Point(3, 0);
            dzieciLiczbaLabel.Name = "dzieciLiczbaLabel";
            dzieciLiczbaLabel.Size = new System.Drawing.Size(73, 13);
            dzieciLiczbaLabel.TabIndex = 1;
            dzieciLiczbaLabel.Text = "Dzieci Liczba:";
            // 
            // dzieciDatyLabel
            // 
            dzieciDatyLabel.AutoSize = true;
            dzieciDatyLabel.Location = new System.Drawing.Point(97, 0);
            dzieciDatyLabel.Name = "dzieciDatyLabel";
            dzieciDatyLabel.Size = new System.Drawing.Size(64, 13);
            dzieciDatyLabel.TabIndex = 3;
            dzieciDatyLabel.Text = "Dzieci Daty:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(6, 16);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(54, 20);
            this.numericUpDown1.TabIndex = 10;
            // 
            // dzieciDatyTextBox
            // 
            this.dzieciDatyTextBox.Location = new System.Drawing.Point(100, 16);
            this.dzieciDatyTextBox.Name = "dzieciDatyTextBox";
            this.dzieciDatyTextBox.Size = new System.Drawing.Size(371, 20);
            this.dzieciDatyTextBox.TabIndex = 12;
            // 
            // ucDzieci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dzieciDatyTextBox);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(dzieciDatyLabel);
            this.Controls.Add(dzieciLiczbaLabel);
            this.Name = "ucDzieci";
            this.Size = new System.Drawing.Size(487, 49);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox dzieciDatyTextBox;
    }
}

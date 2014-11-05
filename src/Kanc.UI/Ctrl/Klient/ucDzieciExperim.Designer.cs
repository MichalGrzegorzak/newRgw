

using Kanc.Commons;

namespace Kanc.UI.Ctrl
{
    partial class ucDzieciExperim
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
            this.maskedTextBoxExt1 = new Kanc.Commons.MaskedTextBoxExt();
            this.maskedTextBoxExt2 = new Kanc.Commons.MaskedTextBoxExt();
            this.maskedTextBoxExt3 = new Kanc.Commons.MaskedTextBoxExt();
            this.maskedTextBoxExt4 = new Kanc.Commons.MaskedTextBoxExt();
            this.maskedTextBoxExt5 = new Kanc.Commons.MaskedTextBoxExt();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.maskedTextBoxExt6 = new Kanc.Commons.MaskedTextBoxExt();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            // maskedTextBoxExt1
            // 
            this.maskedTextBoxExt1.Date = new System.DateTime(((long)(0)));
            this.maskedTextBoxExt1.Location = new System.Drawing.Point(100, 16);
            this.maskedTextBoxExt1.Name = "maskedTextBoxExt1";
            this.maskedTextBoxExt1.Size = new System.Drawing.Size(73, 20);
            this.maskedTextBoxExt1.TabIndex = 5;
            this.maskedTextBoxExt1.Visible = false;
            // 
            // maskedTextBoxExt2
            // 
            this.maskedTextBoxExt2.Date = new System.DateTime(((long)(0)));
            this.maskedTextBoxExt2.Location = new System.Drawing.Point(179, 16);
            this.maskedTextBoxExt2.Name = "maskedTextBoxExt2";
            this.maskedTextBoxExt2.Size = new System.Drawing.Size(73, 20);
            this.maskedTextBoxExt2.TabIndex = 6;
            this.maskedTextBoxExt2.Visible = false;
            // 
            // maskedTextBoxExt3
            // 
            this.maskedTextBoxExt3.Date = new System.DateTime(((long)(0)));
            this.maskedTextBoxExt3.Location = new System.Drawing.Point(258, 16);
            this.maskedTextBoxExt3.Name = "maskedTextBoxExt3";
            this.maskedTextBoxExt3.Size = new System.Drawing.Size(73, 20);
            this.maskedTextBoxExt3.TabIndex = 7;
            this.maskedTextBoxExt3.Visible = false;
            // 
            // maskedTextBoxExt4
            // 
            this.maskedTextBoxExt4.Date = new System.DateTime(((long)(0)));
            this.maskedTextBoxExt4.Location = new System.Drawing.Point(337, 16);
            this.maskedTextBoxExt4.Name = "maskedTextBoxExt4";
            this.maskedTextBoxExt4.Size = new System.Drawing.Size(73, 20);
            this.maskedTextBoxExt4.TabIndex = 8;
            this.maskedTextBoxExt4.Visible = false;
            // 
            // maskedTextBoxExt5
            // 
            this.maskedTextBoxExt5.Date = new System.DateTime(((long)(0)));
            this.maskedTextBoxExt5.Location = new System.Drawing.Point(416, 16);
            this.maskedTextBoxExt5.Name = "maskedTextBoxExt5";
            this.maskedTextBoxExt5.Size = new System.Drawing.Size(73, 20);
            this.maskedTextBoxExt5.TabIndex = 9;
            this.maskedTextBoxExt5.Visible = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(6, 16);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(54, 20);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // maskedTextBoxExt6
            // 
            this.maskedTextBoxExt6.Date = new System.DateTime(((long)(0)));
            this.maskedTextBoxExt6.Location = new System.Drawing.Point(495, 16);
            this.maskedTextBoxExt6.Name = "maskedTextBoxExt6";
            this.maskedTextBoxExt6.Size = new System.Drawing.Size(73, 20);
            this.maskedTextBoxExt6.TabIndex = 11;
            this.maskedTextBoxExt6.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(605, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(101, 20);
            this.textBox1.TabIndex = 12;
            // 
            // ucDzieciExperim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.maskedTextBoxExt6);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.maskedTextBoxExt5);
            this.Controls.Add(this.maskedTextBoxExt4);
            this.Controls.Add(this.maskedTextBoxExt3);
            this.Controls.Add(this.maskedTextBoxExt2);
            this.Controls.Add(this.maskedTextBoxExt1);
            this.Controls.Add(dzieciDatyLabel);
            this.Controls.Add(dzieciLiczbaLabel);
            this.Name = "ucDzieciExperim";
            this.Size = new System.Drawing.Size(724, 45);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaskedTextBoxExt maskedTextBoxExt1;
        private MaskedTextBoxExt maskedTextBoxExt2;
        private MaskedTextBoxExt maskedTextBoxExt3;
        private MaskedTextBoxExt maskedTextBoxExt4;
        private MaskedTextBoxExt maskedTextBoxExt5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private MaskedTextBoxExt maskedTextBoxExt6;
        private System.Windows.Forms.TextBox textBox1;
    }
}

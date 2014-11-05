namespace Kanc.UI.Forms.Kartoteka.KlientPodglad
{
    partial class ucID_Mandaten_Rok
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
            System.Windows.Forms.Label idLabel2;
            System.Windows.Forms.Label mandIdLabel;
            System.Windows.Forms.Label label3;
            this.idTextBox2 = new System.Windows.Forms.TextBox();
            this.mIdTextBox = new System.Windows.Forms.TextBox();
            this.RokTextBox = new System.Windows.Forms.TextBox();
            idLabel2 = new System.Windows.Forms.Label();
            mandIdLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // idTextBox2
            // 
            this.idTextBox2.Location = new System.Drawing.Point(6, 16);
            this.idTextBox2.Name = "idTextBox2";
            this.idTextBox2.Size = new System.Drawing.Size(62, 20);
            this.idTextBox2.TabIndex = 179;
            // 
            // idLabel2
            // 
            idLabel2.AutoSize = true;
            idLabel2.Location = new System.Drawing.Point(3, 0);
            idLabel2.Name = "idLabel2";
            idLabel2.Size = new System.Drawing.Size(19, 13);
            idLabel2.TabIndex = 178;
            idLabel2.Text = "Id:";
            // 
            // mIdTextBox
            // 
            this.mIdTextBox.Location = new System.Drawing.Point(74, 16);
            this.mIdTextBox.Name = "mIdTextBox";
            this.mIdTextBox.Size = new System.Drawing.Size(118, 20);
            this.mIdTextBox.TabIndex = 177;
            // 
            // mandIdLabel
            // 
            mandIdLabel.AutoSize = true;
            mandIdLabel.Location = new System.Drawing.Point(71, 0);
            mandIdLabel.Name = "mandIdLabel";
            mandIdLabel.Size = new System.Drawing.Size(64, 13);
            mandIdLabel.TabIndex = 176;
            mandIdLabel.Text = "Mandanten:";
            // 
            // RokTextBox
            // 
            this.RokTextBox.Location = new System.Drawing.Point(198, 16);
            this.RokTextBox.Name = "RokTextBox";
            this.RokTextBox.Size = new System.Drawing.Size(86, 20);
            this.RokTextBox.TabIndex = 182;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(195, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(30, 13);
            label3.TabIndex = 181;
            label3.Text = "Rok:";
            // 
            // ucID_Mandaten_Rok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RokTextBox);
            this.Controls.Add(label3);
            this.Controls.Add(this.idTextBox2);
            this.Controls.Add(idLabel2);
            this.Controls.Add(this.mIdTextBox);
            this.Controls.Add(mandIdLabel);
            this.Name = "ucID_Mandaten_Rok";
            this.Size = new System.Drawing.Size(291, 46);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idTextBox2;
        private System.Windows.Forms.TextBox mIdTextBox;
        private System.Windows.Forms.TextBox RokTextBox;
    }
}

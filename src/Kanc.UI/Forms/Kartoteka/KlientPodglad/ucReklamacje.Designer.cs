namespace Kanc.UI.Ctrl
{
    partial class ucReklamacje
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
            this.btnPiszReklamacje = new System.Windows.Forms.Button();
            this.btnReklamator = new System.Windows.Forms.Button();
            this.btnInformator = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPiszReklamacje
            // 
            this.btnPiszReklamacje.Location = new System.Drawing.Point(12, 14);
            this.btnPiszReklamacje.Name = "btnPiszReklamacje";
            this.btnPiszReklamacje.Size = new System.Drawing.Size(116, 23);
            this.btnPiszReklamacje.TabIndex = 0;
            this.btnPiszReklamacje.Text = "Pisz reklamacje";
            this.btnPiszReklamacje.UseVisualStyleBackColor = true;
            this.btnPiszReklamacje.Click += new System.EventHandler(this.btnPiszReklamacje_Click);
            // 
            // btnReklamator
            // 
            this.btnReklamator.Location = new System.Drawing.Point(300, 14);
            this.btnReklamator.Name = "btnReklamator";
            this.btnReklamator.Size = new System.Drawing.Size(75, 23);
            this.btnReklamator.TabIndex = 1;
            this.btnReklamator.Text = "Reklamator";
            this.btnReklamator.UseVisualStyleBackColor = true;
            this.btnReklamator.Click += new System.EventHandler(this.btnReklamator_Click);
            // 
            // btnInformator
            // 
            this.btnInformator.Location = new System.Drawing.Point(178, 14);
            this.btnInformator.Name = "btnInformator";
            this.btnInformator.Size = new System.Drawing.Size(75, 23);
            this.btnInformator.TabIndex = 2;
            this.btnInformator.Text = "Informator";
            this.btnInformator.UseVisualStyleBackColor = true;
            this.btnInformator.Click += new System.EventHandler(this.btnInformator_Click);
            // 
            // ucReklamacje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnInformator);
            this.Controls.Add(this.btnReklamator);
            this.Controls.Add(this.btnPiszReklamacje);
            this.Name = "ucReklamacje";
            this.Size = new System.Drawing.Size(399, 59);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPiszReklamacje;
        private System.Windows.Forms.Button btnReklamator;
        private System.Windows.Forms.Button btnInformator;
    }
}

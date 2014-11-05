namespace Kanc.UI.Ctrl
{
    partial class ucForListaZaplat
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
            this.lblLista = new System.Windows.Forms.Label();
            this.txbLista = new System.Windows.Forms.TextBox();
            this.txbNrKP = new System.Windows.Forms.TextBox();
            this.lblNrKP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Location = new System.Drawing.Point(10, 5);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(32, 13);
            this.lblLista.TabIndex = 0;
            this.lblLista.Text = "Lista:";
            // 
            // txbLista
            // 
            this.txbLista.Location = new System.Drawing.Point(13, 21);
            this.txbLista.Name = "txbLista";
            this.txbLista.Size = new System.Drawing.Size(63, 20);
            this.txbLista.TabIndex = 1;
            // 
            // txbNrKP
            // 
            this.txbNrKP.Location = new System.Drawing.Point(82, 21);
            this.txbNrKP.Name = "txbNrKP";
            this.txbNrKP.Size = new System.Drawing.Size(81, 20);
            this.txbNrKP.TabIndex = 3;
            // 
            // lblNrKP
            // 
            this.lblNrKP.AutoSize = true;
            this.lblNrKP.Location = new System.Drawing.Point(79, 5);
            this.lblNrKP.Name = "lblNrKP";
            this.lblNrKP.Size = new System.Drawing.Size(38, 13);
            this.lblNrKP.TabIndex = 2;
            this.lblNrKP.Text = "Nr KP:";
            // 
            // ucForListaZaplat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txbNrKP);
            this.Controls.Add(this.lblNrKP);
            this.Controls.Add(this.txbLista);
            this.Controls.Add(this.lblLista);
            this.Name = "ucForListaZaplat";
            this.Size = new System.Drawing.Size(185, 48);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.TextBox txbLista;
        private System.Windows.Forms.TextBox txbNrKP;
        private System.Windows.Forms.Label lblNrKP;
    }
}

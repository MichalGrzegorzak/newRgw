namespace Kanc.UI.Forms.Modalne
{
    partial class FrmKsiegowanie
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ucKsiegowanie = new Kanc.UI.Ctrl.ucKsiegowanie();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ucKsiegowanie
            // 
            this.ucKsiegowanie.Binder = null;
            this.ucKsiegowanie.Location = new System.Drawing.Point(0, 0);
            this.ucKsiegowanie.Name = "ucKsiegowanie";
            this.ucKsiegowanie.Session = null;
            this.ucKsiegowanie.Size = new System.Drawing.Size(650, 182);
            this.ucKsiegowanie.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(575, 201);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Zapisz";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmKsiegowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 260);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ucKsiegowanie);
            this.Name = "FrmKsiegowanie";
            this.Text = "FrmKsiegowanie";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Ctrl.ucKsiegowanie ucKsiegowanie;
        private System.Windows.Forms.Button btnSave;

    }
}
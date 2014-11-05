namespace Kanc.UI.Forms.Kartoteka.micro
{
    partial class uxProcPodatek
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
            this.comboPodatek = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboPodatek
            // 
            this.comboPodatek.FormattingEnabled = true;
            this.comboPodatek.Items.AddRange(new object[] {
            "0",
            "16",
            "19"});
            this.comboPodatek.Location = new System.Drawing.Point(0, 0);
            this.comboPodatek.Name = "comboPodatek";
            this.comboPodatek.Size = new System.Drawing.Size(60, 21);
            this.comboPodatek.TabIndex = 0;
            // 
            // uxProcPodatek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboPodatek);
            this.Name = "uxProcPodatek";
            this.Size = new System.Drawing.Size(63, 24);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboPodatek;
    }
}

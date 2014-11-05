using Kanc.UI.Ctrl;

namespace Kanc.UI.Forms
{
    partial class FrmKartotekaPodglad
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabKonto = new System.Windows.Forms.TabPage();
            this.ucKontoPodglad1 = new Kanc.UI.Ctrl.ucKontoPodglad();
            this.tabRodzina = new System.Windows.Forms.TabPage();
            this.ucRodzinaPodglad1 = new Kanc.UI.Ctrl.ucRodzinaPodglad();
            this.tabWykazIndex = new System.Windows.Forms.TabPage();
            this.ucWykazWgIndeksuPodglad1 = new Kanc.UI.Ctrl.ucWykazWgIndeksuPodglad();
            this.tabReklamacje = new System.Windows.Forms.TabPage();
            this.ucReklamacje1 = new Kanc.UI.Ctrl.ucReklamacje();
            this.tabHistoria = new System.Windows.Forms.TabPage();
            this.ucHistoriaPodglad1 = new Kanc.UI.Ctrl.ucHistoriaPodglad();
            this.tabRachunek = new System.Windows.Forms.TabPage();
            this.ucRachunekPodglad1 = new Kanc.UI.Ctrl.ucRachunekPodglad();
            this.tabKontakt = new System.Windows.Forms.TabPage();
            this.ucAdresPodglad1 = new Kanc.UI.Ctrl.ucAdresPodglad();
            this.ucPodstKlientPodglad1 = new Kanc.UI.Ctrl.ucPodstKlientPodglad();
            this.podgladBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabKonto.SuspendLayout();
            this.tabRodzina.SuspendLayout();
            this.tabWykazIndex.SuspendLayout();
            this.tabReklamacje.SuspendLayout();
            this.tabHistoria.SuspendLayout();
            this.tabRachunek.SuspendLayout();
            this.tabKontakt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.podgladBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabKonto);
            this.tabControl1.Controls.Add(this.tabRodzina);
            this.tabControl1.Controls.Add(this.tabWykazIndex);
            this.tabControl1.Controls.Add(this.tabReklamacje);
            this.tabControl1.Controls.Add(this.tabHistoria);
            this.tabControl1.Controls.Add(this.tabRachunek);
            this.tabControl1.Controls.Add(this.tabKontakt);
            this.tabControl1.Location = new System.Drawing.Point(3, 179);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(652, 313);
            this.tabControl1.TabIndex = 0;
            // 
            // tabKonto
            // 
            this.tabKonto.Controls.Add(this.ucKontoPodglad1);
            this.tabKonto.Location = new System.Drawing.Point(4, 22);
            this.tabKonto.Name = "tabKonto";
            this.tabKonto.Padding = new System.Windows.Forms.Padding(3);
            this.tabKonto.Size = new System.Drawing.Size(644, 287);
            this.tabKonto.TabIndex = 1;
            this.tabKonto.Text = "Konto klienta";
            this.tabKonto.UseVisualStyleBackColor = true;
            // 
            // ucKontoPodglad1
            // 
            this.ucKontoPodglad1.Binder = null;
            this.ucKontoPodglad1.Location = new System.Drawing.Point(3, 6);
            this.ucKontoPodglad1.Name = "ucKontoPodglad1";
            this.ucKontoPodglad1.Session = null;
            this.ucKontoPodglad1.Size = new System.Drawing.Size(461, 168);
            this.ucKontoPodglad1.TabIndex = 0;
            // 
            // tabRodzina
            // 
            this.tabRodzina.Controls.Add(this.ucRodzinaPodglad1);
            this.tabRodzina.Location = new System.Drawing.Point(4, 22);
            this.tabRodzina.Name = "tabRodzina";
            this.tabRodzina.Size = new System.Drawing.Size(644, 287);
            this.tabRodzina.TabIndex = 2;
            this.tabRodzina.Text = "Rodzina";
            this.tabRodzina.UseVisualStyleBackColor = true;
            // 
            // ucRodzinaPodglad1
            // 
            this.ucRodzinaPodglad1.Binder = null;
            this.ucRodzinaPodglad1.Location = new System.Drawing.Point(3, 3);
            this.ucRodzinaPodglad1.Name = "ucRodzinaPodglad1";
            this.ucRodzinaPodglad1.Session = null;
            this.ucRodzinaPodglad1.Size = new System.Drawing.Size(614, 226);
            this.ucRodzinaPodglad1.TabIndex = 0;
            // 
            // tabWykazIndex
            // 
            this.tabWykazIndex.Controls.Add(this.ucWykazWgIndeksuPodglad1);
            this.tabWykazIndex.Location = new System.Drawing.Point(4, 22);
            this.tabWykazIndex.Name = "tabWykazIndex";
            this.tabWykazIndex.Size = new System.Drawing.Size(644, 287);
            this.tabWykazIndex.TabIndex = 3;
            this.tabWykazIndex.Text = "Wykaz wg indeksu";
            this.tabWykazIndex.UseVisualStyleBackColor = true;
            // 
            // ucWykazWgIndeksuPodglad1
            // 
            this.ucWykazWgIndeksuPodglad1.AutoScroll = true;
            this.ucWykazWgIndeksuPodglad1.Binder = null;
            this.ucWykazWgIndeksuPodglad1.CustomerId = 0;
            this.ucWykazWgIndeksuPodglad1.Location = new System.Drawing.Point(0, 3);
            this.ucWykazWgIndeksuPodglad1.Name = "ucWykazWgIndeksuPodglad1";
            this.ucWykazWgIndeksuPodglad1.Session = null;
            this.ucWykazWgIndeksuPodglad1.Size = new System.Drawing.Size(712, 225);
            this.ucWykazWgIndeksuPodglad1.TabIndex = 0;
            // 
            // tabReklamacje
            // 
            this.tabReklamacje.Controls.Add(this.ucReklamacje1);
            this.tabReklamacje.Location = new System.Drawing.Point(4, 22);
            this.tabReklamacje.Name = "tabReklamacje";
            this.tabReklamacje.Size = new System.Drawing.Size(644, 287);
            this.tabReklamacje.TabIndex = 7;
            this.tabReklamacje.Text = "Reklamacje";
            this.tabReklamacje.UseVisualStyleBackColor = true;
            // 
            // ucReklamacje1
            // 
            this.ucReklamacje1.Binder = null;
            this.ucReklamacje1.Location = new System.Drawing.Point(25, 20);
            this.ucReklamacje1.Name = "ucReklamacje1";
            this.ucReklamacje1.Session = null;
            this.ucReklamacje1.Size = new System.Drawing.Size(389, 78);
            this.ucReklamacje1.TabIndex = 0;
            // 
            // tabHistoria
            // 
            this.tabHistoria.Controls.Add(this.ucHistoriaPodglad1);
            this.tabHistoria.Location = new System.Drawing.Point(4, 22);
            this.tabHistoria.Name = "tabHistoria";
            this.tabHistoria.Size = new System.Drawing.Size(644, 287);
            this.tabHistoria.TabIndex = 5;
            this.tabHistoria.Text = "Historia";
            this.tabHistoria.UseVisualStyleBackColor = true;
            // 
            // ucHistoriaPodglad1
            // 
            this.ucHistoriaPodglad1.Binder = null;
            this.ucHistoriaPodglad1.Historia = null;
            this.ucHistoriaPodglad1.Location = new System.Drawing.Point(5, 3);
            this.ucHistoriaPodglad1.Name = "ucHistoriaPodglad1";
            this.ucHistoriaPodglad1.Session = null;
            this.ucHistoriaPodglad1.Size = new System.Drawing.Size(636, 333);
            this.ucHistoriaPodglad1.TabIndex = 0;
            // 
            // tabRachunek
            // 
            this.tabRachunek.Controls.Add(this.ucRachunekPodglad1);
            this.tabRachunek.Location = new System.Drawing.Point(4, 22);
            this.tabRachunek.Name = "tabRachunek";
            this.tabRachunek.Size = new System.Drawing.Size(644, 287);
            this.tabRachunek.TabIndex = 6;
            this.tabRachunek.Text = "Rachunek";
            this.tabRachunek.UseVisualStyleBackColor = true;
            // 
            // ucRachunekPodglad1
            // 
            this.ucRachunekPodglad1.Binder = null;
            this.ucRachunekPodglad1.Location = new System.Drawing.Point(5, 3);
            this.ucRachunekPodglad1.Name = "ucRachunekPodglad1";
            this.ucRachunekPodglad1.Session = null;
            this.ucRachunekPodglad1.Size = new System.Drawing.Size(636, 374);
            this.ucRachunekPodglad1.TabIndex = 0;
            // 
            // tabKontakt
            // 
            this.tabKontakt.Controls.Add(this.ucAdresPodglad1);
            this.tabKontakt.Location = new System.Drawing.Point(4, 22);
            this.tabKontakt.Name = "tabKontakt";
            this.tabKontakt.Padding = new System.Windows.Forms.Padding(3);
            this.tabKontakt.Size = new System.Drawing.Size(644, 287);
            this.tabKontakt.TabIndex = 0;
            this.tabKontakt.Text = "Kontakt";
            this.tabKontakt.UseVisualStyleBackColor = true;
            // 
            // ucAdresPodglad1
            // 
            this.ucAdresPodglad1.Binder = null;
            this.ucAdresPodglad1.Location = new System.Drawing.Point(6, 6);
            this.ucAdresPodglad1.Name = "ucAdresPodglad1";
            this.ucAdresPodglad1.Session = null;
            this.ucAdresPodglad1.Size = new System.Drawing.Size(461, 235);
            this.ucAdresPodglad1.TabIndex = 0;
            // 
            // ucPodstKlientPodglad1
            // 
            this.ucPodstKlientPodglad1.Binder = null;
            this.ucPodstKlientPodglad1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucPodstKlientPodglad1.Location = new System.Drawing.Point(3, 1);
            this.ucPodstKlientPodglad1.MaximumSize = new System.Drawing.Size(919, 822);
            this.ucPodstKlientPodglad1.Name = "ucPodstKlientPodglad1";
            this.ucPodstKlientPodglad1.Session = null;
            this.ucPodstKlientPodglad1.Size = new System.Drawing.Size(879, 172);
            this.ucPodstKlientPodglad1.TabIndex = 1;
            // 
            // FrmKartotekaPodglad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(891, 606);
            this.ControlBox = false;
            this.Controls.Add(this.ucPodstKlientPodglad1);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmKartotekaPodglad";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Load += new System.EventHandler(this.FrmKartotekaPodglad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabKonto.ResumeLayout(false);
            this.tabRodzina.ResumeLayout(false);
            this.tabWykazIndex.ResumeLayout(false);
            this.tabReklamacje.ResumeLayout(false);
            this.tabHistoria.ResumeLayout(false);
            this.tabRachunek.ResumeLayout(false);
            this.tabKontakt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.podgladBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabKontakt;
        private System.Windows.Forms.TabPage tabKonto;
        private ucPodstKlientPodglad ucPodstKlientPodglad1;
        private System.Windows.Forms.TabPage tabRodzina;
        private System.Windows.Forms.TabPage tabWykazIndex;
        private System.Windows.Forms.TabPage tabHistoria;
        private System.Windows.Forms.TabPage tabRachunek;
        private System.Windows.Forms.TabPage tabReklamacje;
        private System.Windows.Forms.BindingSource podgladBindingSource;
        private ucAdresPodglad ucAdresPodglad1;
        private ucKontoPodglad ucKontoPodglad1;
        private ucRodzinaPodglad ucRodzinaPodglad1;
        private ucWykazWgIndeksuPodglad ucWykazWgIndeksuPodglad1;
        private ucHistoriaPodglad ucHistoriaPodglad1;
        private ucRachunekPodglad ucRachunekPodglad1;
        private ucReklamacje ucReklamacje1;
    }
}
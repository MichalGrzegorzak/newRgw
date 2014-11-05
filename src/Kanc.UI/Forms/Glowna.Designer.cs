namespace Kanc.UI.Forms
{
    partial class Glowna
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grbResults = new System.Windows.Forms.GroupBox();
            this.wynikiGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nazwisko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataUrodz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbSearch = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.txbPoDacie = new Kanc.Commons.MaskedTextBoxExt();
            this.txbPoSteunummer = new System.Windows.Forms.TextBox();
            this.txbPoMandaten = new System.Windows.Forms.TextBox();
            this.txbPoNazwisku = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSzukaj = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnPrzeglad = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.IdsBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grbResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wynikiGridView)).BeginInit();
            this.grbSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(514, 425);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grbResults);
            this.tabPage1.Controls.Add(this.grbSearch);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.btnPrzeglad);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(506, 399);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grbResults
            // 
            this.grbResults.Controls.Add(this.wynikiGridView);
            this.grbResults.Location = new System.Drawing.Point(3, 191);
            this.grbResults.Name = "grbResults";
            this.grbResults.Size = new System.Drawing.Size(477, 183);
            this.grbResults.TabIndex = 9;
            this.grbResults.TabStop = false;
            this.grbResults.Text = "Wyniki:";
            // 
            // wynikiGridView
            // 
            this.wynikiGridView.AllowUserToAddRows = false;
            this.wynikiGridView.AllowUserToDeleteRows = false;
            this.wynikiGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wynikiGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Rok,
            this.Nazwisko,
            this.Imie,
            this.DataUrodz});
            this.wynikiGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wynikiGridView.Location = new System.Drawing.Point(3, 16);
            this.wynikiGridView.MultiSelect = false;
            this.wynikiGridView.Name = "wynikiGridView";
            this.wynikiGridView.ReadOnly = true;
            this.wynikiGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.wynikiGridView.Size = new System.Drawing.Size(471, 164);
            this.wynikiGridView.TabIndex = 0;
            this.wynikiGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.wynikiGridView_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Rok
            // 
            this.Rok.DataPropertyName = "Rok";
            this.Rok.HeaderText = "Rok";
            this.Rok.Name = "Rok";
            this.Rok.ReadOnly = true;
            // 
            // Nazwisko
            // 
            this.Nazwisko.DataPropertyName = "Nazwisko";
            this.Nazwisko.HeaderText = "Nazwisko";
            this.Nazwisko.Name = "Nazwisko";
            this.Nazwisko.ReadOnly = true;
            // 
            // Imie
            // 
            this.Imie.DataPropertyName = "Imie";
            this.Imie.HeaderText = "Imie";
            this.Imie.Name = "Imie";
            this.Imie.ReadOnly = true;
            // 
            // DataUrodz
            // 
            this.DataUrodz.DataPropertyName = "Urodz";
            this.DataUrodz.HeaderText = "DataUrodz";
            this.DataUrodz.Name = "DataUrodz";
            this.DataUrodz.ReadOnly = true;
            // 
            // grbSearch
            // 
            this.grbSearch.Controls.Add(this.btnClear);
            this.grbSearch.Controls.Add(this.txbPoDacie);
            this.grbSearch.Controls.Add(this.txbPoSteunummer);
            this.grbSearch.Controls.Add(this.txbPoMandaten);
            this.grbSearch.Controls.Add(this.txbPoNazwisku);
            this.grbSearch.Controls.Add(this.label4);
            this.grbSearch.Controls.Add(this.label3);
            this.grbSearch.Controls.Add(this.label2);
            this.grbSearch.Controls.Add(this.label1);
            this.grbSearch.Controls.Add(this.btnSzukaj);
            this.grbSearch.Location = new System.Drawing.Point(265, 6);
            this.grbSearch.Name = "grbSearch";
            this.grbSearch.Size = new System.Drawing.Size(215, 166);
            this.grbSearch.TabIndex = 3;
            this.grbSearch.TabStop = false;
            this.grbSearch.Text = "Wyszukiwanie";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(6, 138);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(48, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Czysc";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txbPoDacie
            // 
            this.txbPoDacie.Date = null;
            this.txbPoDacie.Location = new System.Drawing.Point(102, 24);
            this.txbPoDacie.Name = "txbPoDacie";
            this.txbPoDacie.Size = new System.Drawing.Size(100, 20);
            this.txbPoDacie.TabIndex = 10;
            // 
            // txbPoSteunummer
            // 
            this.txbPoSteunummer.Location = new System.Drawing.Point(102, 102);
            this.txbPoSteunummer.Name = "txbPoSteunummer";
            this.txbPoSteunummer.Size = new System.Drawing.Size(100, 20);
            this.txbPoSteunummer.TabIndex = 8;
            // 
            // txbPoMandaten
            // 
            this.txbPoMandaten.Location = new System.Drawing.Point(102, 76);
            this.txbPoMandaten.Name = "txbPoMandaten";
            this.txbPoMandaten.Size = new System.Drawing.Size(100, 20);
            this.txbPoMandaten.TabIndex = 7;
            // 
            // txbPoNazwisku
            // 
            this.txbPoNazwisku.Location = new System.Drawing.Point(102, 50);
            this.txbPoNazwisku.Name = "txbPoNazwisku";
            this.txbPoNazwisku.Size = new System.Drawing.Size(100, 20);
            this.txbPoNazwisku.TabIndex = 6;
            this.txbPoNazwisku.Text = "Nazwisko10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "po Steurnummer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "po MandatenId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "po nazwisku";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "po dacie";
            // 
            // btnSzukaj
            // 
            this.btnSzukaj.Location = new System.Drawing.Point(102, 138);
            this.btnSzukaj.Name = "btnSzukaj";
            this.btnSzukaj.Size = new System.Drawing.Size(100, 23);
            this.btnSzukaj.TabIndex = 0;
            this.btnSzukaj.Text = "Szukaj";
            this.btnSzukaj.UseVisualStyleBackColor = true;
            this.btnSzukaj.Click += new System.EventHandler(this.btnSzukaj_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnPrzeglad
            // 
            this.btnPrzeglad.Location = new System.Drawing.Point(8, 6);
            this.btnPrzeglad.Name = "btnPrzeglad";
            this.btnPrzeglad.Size = new System.Drawing.Size(75, 23);
            this.btnPrzeglad.TabIndex = 1;
            this.btnPrzeglad.Text = "Przegladaj";
            this.btnPrzeglad.UseVisualStyleBackColor = true;
            this.btnPrzeglad.Click += new System.EventHandler(this.btnPrzeglad_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(919, 399);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Glowna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 425);
            this.Controls.Add(this.tabControl1);
            this.Name = "Glowna";
            this.Text = "Glowna";
            ((System.ComponentModel.ISupportInitialize)(this.IdsBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.grbResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wynikiGridView)).EndInit();
            this.grbSearch.ResumeLayout(false);
            this.grbSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox grbResults;
        private System.Windows.Forms.DataGridView wynikiGridView;
        private System.Windows.Forms.GroupBox grbSearch;
        private System.Windows.Forms.TextBox txbPoSteunummer;
        private System.Windows.Forms.TextBox txbPoMandaten;
        private System.Windows.Forms.TextBox txbPoNazwisku;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSzukaj;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnPrzeglad;
        private Commons.MaskedTextBoxExt txbPoDacie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rok;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwisko;
        private System.Windows.Forms.DataGridViewTextBoxColumn Imie;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataUrodz;
        private System.Windows.Forms.Button btnClear;
    }
}
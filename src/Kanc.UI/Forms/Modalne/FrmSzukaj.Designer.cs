using Kanc.Commons;

namespace Kanc.UI.Forms
{
    partial class FrmSzukaj
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
            this.dataUrodzeniaTextBoxExt = new Kanc.Commons.MaskedTextBoxExt();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nazwiskoTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mandantenTextBox = new System.Windows.Forms.TextBox();
            this.szukajButton = new System.Windows.Forms.Button();
            this.szukajbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wynikiGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nazwisko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Urodz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rozliczeniaGridView = new System.Windows.Forms.DataGridView();
            this.IdRozliczenia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.rozliczeniabindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.szukajbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wynikiGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rozliczeniaGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rozliczeniabindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataUrodzeniaTextBoxExt
            // 
            this.dataUrodzeniaTextBoxExt.Date = null;
            this.dataUrodzeniaTextBoxExt.Location = new System.Drawing.Point(165, 25);
            this.dataUrodzeniaTextBoxExt.Name = "dataUrodzeniaTextBoxExt";
            this.dataUrodzeniaTextBoxExt.Size = new System.Drawing.Size(147, 20);
            this.dataUrodzeniaTextBoxExt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Data urodzenia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kryteria wyszukiwania";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nazwisko:";
            // 
            // nazwiskoTextBox
            // 
            this.nazwiskoTextBox.Location = new System.Drawing.Point(165, 50);
            this.nazwiskoTextBox.Name = "nazwiskoTextBox";
            this.nazwiskoTextBox.Size = new System.Drawing.Size(147, 20);
            this.nazwiskoTextBox.TabIndex = 6;
            this.nazwiskoTextBox.Text = "b";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mandanten:";
            // 
            // mandantenTextBox
            // 
            this.mandantenTextBox.Location = new System.Drawing.Point(165, 75);
            this.mandantenTextBox.Name = "mandantenTextBox";
            this.mandantenTextBox.Size = new System.Drawing.Size(147, 20);
            this.mandantenTextBox.TabIndex = 10;
            // 
            // szukajButton
            // 
            this.szukajButton.Location = new System.Drawing.Point(275, 101);
            this.szukajButton.Name = "szukajButton";
            this.szukajButton.Size = new System.Drawing.Size(75, 23);
            this.szukajButton.TabIndex = 11;
            this.szukajButton.Text = "Szukaj";
            this.szukajButton.UseVisualStyleBackColor = true;
            this.szukajButton.Click += new System.EventHandler(this.szukajButton_Click);
            // 
            // wynikiGridView
            // 
            this.wynikiGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wynikiGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nazwisko,
            this.Imie,
            this.Urodz});
            this.wynikiGridView.Location = new System.Drawing.Point(15, 140);
            this.wynikiGridView.Name = "wynikiGridView";
            this.wynikiGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.wynikiGridView.Size = new System.Drawing.Size(338, 150);
            this.wynikiGridView.TabIndex = 12;
            this.wynikiGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.wynikiGridView_CellClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
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
            // Urodz
            // 
            this.Urodz.DataPropertyName = "Urodz";
            this.Urodz.HeaderText = "Urodzony";
            this.Urodz.Name = "Urodz";
            this.Urodz.ReadOnly = true;
            // 
            // rozliczeniaGridView
            // 
            this.rozliczeniaGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rozliczeniaGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdRozliczenia,
            this.Rok});
            this.rozliczeniaGridView.Location = new System.Drawing.Point(15, 319);
            this.rozliczeniaGridView.Name = "rozliczeniaGridView";
            this.rozliczeniaGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rozliczeniaGridView.Size = new System.Drawing.Size(155, 236);
            this.rozliczeniaGridView.TabIndex = 13;
            this.rozliczeniaGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rozliczeniaGridView_CellDoubleClick);
            // 
            // IdRozliczenia
            // 
            this.IdRozliczenia.DataPropertyName = "Id";
            this.IdRozliczenia.HeaderText = "Id";
            this.IdRozliczenia.Name = "IdRozliczenia";
            this.IdRozliczenia.Visible = false;
            // 
            // Rok
            // 
            this.Rok.DataPropertyName = "Rok";
            this.Rok.HeaderText = "Rok";
            this.Rok.Name = "Rok";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Dostępne rozliczenia";
            // 
            // FrmSzukaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 575);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rozliczeniaGridView);
            this.Controls.Add(this.wynikiGridView);
            this.Controls.Add(this.szukajButton);
            this.Controls.Add(this.nazwiskoTextBox);
            this.Controls.Add(this.dataUrodzeniaTextBoxExt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mandantenTextBox);
            this.Name = "FrmSzukaj";
            this.Text = "FrmSzukaj";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.szukajbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wynikiGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rozliczeniaGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rozliczeniabindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaskedTextBoxExt dataUrodzeniaTextBoxExt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nazwiskoTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox mandantenTextBox;
        private System.Windows.Forms.Button szukajButton;
        private System.Windows.Forms.BindingSource szukajbindingSource;
        private System.Windows.Forms.DataGridView wynikiGridView;
        private System.Windows.Forms.DataGridView rozliczeniaGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource rozliczeniabindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwisko;
        private System.Windows.Forms.DataGridViewTextBoxColumn Imie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Urodz;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRozliczenia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rok;
    }
}
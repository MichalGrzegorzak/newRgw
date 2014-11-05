namespace Kanc.UI.Ctrl
{
    partial class ucKontakt
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label komorkaLabel;
            System.Windows.Forms.Label telefonLabel;
            System.Windows.Forms.Label idLabel1;
            System.Windows.Forms.Label kodLabel;
            System.Windows.Forms.Label krajLabel;
            System.Windows.Forms.Label miastoLabel;
            System.Windows.Forms.Label miejsceLabel;
            System.Windows.Forms.Label ulicaLabel;
            System.Windows.Forms.Label notkaLabel;
            this.rozliczenieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.komorkaTextBox = new System.Windows.Forms.TextBox();
            this.telefonTextBox = new System.Windows.Forms.TextBox();
            this.adresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idTextBox1 = new System.Windows.Forms.TextBox();
            this.kodTextBox = new System.Windows.Forms.TextBox();
            this.miastoTextBox = new System.Windows.Forms.TextBox();
            this.miejsceTextBox = new System.Windows.Forms.TextBox();
            this.ulicaTextBox = new System.Windows.Forms.TextBox();
            this.krajeDDL1 = new Kanc.Commons.KrajeDDL();
            this.notkaTextBox = new System.Windows.Forms.TextBox();
            emailLabel = new System.Windows.Forms.Label();
            komorkaLabel = new System.Windows.Forms.Label();
            telefonLabel = new System.Windows.Forms.Label();
            idLabel1 = new System.Windows.Forms.Label();
            kodLabel = new System.Windows.Forms.Label();
            krajLabel = new System.Windows.Forms.Label();
            miastoLabel = new System.Windows.Forms.Label();
            miejsceLabel = new System.Windows.Forms.Label();
            ulicaLabel = new System.Windows.Forms.Label();
            notkaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rozliczenieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.Location = new System.Drawing.Point(437, 62);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(42, 15);
            emailLabel.TabIndex = 6;
            emailLabel.Text = "Email:";
            // 
            // komorkaLabel
            // 
            komorkaLabel.AutoSize = true;
            komorkaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            komorkaLabel.Location = new System.Drawing.Point(420, 36);
            komorkaLabel.Name = "komorkaLabel";
            komorkaLabel.Size = new System.Drawing.Size(60, 15);
            komorkaLabel.TabIndex = 14;
            komorkaLabel.Text = "Komorka:";
            // 
            // telefonLabel
            // 
            telefonLabel.AutoSize = true;
            telefonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telefonLabel.Location = new System.Drawing.Point(426, 10);
            telefonLabel.Name = "telefonLabel";
            telefonLabel.Size = new System.Drawing.Size(51, 15);
            telefonLabel.TabIndex = 30;
            telefonLabel.Text = "Telefon:";
            // 
            // idLabel1
            // 
            idLabel1.AutoSize = true;
            idLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel1.Location = new System.Drawing.Point(684, 0);
            idLabel1.Name = "idLabel1";
            idLabel1.Size = new System.Drawing.Size(20, 15);
            idLabel1.TabIndex = 36;
            idLabel1.Text = "Id:";
            // 
            // kodLabel
            // 
            kodLabel.AutoSize = true;
            kodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            kodLabel.Location = new System.Drawing.Point(0, 4);
            kodLabel.Name = "kodLabel";
            kodLabel.Size = new System.Drawing.Size(32, 15);
            kodLabel.TabIndex = 38;
            kodLabel.Text = "Kod:";
            // 
            // krajLabel
            // 
            krajLabel.AutoSize = true;
            krajLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            krajLabel.Location = new System.Drawing.Point(0, 126);
            krajLabel.Name = "krajLabel";
            krajLabel.Size = new System.Drawing.Size(32, 15);
            krajLabel.TabIndex = 40;
            krajLabel.Text = "Kraj:";
            // 
            // miastoLabel
            // 
            miastoLabel.AutoSize = true;
            miastoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            miastoLabel.Location = new System.Drawing.Point(131, 4);
            miastoLabel.Name = "miastoLabel";
            miastoLabel.Size = new System.Drawing.Size(87, 15);
            miastoLabel.TabIndex = 42;
            miastoLabel.Text = "Miasto/Poczta:";
            // 
            // miejsceLabel
            // 
            miejsceLabel.AutoSize = true;
            miejsceLabel.Location = new System.Drawing.Point(0, 43);
            miejsceLabel.Name = "miejsceLabel";
            miejsceLabel.Size = new System.Drawing.Size(46, 13);
            miejsceLabel.TabIndex = 44;
            miejsceLabel.Text = "Miejsce:";
            // 
            // ulicaLabel
            // 
            ulicaLabel.AutoSize = true;
            ulicaLabel.Location = new System.Drawing.Point(0, 86);
            ulicaLabel.Name = "ulicaLabel";
            ulicaLabel.Size = new System.Drawing.Size(34, 13);
            ulicaLabel.TabIndex = 46;
            ulicaLabel.Text = "Ulica:";
            // 
            // rozliczenieBindingSource
            // 
            this.rozliczenieBindingSource.DataSource = typeof(Kanc.Core.Entities.Rozliczenie);
            // 
            // klientBindingSource
            // 
            this.klientBindingSource.DataSource = typeof(Kanc.Core.Entities.Klient);
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klientBindingSource, "Email", true));
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(478, 59);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 21);
            this.emailTextBox.TabIndex = 7;
            // 
            // komorkaTextBox
            // 
            this.komorkaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klientBindingSource, "Komorka", true));
            this.komorkaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.komorkaTextBox.Location = new System.Drawing.Point(478, 33);
            this.komorkaTextBox.Name = "komorkaTextBox";
            this.komorkaTextBox.Size = new System.Drawing.Size(200, 21);
            this.komorkaTextBox.TabIndex = 15;
            // 
            // telefonTextBox
            // 
            this.telefonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klientBindingSource, "Telefon", true));
            this.telefonTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefonTextBox.Location = new System.Drawing.Point(478, 7);
            this.telefonTextBox.Name = "telefonTextBox";
            this.telefonTextBox.Size = new System.Drawing.Size(200, 21);
            this.telefonTextBox.TabIndex = 31;
            // 
            // adresBindingSource
            // 
            this.adresBindingSource.DataSource = typeof(Kanc.Core.Entities.Adres);
            // 
            // idTextBox1
            // 
            this.idTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adresBindingSource, "Id", true));
            this.idTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox1.Location = new System.Drawing.Point(687, 16);
            this.idTextBox1.Name = "idTextBox1";
            this.idTextBox1.Size = new System.Drawing.Size(51, 21);
            this.idTextBox1.TabIndex = 37;
            // 
            // kodTextBox
            // 
            this.kodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adresBindingSource, "Kod", true));
            this.kodTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kodTextBox.Location = new System.Drawing.Point(3, 20);
            this.kodTextBox.Name = "kodTextBox";
            this.kodTextBox.Size = new System.Drawing.Size(100, 21);
            this.kodTextBox.TabIndex = 39;
            // 
            // miastoTextBox
            // 
            this.miastoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adresBindingSource, "Miasto", true));
            this.miastoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miastoTextBox.Location = new System.Drawing.Point(134, 20);
            this.miastoTextBox.Name = "miastoTextBox";
            this.miastoTextBox.Size = new System.Drawing.Size(182, 21);
            this.miastoTextBox.TabIndex = 43;
            // 
            // miejsceTextBox
            // 
            this.miejsceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adresBindingSource, "Miejsce", true));
            this.miejsceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miejsceTextBox.Location = new System.Drawing.Point(3, 59);
            this.miejsceTextBox.Name = "miejsceTextBox";
            this.miejsceTextBox.Size = new System.Drawing.Size(182, 21);
            this.miejsceTextBox.TabIndex = 45;
            // 
            // ulicaTextBox
            // 
            this.ulicaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adresBindingSource, "Ulica", true));
            this.ulicaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ulicaTextBox.Location = new System.Drawing.Point(3, 102);
            this.ulicaTextBox.Name = "ulicaTextBox";
            this.ulicaTextBox.Size = new System.Drawing.Size(183, 21);
            this.ulicaTextBox.TabIndex = 47;
            // 
            // krajeDDL1
            // 
            this.krajeDDL1.DisplayMember = "Value";
            this.krajeDDL1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.krajeDDL1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.krajeDDL1.FormattingEnabled = true;
            this.krajeDDL1.Location = new System.Drawing.Point(3, 143);
            this.krajeDDL1.Name = "krajeDDL1";
            this.krajeDDL1.Size = new System.Drawing.Size(121, 23);
            this.krajeDDL1.TabIndex = 48;
            this.krajeDDL1.ValueMember = "numericKey";
            // 
            // notkaTextBox
            // 
            this.notkaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notkaTextBox.Location = new System.Drawing.Point(193, 75);
            this.notkaTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.notkaTextBox.Multiline = true;
            this.notkaTextBox.Name = "notkaTextBox";
            this.notkaTextBox.Size = new System.Drawing.Size(230, 122);
            this.notkaTextBox.TabIndex = 50;
            // 
            // notkaLabel
            // 
            notkaLabel.AutoSize = true;
            notkaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            notkaLabel.Location = new System.Drawing.Point(269, 54);
            notkaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            notkaLabel.Name = "notkaLabel";
            notkaLabel.Size = new System.Drawing.Size(42, 15);
            notkaLabel.TabIndex = 49;
            notkaLabel.Text = "Notka:";
            // 
            // ucKontakt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.notkaTextBox);
            this.Controls.Add(notkaLabel);
            this.Controls.Add(this.krajeDDL1);
            this.Controls.Add(idLabel1);
            this.Controls.Add(this.idTextBox1);
            this.Controls.Add(kodLabel);
            this.Controls.Add(this.kodTextBox);
            this.Controls.Add(krajLabel);
            this.Controls.Add(miastoLabel);
            this.Controls.Add(this.miastoTextBox);
            this.Controls.Add(miejsceLabel);
            this.Controls.Add(this.miejsceTextBox);
            this.Controls.Add(ulicaLabel);
            this.Controls.Add(this.ulicaTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(komorkaLabel);
            this.Controls.Add(this.komorkaTextBox);
            this.Controls.Add(telefonLabel);
            this.Controls.Add(this.telefonTextBox);
            this.Name = "ucKontakt";
            this.Size = new System.Drawing.Size(760, 212);
            ((System.ComponentModel.ISupportInitialize)(this.rozliczenieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource rozliczenieBindingSource;
        private System.Windows.Forms.BindingSource klientBindingSource;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox komorkaTextBox;
        private System.Windows.Forms.TextBox telefonTextBox;
        private System.Windows.Forms.BindingSource adresBindingSource;
        private System.Windows.Forms.TextBox idTextBox1;
        private System.Windows.Forms.TextBox kodTextBox;
        private System.Windows.Forms.TextBox miastoTextBox;
        private System.Windows.Forms.TextBox miejsceTextBox;
        private System.Windows.Forms.TextBox ulicaTextBox;
        private Commons.KrajeDDL krajeDDL1;
        private System.Windows.Forms.TextBox notkaTextBox;
    }
}

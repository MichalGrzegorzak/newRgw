

namespace Kanc.UI.Ctrl
{
    partial class ucKlient
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label polecajIdLabel;
            System.Windows.Forms.Label urodzLabel;
            System.Windows.Forms.Label plecLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucKlient));
            this.klientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.polecilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nazwaComboBox = new System.Windows.Forms.ComboBox();
            this.mtxbUrodz = new Kanc.UI.Ctrl.MaskedTextBoxExt();
            this.plecPlecComboBox = new Kanc.UI.Ctrl.PlecDDL();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            idLabel = new System.Windows.Forms.Label();
            polecajIdLabel = new System.Windows.Forms.Label();
            urodzLabel = new System.Windows.Forms.Label();
            plecLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polecilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(3, 6);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // polecajIdLabel
            // 
            polecajIdLabel.AutoSize = true;
            polecajIdLabel.Location = new System.Drawing.Point(3, 110);
            polecajIdLabel.Name = "polecajIdLabel";
            polecajIdLabel.Size = new System.Drawing.Size(57, 13);
            polecajIdLabel.TabIndex = 7;
            polecajIdLabel.Text = "Polecaj Id:";
            // 
            // urodzLabel
            // 
            urodzLabel.AutoSize = true;
            urodzLabel.Location = new System.Drawing.Point(3, 84);
            urodzLabel.Name = "urodzLabel";
            urodzLabel.Size = new System.Drawing.Size(38, 13);
            urodzLabel.TabIndex = 14;
            urodzLabel.Text = "Urodz:";
            // 
            // plecLabel1
            // 
            plecLabel1.AutoSize = true;
            plecLabel1.Location = new System.Drawing.Point(29, 57);
            plecLabel1.Name = "plecLabel1";
            plecLabel1.Size = new System.Drawing.Size(31, 13);
            plecLabel1.TabIndex = 15;
            plecLabel1.Text = "Plec:";
            // 
            // klientBindingSource
            // 
            this.klientBindingSource.DataSource = typeof(Kanc.Core.Entities.Klient);
            this.klientBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.klientBindingSource_AddingNew);
            this.klientBindingSource.PositionChanged += new System.EventHandler(this.klientBindingSource_PositionChanged);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klientBindingSource, "Id", true));
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(66, 3);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(121, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // polecilBindingSource
            // 
            this.polecilBindingSource.AllowNew = false;
            this.polecilBindingSource.DataSource = typeof(Kanc.Core.Entities.Polecil);
            // 
            // nazwaComboBox
            // 
            this.nazwaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.klientBindingSource, "PoleconyPrzez", true));
            this.nazwaComboBox.DataSource = this.polecilBindingSource;
            this.nazwaComboBox.DisplayMember = "Nazwa";
            this.nazwaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nazwaComboBox.Location = new System.Drawing.Point(66, 107);
            this.nazwaComboBox.Name = "nazwaComboBox";
            this.nazwaComboBox.Size = new System.Drawing.Size(121, 21);
            this.nazwaComboBox.TabIndex = 14;
            this.nazwaComboBox.ValueMember = "Id";
            // 
            // mtxbUrodz
            // 
            this.mtxbUrodz.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klientBindingSource, "Urodz", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.mtxbUrodz.Location = new System.Drawing.Point(66, 81);
            this.mtxbUrodz.Mask = "00/00/0000";
            this.mtxbUrodz.Name = "mtxbUrodz";
            this.mtxbUrodz.Size = new System.Drawing.Size(121, 20);
            this.mtxbUrodz.TabIndex = 15;
            this.mtxbUrodz.ValidatingType = typeof(System.DateTime);
            // 
            // plecPlecComboBox
            // 
            this.plecPlecComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.klientBindingSource, "Plec", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.plecPlecComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klientBindingSource, "Plec", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.plecPlecComboBox.DataSource = ((object)(resources.GetObject("plecPlecComboBox.DataSource")));
            this.plecPlecComboBox.DisplayMember = "Value";
            this.plecPlecComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.plecPlecComboBox.FormattingEnabled = true;
            this.plecPlecComboBox.Location = new System.Drawing.Point(66, 54);
            this.plecPlecComboBox.Name = "plecPlecComboBox";
            this.plecPlecComboBox.Size = new System.Drawing.Size(121, 21);
            this.plecPlecComboBox.StartIndex = 0;
            this.plecPlecComboBox.TabIndex = 16;
            this.plecPlecComboBox.ValueMember = "Key";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.DataSource = this.klientBindingSource;
            // 
            // ucKlient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(plecLabel1);
            this.Controls.Add(this.plecPlecComboBox);
            this.Controls.Add(urodzLabel);
            this.Controls.Add(this.mtxbUrodz);
            this.Controls.Add(this.nazwaComboBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(polecajIdLabel);
            this.Name = "ucKlient";
            this.Size = new System.Drawing.Size(280, 203);
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polecilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource klientBindingSource;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.BindingSource polecilBindingSource;
        private System.Windows.Forms.ComboBox nazwaComboBox;
        private MaskedTextBoxExt mtxbUrodz;
        private PlecDDL plecPlecComboBox;
        protected System.Windows.Forms.ErrorProvider errorProvider1;

    }
}

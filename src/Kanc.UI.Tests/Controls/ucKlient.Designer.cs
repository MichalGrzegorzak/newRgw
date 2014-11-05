namespace Kanc.UI.Tests.Controls
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label urodzLabel;
            System.Windows.Forms.Label nazwaEULabel;
            System.Windows.Forms.Label nazwaPLLabel;
            System.Windows.Forms.Label skrotLabel;
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.urodzDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.imieTextBox = new System.Windows.Forms.TextBox();
            this.txtNazwaEU = new System.Windows.Forms.TextBox();
            this.txtNazwaPL = new System.Windows.Forms.TextBox();
            this.txtSkrot = new System.Windows.Forms.TextBox();
            this.krajIdTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            urodzLabel = new System.Windows.Forms.Label();
            nazwaEULabel = new System.Windows.Forms.Label();
            nazwaPLLabel = new System.Windows.Forms.Label();
            skrotLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(18, 13);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // urodzLabel
            // 
            urodzLabel.AutoSize = true;
            urodzLabel.Location = new System.Drawing.Point(18, 40);
            urodzLabel.Name = "urodzLabel";
            urodzLabel.Size = new System.Drawing.Size(38, 13);
            urodzLabel.TabIndex = 3;
            urodzLabel.Text = "Urodz:";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(62, 10);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // urodzDateTimePicker
            // 
            this.urodzDateTimePicker.Location = new System.Drawing.Point(62, 36);
            this.urodzDateTimePicker.Name = "urodzDateTimePicker";
            this.urodzDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.urodzDateTimePicker.TabIndex = 4;
            // 
            // imieTextBox
            // 
            this.imieTextBox.Location = new System.Drawing.Point(62, 62);
            this.imieTextBox.Name = "imieTextBox";
            this.imieTextBox.Size = new System.Drawing.Size(200, 20);
            this.imieTextBox.TabIndex = 5;
            // 
            // nazwaEULabel
            // 
            nazwaEULabel.AutoSize = true;
            nazwaEULabel.Location = new System.Drawing.Point(290, 14);
            nazwaEULabel.Name = "nazwaEULabel";
            nazwaEULabel.Size = new System.Drawing.Size(61, 13);
            nazwaEULabel.TabIndex = 15;
            nazwaEULabel.Text = "Nazwa EU:";
            // 
            // txtNazwaEU
            // 
            this.txtNazwaEU.Location = new System.Drawing.Point(357, 11);
            this.txtNazwaEU.Name = "txtNazwaEU";
            this.txtNazwaEU.Size = new System.Drawing.Size(100, 20);
            this.txtNazwaEU.TabIndex = 16;
            // 
            // nazwaPLLabel
            // 
            nazwaPLLabel.AutoSize = true;
            nazwaPLLabel.Location = new System.Drawing.Point(290, 40);
            nazwaPLLabel.Name = "nazwaPLLabel";
            nazwaPLLabel.Size = new System.Drawing.Size(59, 13);
            nazwaPLLabel.TabIndex = 17;
            nazwaPLLabel.Text = "Nazwa PL:";
            // 
            // txtNazwaPL
            // 
            this.txtNazwaPL.Location = new System.Drawing.Point(357, 37);
            this.txtNazwaPL.Name = "txtNazwaPL";
            this.txtNazwaPL.Size = new System.Drawing.Size(100, 20);
            this.txtNazwaPL.TabIndex = 18;
            // 
            // skrotLabel
            // 
            skrotLabel.AutoSize = true;
            skrotLabel.Location = new System.Drawing.Point(290, 66);
            skrotLabel.Name = "skrotLabel";
            skrotLabel.Size = new System.Drawing.Size(35, 13);
            skrotLabel.TabIndex = 19;
            skrotLabel.Text = "Skrot:";
            // 
            // txtSkrot
            // 
            this.txtSkrot.Location = new System.Drawing.Point(357, 63);
            this.txtSkrot.Name = "txtSkrot";
            this.txtSkrot.Size = new System.Drawing.Size(100, 20);
            this.txtSkrot.TabIndex = 20;
            // 
            // krajIdTextBox
            // 
            this.krajIdTextBox.Location = new System.Drawing.Point(357, 89);
            this.krajIdTextBox.Name = "krajIdTextBox";
            this.krajIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.krajIdTextBox.TabIndex = 21;
            // 
            // ucKlient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.krajIdTextBox);
            this.Controls.Add(nazwaEULabel);
            this.Controls.Add(this.txtNazwaEU);
            this.Controls.Add(nazwaPLLabel);
            this.Controls.Add(this.txtNazwaPL);
            this.Controls.Add(skrotLabel);
            this.Controls.Add(this.txtSkrot);
            this.Controls.Add(this.imieTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(urodzLabel);
            this.Controls.Add(this.urodzDateTimePicker);
            this.Name = "ucKlient";
            this.Size = new System.Drawing.Size(492, 141);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.DateTimePicker urodzDateTimePicker;
        private System.Windows.Forms.TextBox imieTextBox;
        private System.Windows.Forms.TextBox txtNazwaEU;
        private System.Windows.Forms.TextBox txtNazwaPL;
        private System.Windows.Forms.TextBox txtSkrot;
        private System.Windows.Forms.TextBox krajIdTextBox;

    }
}

using Kanc.Commons;

namespace Kanc.UI.Ctrl
{
    partial class ucPodstKlientPodglad
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
            System.Windows.Forms.Label urodzLabel;
            System.Windows.Forms.Label mandIdLabel;
            System.Windows.Forms.Label imieLabel;
            System.Windows.Forms.Label imieDeLabel;
            System.Windows.Forms.Label nazwiskoLabel;
            System.Windows.Forms.Label nazwiskoDeLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label idLabel2;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            this.lblOperator = new System.Windows.Forms.Label();
            this.mIdTextBox = new System.Windows.Forms.TextBox();
            this.imieTextBox = new System.Windows.Forms.TextBox();
            this.imieDeTextBox = new System.Windows.Forms.TextBox();
            this.nazwiskoTextBox = new System.Windows.Forms.TextBox();
            this.nazwiskoDeTextBox = new System.Windows.Forms.TextBox();
            this.urodzMaskedTextBoxExt = new Kanc.Commons.MaskedTextBoxExt();
            this.idTextBox2 = new System.Windows.Forms.TextBox();
            this.krajeDDL1 = new Kanc.Commons.KrajeDDL();
            this.SteuernummerTextBox = new System.Windows.Forms.TextBox();
            this.RokTextBox = new System.Windows.Forms.TextBox();
            this.StatusTextBox = new System.Windows.Forms.TextBox();
            this.OperatorPozycjaTextBox = new System.Windows.Forms.TextBox();
            this.OperatorRokTextBox = new System.Windows.Forms.TextBox();
            this.poleconyDDL1 = new Kanc.Commons.PoleconyDDL();
            urodzLabel = new System.Windows.Forms.Label();
            mandIdLabel = new System.Windows.Forms.Label();
            imieLabel = new System.Windows.Forms.Label();
            imieDeLabel = new System.Windows.Forms.Label();
            nazwiskoLabel = new System.Windows.Forms.Label();
            nazwiskoDeLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            idLabel2 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // urodzLabel
            // 
            urodzLabel.AutoSize = true;
            urodzLabel.Location = new System.Drawing.Point(16, 3);
            urodzLabel.Name = "urodzLabel";
            urodzLabel.Size = new System.Drawing.Size(55, 13);
            urodzLabel.TabIndex = 168;
            urodzLabel.Text = "Urodzony:";
            // 
            // mandIdLabel
            // 
            mandIdLabel.AutoSize = true;
            mandIdLabel.Location = new System.Drawing.Point(557, 11);
            mandIdLabel.Name = "mandIdLabel";
            mandIdLabel.Size = new System.Drawing.Size(64, 13);
            mandIdLabel.TabIndex = 164;
            mandIdLabel.Text = "Mandanten:";
            // 
            // imieLabel
            // 
            imieLabel.AutoSize = true;
            imieLabel.Location = new System.Drawing.Point(226, 81);
            imieLabel.Name = "imieLabel";
            imieLabel.Size = new System.Drawing.Size(65, 13);
            imieLabel.TabIndex = 152;
            imieLabel.Text = "Imie polskie:";
            // 
            // imieDeLabel
            // 
            imieDeLabel.AutoSize = true;
            imieDeLabel.Location = new System.Drawing.Point(16, 81);
            imieDeLabel.Name = "imieDeLabel";
            imieDeLabel.Size = new System.Drawing.Size(82, 13);
            imieDeLabel.TabIndex = 154;
            imieDeLabel.Text = "Imie niemieckie:";
            // 
            // nazwiskoLabel
            // 
            nazwiskoLabel.AutoSize = true;
            nazwiskoLabel.Location = new System.Drawing.Point(226, 42);
            nazwiskoLabel.Name = "nazwiskoLabel";
            nazwiskoLabel.Size = new System.Drawing.Size(92, 13);
            nazwiskoLabel.TabIndex = 158;
            nazwiskoLabel.Text = "Nazwisko polskie:";
            // 
            // nazwiskoDeLabel
            // 
            nazwiskoDeLabel.AutoSize = true;
            nazwiskoDeLabel.Location = new System.Drawing.Point(16, 42);
            nazwiskoDeLabel.Name = "nazwiskoDeLabel";
            nazwiskoDeLabel.Size = new System.Drawing.Size(109, 13);
            nazwiskoDeLabel.TabIndex = 160;
            nazwiskoDeLabel.Text = "Nazwisko niemieckie:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(428, 6);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(28, 13);
            label1.TabIndex = 170;
            label1.Text = "Kraj:";
            // 
            // idLabel2
            // 
            idLabel2.AutoSize = true;
            idLabel2.Location = new System.Drawing.Point(727, 6);
            idLabel2.Name = "idLabel2";
            idLabel2.Size = new System.Drawing.Size(19, 13);
            idLabel2.TabIndex = 172;
            idLabel2.Text = "Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(557, 58);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(78, 13);
            label2.TabIndex = 175;
            label2.Text = "Steuernummer:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(443, 58);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(30, 13);
            label3.TabIndex = 177;
            label3.Text = "Rok:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(691, 108);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(40, 13);
            label4.TabIndex = 179;
            label4.Text = "Status:";
            // 
            // lblOperator
            // 
            this.lblOperator.AutoSize = true;
            this.lblOperator.Location = new System.Drawing.Point(374, 124);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(51, 13);
            this.lblOperator.TabIndex = 181;
            this.lblOperator.Text = "Operator:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(557, 108);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(47, 13);
            label6.TabIndex = 182;
            label6.Text = "Pozycja:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(627, 108);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(30, 13);
            label7.TabIndex = 183;
            label7.Text = "Rok:";
            // 
            // mIdTextBox
            // 
            this.mIdTextBox.Location = new System.Drawing.Point(560, 27);
            this.mIdTextBox.Name = "mIdTextBox";
            this.mIdTextBox.Size = new System.Drawing.Size(118, 20);
            this.mIdTextBox.TabIndex = 165;
            // 
            // imieTextBox
            // 
            this.imieTextBox.Location = new System.Drawing.Point(225, 98);
            this.imieTextBox.Name = "imieTextBox";
            this.imieTextBox.Size = new System.Drawing.Size(200, 20);
            this.imieTextBox.TabIndex = 153;
            // 
            // imieDeTextBox
            // 
            this.imieDeTextBox.Location = new System.Drawing.Point(19, 98);
            this.imieDeTextBox.Name = "imieDeTextBox";
            this.imieDeTextBox.Size = new System.Drawing.Size(200, 20);
            this.imieDeTextBox.TabIndex = 155;
            // 
            // nazwiskoTextBox
            // 
            this.nazwiskoTextBox.Location = new System.Drawing.Point(225, 58);
            this.nazwiskoTextBox.Name = "nazwiskoTextBox";
            this.nazwiskoTextBox.Size = new System.Drawing.Size(200, 20);
            this.nazwiskoTextBox.TabIndex = 159;
            // 
            // nazwiskoDeTextBox
            // 
            this.nazwiskoDeTextBox.Location = new System.Drawing.Point(19, 58);
            this.nazwiskoDeTextBox.Name = "nazwiskoDeTextBox";
            this.nazwiskoDeTextBox.Size = new System.Drawing.Size(200, 20);
            this.nazwiskoDeTextBox.TabIndex = 161;
            // 
            // urodzMaskedTextBoxExt
            // 
            this.urodzMaskedTextBoxExt.Date = null;
            this.urodzMaskedTextBoxExt.Location = new System.Drawing.Point(19, 19);
            this.urodzMaskedTextBoxExt.Name = "urodzMaskedTextBoxExt";
            this.urodzMaskedTextBoxExt.Size = new System.Drawing.Size(100, 20);
            this.urodzMaskedTextBoxExt.TabIndex = 166;
            this.urodzMaskedTextBoxExt.Text = "0001-01-01";
            // 
            // idTextBox2
            // 
            this.idTextBox2.Location = new System.Drawing.Point(684, 26);
            this.idTextBox2.Name = "idTextBox2";
            this.idTextBox2.Size = new System.Drawing.Size(62, 20);
            this.idTextBox2.TabIndex = 173;
            // 
            // krajeDDL1
            // 
            this.krajeDDL1.DisplayMember = "Value";
            this.krajeDDL1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.krajeDDL1.FormattingEnabled = true;
            this.krajeDDL1.Location = new System.Drawing.Point(431, 26);
            this.krajeDDL1.Name = "krajeDDL1";
            this.krajeDDL1.Size = new System.Drawing.Size(121, 21);
            this.krajeDDL1.TabIndex = 174;
            this.krajeDDL1.ValueMember = "numericKey";
            // 
            // SteuernummerTextBox
            // 
            this.SteuernummerTextBox.Location = new System.Drawing.Point(560, 74);
            this.SteuernummerTextBox.Name = "SteuernummerTextBox";
            this.SteuernummerTextBox.Size = new System.Drawing.Size(186, 20);
            this.SteuernummerTextBox.TabIndex = 176;
            // 
            // RokTextBox
            // 
            this.RokTextBox.Location = new System.Drawing.Point(446, 74);
            this.RokTextBox.Name = "RokTextBox";
            this.RokTextBox.Size = new System.Drawing.Size(86, 20);
            this.RokTextBox.TabIndex = 178;
            // 
            // StatusTextBox
            // 
            this.StatusTextBox.Location = new System.Drawing.Point(694, 124);
            this.StatusTextBox.Name = "StatusTextBox";
            this.StatusTextBox.Size = new System.Drawing.Size(52, 20);
            this.StatusTextBox.TabIndex = 180;
            // 
            // OperatorPozycjaTextBox
            // 
            this.OperatorPozycjaTextBox.Location = new System.Drawing.Point(230, 121);
            this.OperatorPozycjaTextBox.Name = "OperatorPozycjaTextBox";
            this.OperatorPozycjaTextBox.Size = new System.Drawing.Size(61, 20);
            this.OperatorPozycjaTextBox.TabIndex = 184;
            // 
            // OperatorRokTextBox
            // 
            this.OperatorRokTextBox.Location = new System.Drawing.Point(627, 124);
            this.OperatorRokTextBox.Name = "OperatorRokTextBox";
            this.OperatorRokTextBox.Size = new System.Drawing.Size(61, 20);
            this.OperatorRokTextBox.TabIndex = 185;
            // 
            // poleconyDDL1
            // 
            this.poleconyDDL1.DisplayMember = "Value";
            this.poleconyDDL1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.poleconyDDL1.FormattingEnabled = true;
            this.poleconyDDL1.Location = new System.Drawing.Point(19, 124);
            this.poleconyDDL1.Name = "poleconyDDL1";
            this.poleconyDDL1.Size = new System.Drawing.Size(121, 21);
            this.poleconyDDL1.TabIndex = 186;
            this.poleconyDDL1.ValueMember = "numericKey";
            // 
            // ucPodstKlientPodglad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.poleconyDDL1);
            this.Controls.Add(this.OperatorRokTextBox);
            this.Controls.Add(this.OperatorPozycjaTextBox);
            this.Controls.Add(label7);
            this.Controls.Add(label6);
            this.Controls.Add(this.lblOperator);
            this.Controls.Add(this.StatusTextBox);
            this.Controls.Add(label4);
            this.Controls.Add(this.RokTextBox);
            this.Controls.Add(label3);
            this.Controls.Add(this.SteuernummerTextBox);
            this.Controls.Add(label2);
            this.Controls.Add(this.idTextBox2);
            this.Controls.Add(this.urodzMaskedTextBoxExt);
            this.Controls.Add(this.krajeDDL1);
            this.Controls.Add(idLabel2);
            this.Controls.Add(label1);
            this.Controls.Add(urodzLabel);
            this.Controls.Add(this.mIdTextBox);
            this.Controls.Add(this.imieTextBox);
            this.Controls.Add(this.imieDeTextBox);
            this.Controls.Add(this.nazwiskoTextBox);
            this.Controls.Add(this.nazwiskoDeTextBox);
            this.Controls.Add(mandIdLabel);
            this.Controls.Add(imieLabel);
            this.Controls.Add(imieDeLabel);
            this.Controls.Add(nazwiskoLabel);
            this.Controls.Add(nazwiskoDeLabel);
            this.Name = "ucPodstKlientPodglad";
            this.Size = new System.Drawing.Size(760, 156);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaskedTextBoxExt urodzMaskedTextBoxExt;
        private System.Windows.Forms.TextBox mIdTextBox;
        private System.Windows.Forms.TextBox imieTextBox;
        private System.Windows.Forms.TextBox imieDeTextBox;
        private System.Windows.Forms.TextBox nazwiskoTextBox;
        private System.Windows.Forms.TextBox nazwiskoDeTextBox;
        private System.Windows.Forms.TextBox idTextBox2;
        private KrajeDDL krajeDDL1;
        private System.Windows.Forms.TextBox SteuernummerTextBox;
        private System.Windows.Forms.TextBox RokTextBox;
        private System.Windows.Forms.TextBox StatusTextBox;
        private System.Windows.Forms.TextBox OperatorPozycjaTextBox;
        private System.Windows.Forms.TextBox OperatorRokTextBox;
        private PoleconyDDL poleconyDDL1;
        private System.Windows.Forms.Label lblOperator;
    }
}

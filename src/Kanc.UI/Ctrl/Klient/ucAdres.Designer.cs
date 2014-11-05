using Kanc.Commons;

namespace Kanc.UI.Ctrl
{
    partial class ucAdres
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
            System.Windows.Forms.Label idLabel2;
            System.Windows.Forms.Label kodLabel1;
            System.Windows.Forms.Label miastoLabel1;
            System.Windows.Forms.Label miejsceLabel1;
            System.Windows.Forms.Label ulicaLabel1;
            System.Windows.Forms.Label krajLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucAdres));
            this.idTextBox2 = new System.Windows.Forms.TextBox();
            this.kodTextBox1 = new System.Windows.Forms.TextBox();
            this.miastoTextBox1 = new System.Windows.Forms.TextBox();
            this.miejsceTextBox1 = new System.Windows.Forms.TextBox();
            this.ulicaTextBox1 = new System.Windows.Forms.TextBox();
            this.krajeDDL1 = new Kanc.Commons.KrajeDDL();
            idLabel2 = new System.Windows.Forms.Label();
            kodLabel1 = new System.Windows.Forms.Label();
            miastoLabel1 = new System.Windows.Forms.Label();
            miejsceLabel1 = new System.Windows.Forms.Label();
            ulicaLabel1 = new System.Windows.Forms.Label();
            krajLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // idLabel2
            // 
            idLabel2.AutoSize = true;
            idLabel2.Location = new System.Drawing.Point(411, 33);
            idLabel2.Name = "idLabel2";
            idLabel2.Size = new System.Drawing.Size(19, 13);
            idLabel2.TabIndex = 18;
            idLabel2.Text = "Id:";
            // 
            // kodLabel1
            // 
            kodLabel1.AutoSize = true;
            kodLabel1.Location = new System.Drawing.Point(3, 6);
            kodLabel1.Name = "kodLabel1";
            kodLabel1.Size = new System.Drawing.Size(29, 13);
            kodLabel1.TabIndex = 20;
            kodLabel1.Text = "Kod:";
            // 
            // miastoLabel1
            // 
            miastoLabel1.AutoSize = true;
            miastoLabel1.Location = new System.Drawing.Point(132, 6);
            miastoLabel1.Name = "miastoLabel1";
            miastoLabel1.Size = new System.Drawing.Size(41, 13);
            miastoLabel1.TabIndex = 22;
            miastoLabel1.Text = "Miasto:";
            // 
            // miejsceLabel1
            // 
            miejsceLabel1.AutoSize = true;
            miejsceLabel1.Location = new System.Drawing.Point(127, 33);
            miejsceLabel1.Name = "miejsceLabel1";
            miejsceLabel1.Size = new System.Drawing.Size(46, 13);
            miejsceLabel1.TabIndex = 24;
            miejsceLabel1.Text = "Miejsce:";
            // 
            // ulicaLabel1
            // 
            ulicaLabel1.AutoSize = true;
            ulicaLabel1.Location = new System.Drawing.Point(311, 6);
            ulicaLabel1.Name = "ulicaLabel1";
            ulicaLabel1.Size = new System.Drawing.Size(34, 13);
            ulicaLabel1.TabIndex = 26;
            ulicaLabel1.Text = "Ulica:";
            // 
            // krajLabel
            // 
            krajLabel.AutoSize = true;
            krajLabel.Location = new System.Drawing.Point(4, 32);
            krajLabel.Name = "krajLabel";
            krajLabel.Size = new System.Drawing.Size(28, 13);
            krajLabel.TabIndex = 35;
            krajLabel.Text = "Kraj:";
            // 
            // idTextBox2
            // 
            this.idTextBox2.Location = new System.Drawing.Point(436, 30);
            this.idTextBox2.Name = "idTextBox2";
            this.idTextBox2.Size = new System.Drawing.Size(49, 20);
            this.idTextBox2.TabIndex = 19;
            // 
            // kodTextBox1
            // 
            this.kodTextBox1.Location = new System.Drawing.Point(38, 3);
            this.kodTextBox1.Name = "kodTextBox1";
            this.kodTextBox1.Size = new System.Drawing.Size(71, 20);
            this.kodTextBox1.TabIndex = 21;
            // 
            // miastoTextBox1
            // 
            this.miastoTextBox1.Location = new System.Drawing.Point(179, 3);
            this.miastoTextBox1.Name = "miastoTextBox1";
            this.miastoTextBox1.Size = new System.Drawing.Size(121, 20);
            this.miastoTextBox1.TabIndex = 23;
            // 
            // miejsceTextBox1
            // 
            this.miejsceTextBox1.Location = new System.Drawing.Point(179, 29);
            this.miejsceTextBox1.Name = "miejsceTextBox1";
            this.miejsceTextBox1.Size = new System.Drawing.Size(121, 20);
            this.miejsceTextBox1.TabIndex = 25;
            // 
            // ulicaTextBox1
            // 
            this.ulicaTextBox1.Location = new System.Drawing.Point(351, 3);
            this.ulicaTextBox1.Name = "ulicaTextBox1";
            this.ulicaTextBox1.Size = new System.Drawing.Size(134, 20);
            this.ulicaTextBox1.TabIndex = 27;
            // 
            // krajeDDL1
            // 
            this.krajeDDL1.DisplayMember = "Key";
            this.krajeDDL1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.krajeDDL1.FormattingEnabled = true;
            this.krajeDDL1.Location = new System.Drawing.Point(38, 30);
            this.krajeDDL1.Name = "krajeDDL1";
            this.krajeDDL1.Size = new System.Drawing.Size(51, 21);
            this.krajeDDL1.TabIndex = 36;
            this.krajeDDL1.ValueMember = "numericKey";
            // 
            // ucAdres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.krajeDDL1);
            this.Controls.Add(krajLabel);
            this.Controls.Add(idLabel2);
            this.Controls.Add(this.idTextBox2);
            this.Controls.Add(kodLabel1);
            this.Controls.Add(this.kodTextBox1);
            this.Controls.Add(miastoLabel1);
            this.Controls.Add(this.miastoTextBox1);
            this.Controls.Add(miejsceLabel1);
            this.Controls.Add(this.miejsceTextBox1);
            this.Controls.Add(ulicaLabel1);
            this.Controls.Add(this.ulicaTextBox1);
            this.Name = "ucAdres";
            this.Size = new System.Drawing.Size(498, 55);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idTextBox2;
        private System.Windows.Forms.TextBox kodTextBox1;
        private System.Windows.Forms.TextBox miastoTextBox1;
        private System.Windows.Forms.TextBox miejsceTextBox1;
        private System.Windows.Forms.TextBox ulicaTextBox1;
        private KrajeDDL krajeDDL1;
    }
}

namespace Kanc.UI.Tests.Forms
{
    partial class Form1
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ucKlient1 = new Kanc.UI.Tests.Controls.ucKlient();
            this.krajeDDL1 = new Kanc.UI.Tests.Controls.KrajeDDL();
            this.krajeDDL2 = new Kanc.UI.Tests.Controls.KrajeDDL();
            this.krajeDDL3 = new Kanc.UI.Tests.Controls.KrajeDDL();
            this.krajeDDL4 = new Kanc.UI.Tests.Controls.KrajeDDL();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.ucKlient1);
            this.flowLayoutPanel1.Controls.Add(this.krajeDDL1);
            this.flowLayoutPanel1.Controls.Add(this.krajeDDL2);
            this.flowLayoutPanel1.Controls.Add(this.krajeDDL3);
            this.flowLayoutPanel1.Controls.Add(this.krajeDDL4);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(629, 324);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // ucKlient1
            // 
            this.ucKlient1.Location = new System.Drawing.Point(3, 3);
            this.ucKlient1.Name = "ucKlient1";
            this.ucKlient1.Size = new System.Drawing.Size(467, 120);
            this.ucKlient1.TabIndex = 0;
            // 
            // krajeDDL1
            // 
            this.krajeDDL1.DisplayMember = "Value";
            this.krajeDDL1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.krajeDDL1.FormattingEnabled = true;
            this.krajeDDL1.Location = new System.Drawing.Point(476, 3);
            this.krajeDDL1.Name = "krajeDDL1";
            this.krajeDDL1.Size = new System.Drawing.Size(121, 21);
            this.krajeDDL1.TabIndex = 1;
            this.krajeDDL1.ValueMember = "numericKey";
            // 
            // krajeDDL2
            // 
            this.krajeDDL2.DisplayMember = "Value";
            this.krajeDDL2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.krajeDDL2.FormattingEnabled = true;
            this.krajeDDL2.Location = new System.Drawing.Point(3, 129);
            this.krajeDDL2.Name = "krajeDDL2";
            this.krajeDDL2.Size = new System.Drawing.Size(121, 21);
            this.krajeDDL2.TabIndex = 2;
            this.krajeDDL2.ValueMember = "numericKey";
            // 
            // krajeDDL3
            // 
            this.krajeDDL3.DisplayMember = "Value";
            this.krajeDDL3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.krajeDDL3.FormattingEnabled = true;
            this.krajeDDL3.Location = new System.Drawing.Point(130, 129);
            this.krajeDDL3.Name = "krajeDDL3";
            this.krajeDDL3.Size = new System.Drawing.Size(121, 21);
            this.krajeDDL3.TabIndex = 3;
            this.krajeDDL3.ValueMember = "numericKey";
            // 
            // krajeDDL4
            // 
            this.krajeDDL4.DisplayMember = "Value";
            this.krajeDDL4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.krajeDDL4.FormattingEnabled = true;
            this.krajeDDL4.Location = new System.Drawing.Point(257, 129);
            this.krajeDDL4.Name = "krajeDDL4";
            this.krajeDDL4.Size = new System.Drawing.Size(121, 21);
            this.krajeDDL4.TabIndex = 4;
            this.krajeDDL4.ValueMember = "numericKey";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 324);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Controls.ucKlient ucKlient1;
        private Controls.KrajeDDL krajeDDL1;
        private Controls.KrajeDDL krajeDDL2;
        private Controls.KrajeDDL krajeDDL3;
        private Controls.KrajeDDL krajeDDL4;
    }
}
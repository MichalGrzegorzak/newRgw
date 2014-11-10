namespace MVCSharp.Examples.WindowsFormsExample.Presentation
{
    partial class MdiChildView
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.userControlView = new MVCSharp.Examples.WindowsFormsExample.Presentation.UserControlView();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(9, 10);
            this.textBox.Margin = new System.Windows.Forms.Padding(2);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(76, 20);
            this.textBox.TabIndex = 0;
            // 
            // userControlView
            // 
            this.userControlView.BackColor = System.Drawing.SystemColors.ControlLight;
            this.userControlView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userControlView.Location = new System.Drawing.Point(89, 11);
            this.userControlView.Margin = new System.Windows.Forms.Padding(2);
            this.userControlView.Name = "userControlView";
            this.userControlView.Size = new System.Drawing.Size(111, 120);
            this.userControlView.TabIndex = 1;
            // 
            // MdiChildView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 157);
            this.Controls.Add(this.userControlView);
            this.Controls.Add(this.textBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MdiChildView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private UserControlView userControlView;
    }
}

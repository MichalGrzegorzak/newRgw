namespace Kanc.MVP.Presentation.Customers
{
    partial class NewCustomerView
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
            this.editCustomerView1 = new Kanc.MVP.Presentation.Customers.EditCustomerView();
            this.SuspendLayout();
            // 
            // editCustomerView1
            // 
            this.editCustomerView1.Age = 0;
            this.editCustomerView1.Id = 0;
            this.editCustomerView1.Location = new System.Drawing.Point(4, 4);
            this.editCustomerView1.Message = "Blad";
            this.editCustomerView1.NazwiskoPl = "editCustomerView1";
            this.editCustomerView1.Size = new System.Drawing.Size(515, 279);
            this.editCustomerView1.TabIndex = 0;
            // 
            // NewCustomerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.editCustomerView1);
            this.NazwiskoPl = "NewCustomerView";
            this.Size = new System.Drawing.Size(515, 279);
            this.ResumeLayout(false);

        }

        #endregion

        private EditCustomerView editCustomerView1;

    }
}

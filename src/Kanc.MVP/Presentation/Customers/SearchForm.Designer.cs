namespace Kanc.MVP.Presentation.Customers
{
    partial class SearchForm
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
            this.searchCustomer1 = new Kanc.MVP.Presentation.Customers.SearchCustomer();
            this.SuspendLayout();
            // 
            // searchCustomer1
            // 
            this.searchCustomer1.Location = new System.Drawing.Point(11, 11);
            this.searchCustomer1.Margin = new System.Windows.Forms.Padding(2);
            this.searchCustomer1.Message = "";
            this.searchCustomer1.Name = "searchCustomer1";
            this.searchCustomer1.Nazwisko = "Snow";
            this.searchCustomer1.Size = new System.Drawing.Size(299, 264);
            this.searchCustomer1.TabIndex = 0;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 292);
            this.Controls.Add(this.searchCustomer1);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.ResumeLayout(false);

        }

        #endregion

        private SearchCustomer searchCustomer1;

    }
}
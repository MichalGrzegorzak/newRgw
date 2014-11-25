using Kanc.MVP.Controls;
using Kanc.MVP.UIControls;

namespace Kanc.MVP.Presentation.Search
{
    partial class SearchCustomer
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.searchButton = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.errLabel = new System.Windows.Forms.Label();
            this.cmbUsers = new System.Windows.Forms.ComboBox();
            this.gridOrders = new System.Windows.Forms.DataGridView();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.urodzTextBox = new Kanc.MVP.UIControls.MaskedDateTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.searchButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.nameTextBox, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.errLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbUsers, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.gridOrders, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnNewOrder, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.urodzTextBox, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(299, 264);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchButton.Location = new System.Drawing.Point(2, 2);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchButton.Name = "searchButton";
            this.tableLayoutPanel1.SetRowSpan(this.searchButton, 2);
            this.searchButton.Size = new System.Drawing.Size(86, 36);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Szukaj";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Location = new System.Drawing.Point(92, 0);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(46, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameTextBox.Location = new System.Drawing.Point(142, 2);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(155, 20);
            this.nameTextBox.TabIndex = 3;
            this.nameTextBox.Text = "Snow";
            // 
            // errLabel
            // 
            this.errLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.errLabel, 3);
            this.errLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.errLabel.ForeColor = System.Drawing.Color.Red;
            this.errLabel.Location = new System.Drawing.Point(3, 40);
            this.errLabel.Name = "errLabel";
            this.errLabel.Size = new System.Drawing.Size(293, 20);
            this.errLabel.TabIndex = 5;
            this.errLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbUsers
            // 
            this.cmbUsers.FormattingEnabled = true;
            this.cmbUsers.Location = new System.Drawing.Point(3, 63);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new System.Drawing.Size(84, 21);
            this.cmbUsers.TabIndex = 6;
            this.cmbUsers.SelectedIndexChanged += new System.EventHandler(this.cmbUsers_SelectedIndexChanged);
            // 
            // gridOrders
            // 
            this.gridOrders.AllowUserToDeleteRows = false;
            this.gridOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.gridOrders, 2);
            this.gridOrders.Location = new System.Drawing.Point(93, 89);
            this.gridOrders.Name = "gridOrders";
            this.gridOrders.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this.gridOrders, 2);
            this.gridOrders.Size = new System.Drawing.Size(203, 172);
            this.gridOrders.TabIndex = 7;
            this.gridOrders.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridOrders_CellDoubleClick);
            this.gridOrders.CurrentCellChanged += new System.EventHandler(this.gridOrders_CurrentCellChanged);
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNewOrder.Location = new System.Drawing.Point(143, 63);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(44, 20);
            this.btnNewOrder.TabIndex = 8;
            this.btnNewOrder.Text = "Dodaj";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Urodz:";
            // 
            // urodzTextBox
            // 
            this.urodzTextBox.DateValue = null;
            this.urodzTextBox.Location = new System.Drawing.Point(143, 23);
            this.urodzTextBox.Mask = "00/00/0000";
            this.urodzTextBox.Name = "urodzTextBox";
            this.urodzTextBox.RequireValidEntry = true;
            this.urodzTextBox.Size = new System.Drawing.Size(100, 20);
            this.urodzTextBox.TabIndex = 10;
            // 
            // SearchCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SearchCustomer";
            this.Size = new System.Drawing.Size(299, 264);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label errLabel;
        private System.Windows.Forms.ComboBox cmbUsers;
        private System.Windows.Forms.DataGridView gridOrders;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.Label label1;
        private MaskedDateTextBox urodzTextBox;
    }
}

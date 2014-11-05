namespace Kanc.UI.Ctrl
{
    partial class ucHistoriaPodglad
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
            this.historiaGridView = new System.Windows.Forms.DataGridView();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historiabindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dataPrzeniesieniaTextBox = new System.Windows.Forms.TextBox();
            this.dataPrzyjeciaTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.historiaGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historiabindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // historiaGridView
            // 
            this.historiaGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historiaGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Status,
            this.CreatedOn,
            this.CreatedBy});
            this.historiaGridView.Location = new System.Drawing.Point(3, 3);
            this.historiaGridView.Name = "historiaGridView";
            this.historiaGridView.Size = new System.Drawing.Size(349, 150);
            this.historiaGridView.TabIndex = 0;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // CreatedOn
            // 
            this.CreatedOn.DataPropertyName = "CreatedOn";
            this.CreatedOn.HeaderText = "Zmieniono dnia";
            this.CreatedOn.Name = "CreatedOn";
            this.CreatedOn.ReadOnly = true;
            // 
            // CreatedBy
            // 
            this.CreatedBy.DataPropertyName = "CreatedBy";
            this.CreatedBy.HeaderText = "Zmieniono przez";
            this.CreatedBy.Name = "CreatedBy";
            this.CreatedBy.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(371, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data przeniesienia:";
            // 
            // dataPrzeniesieniaTextBox
            // 
            this.dataPrzeniesieniaTextBox.Location = new System.Drawing.Point(374, 19);
            this.dataPrzeniesieniaTextBox.Name = "dataPrzeniesieniaTextBox";
            this.dataPrzeniesieniaTextBox.Size = new System.Drawing.Size(100, 20);
            this.dataPrzeniesieniaTextBox.TabIndex = 2;
            // 
            // dataPrzyjeciaTextBox
            // 
            this.dataPrzyjeciaTextBox.Location = new System.Drawing.Point(490, 19);
            this.dataPrzyjeciaTextBox.Name = "dataPrzyjeciaTextBox";
            this.dataPrzyjeciaTextBox.Size = new System.Drawing.Size(100, 20);
            this.dataPrzyjeciaTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(487, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data przyjęcia:";
            // 
            // ucHistoriaPodglad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataPrzyjeciaTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataPrzeniesieniaTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.historiaGridView);
            this.Name = "ucHistoriaPodglad";
            this.Size = new System.Drawing.Size(647, 259);
            ((System.ComponentModel.ISupportInitialize)(this.historiaGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historiabindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView historiaGridView;
        private System.Windows.Forms.BindingSource historiabindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dataPrzeniesieniaTextBox;
        private System.Windows.Forms.TextBox dataPrzyjeciaTextBox;
        private System.Windows.Forms.Label label2;
    }
}

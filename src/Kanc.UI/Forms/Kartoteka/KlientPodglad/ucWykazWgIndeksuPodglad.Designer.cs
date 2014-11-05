namespace Kanc.UI.Ctrl
{
    partial class ucWykazWgIndeksuPodglad
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
            this.wykazGridView = new System.Windows.Forms.DataGridView();
            this.wykazBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MandId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.wykazGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wykazBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // wykazGridView
            // 
            this.wykazGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wykazGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MandId,
            this.Rok,
            this.Status,
            this.CreatedOn,
            this.CreatedBy,
            this.MovedOn});
            this.wykazGridView.Location = new System.Drawing.Point(0, 0);
            this.wykazGridView.Name = "wykazGridView";
            this.wykazGridView.Size = new System.Drawing.Size(654, 226);
            this.wykazGridView.TabIndex = 0;
            // 
            // MandId
            // 
            this.MandId.DataPropertyName = "MandId";
            this.MandId.HeaderText = "Mand";
            this.MandId.Name = "MandId";
            this.MandId.ReadOnly = true;
            // 
            // Rok
            // 
            this.Rok.DataPropertyName = "Rok";
            this.Rok.HeaderText = "Rok";
            this.Rok.Name = "Rok";
            this.Rok.ReadOnly = true;
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
            this.CreatedOn.HeaderText = "Data przyjęcia";
            this.CreatedOn.Name = "CreatedOn";
            this.CreatedOn.ReadOnly = true;
            // 
            // CreatedBy
            // 
            this.CreatedBy.DataPropertyName = "CreatedBy";
            this.CreatedBy.HeaderText = "Operator";
            this.CreatedBy.Name = "CreatedBy";
            this.CreatedBy.ReadOnly = true;
            // 
            // MovedOn
            // 
            this.MovedOn.DataPropertyName = "MovedOn";
            this.MovedOn.HeaderText = "Data przeniesienia";
            this.MovedOn.Name = "MovedOn";
            this.MovedOn.ReadOnly = true;
            // 
            // ucWykazWgIndeksuPodglad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.wykazGridView);
            this.Name = "ucWykazWgIndeksuPodglad";
            this.Size = new System.Drawing.Size(680, 351);
            this.Load += new System.EventHandler(this.ucWykazWgIndeksuPodglad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wykazGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wykazBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView wykazGridView;
        private System.Windows.Forms.BindingSource wykazBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn MandId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rok;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovedOn;
    }
}

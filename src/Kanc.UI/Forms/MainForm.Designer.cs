namespace Kanc.UI.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnCloseAll = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Forms = new System.Windows.Forms.ToolStripMenuItem();
            this.formWprowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.form3ucKlientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.report1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.przegladToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.test1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.podatekStronaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.test2BazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.report1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabForm = new System.Windows.Forms.TabControl();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Location = new System.Drawing.Point(65, 644);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(919, 18);
            this.toolStrip2.TabIndex = 8;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSearch,
            this.btnNew,
            this.btnSave,
            this.btnCloseAll});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(65, 638);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = false;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(66, 73);
            this.btnSearch.Text = "Szukaj";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnNew
            // 
            this.btnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(63, 68);
            this.btnNew.Text = "btnNew";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = false;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(66, 73);
            this.btnSave.Text = "Zapisz";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCloseAll
            // 
            this.btnCloseAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCloseAll.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseAll.Image")));
            this.btnCloseAll.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCloseAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCloseAll.Name = "btnCloseAll";
            this.btnCloseAll.Size = new System.Drawing.Size(63, 68);
            this.btnCloseAll.Text = "btnCloseAll";
            this.btnCloseAll.Click += new System.EventHandler(this.btnCloseAll_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Forms,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Forms
            // 
            this.Forms.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formWprowToolStripMenuItem,
            this.form3ucKlientToolStripMenuItem,
            this.report1ToolStripMenuItem,
            this.przegladToolStripMenuItem,
            this.mnuExit,
            this.test1ToolStripMenuItem,
            this.podatekStronaToolStripMenuItem,
            this.test2BazaToolStripMenuItem});
            this.Forms.Name = "Forms";
            this.Forms.Size = new System.Drawing.Size(52, 20);
            this.Forms.Text = "Forms";
            // 
            // formWprowToolStripMenuItem
            // 
            this.formWprowToolStripMenuItem.Name = "formWprowToolStripMenuItem";
            this.formWprowToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.formWprowToolStripMenuItem.Text = "FormWprow";
            this.formWprowToolStripMenuItem.Click += new System.EventHandler(this.formWprowToolStripMenuItem_Click);
            // 
            // form3ucKlientToolStripMenuItem
            // 
            this.form3ucKlientToolStripMenuItem.Name = "form3ucKlientToolStripMenuItem";
            this.form3ucKlientToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.form3ucKlientToolStripMenuItem.Text = "Search";
            this.form3ucKlientToolStripMenuItem.Click += new System.EventHandler(this.form3ucKlientToolStripMenuItem_Click);
            // 
            // report1ToolStripMenuItem
            // 
            this.report1ToolStripMenuItem.Name = "report1ToolStripMenuItem";
            this.report1ToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.report1ToolStripMenuItem.Text = "DodajBank";
            this.report1ToolStripMenuItem.Click += new System.EventHandler(this.report1ToolStripMenuItem_Click);
            // 
            // przegladToolStripMenuItem
            // 
            this.przegladToolStripMenuItem.Name = "przegladToolStripMenuItem";
            this.przegladToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.przegladToolStripMenuItem.Text = "Przeglad";
            this.przegladToolStripMenuItem.Click += new System.EventHandler(this.przegladToolStripMenuItem_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(151, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // test1ToolStripMenuItem
            // 
            this.test1ToolStripMenuItem.Name = "test1ToolStripMenuItem";
            this.test1ToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.test1ToolStripMenuItem.Text = "Test1";
            this.test1ToolStripMenuItem.Click += new System.EventHandler(this.test1ToolStripMenuItem_Click);
            // 
            // podatekStronaToolStripMenuItem
            // 
            this.podatekStronaToolStripMenuItem.Name = "podatekStronaToolStripMenuItem";
            this.podatekStronaToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.podatekStronaToolStripMenuItem.Text = "PodatekStrona";
            this.podatekStronaToolStripMenuItem.Click += new System.EventHandler(this.podatekStronaToolStripMenuItem_Click);
            // 
            // test2BazaToolStripMenuItem
            // 
            this.test2BazaToolStripMenuItem.Name = "test2BazaToolStripMenuItem";
            this.test2BazaToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.test2BazaToolStripMenuItem.Text = "Test2 - Baza";
            this.test2BazaToolStripMenuItem.Click += new System.EventHandler(this.test2BazaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.report1ToolStripMenuItem1});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(60, 20);
            this.toolStripMenuItem1.Text = "Raporty";
            // 
            // report1ToolStripMenuItem1
            // 
            this.report1ToolStripMenuItem1.Name = "report1ToolStripMenuItem1";
            this.report1ToolStripMenuItem1.Size = new System.Drawing.Size(115, 22);
            this.report1ToolStripMenuItem1.Text = "Report1";
            this.report1ToolStripMenuItem1.Click += new System.EventHandler(this.report1ToolStripMenuItem1_Click);
            // 
            // tabForm
            // 
            this.tabForm.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabForm.HotTrack = true;
            this.tabForm.Location = new System.Drawing.Point(65, 24);
            this.tabForm.Name = "tabForm";
            this.tabForm.SelectedIndex = 0;
            this.tabForm.Size = new System.Drawing.Size(919, 20);
            this.tabForm.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 662);
            this.Controls.Add(this.tabForm);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1001, 701);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kancelaria Rogów v0.3";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Forms;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem form3ucKlientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem report1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formWprowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem przegladToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem report1ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem test1ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton btnCloseAll;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripMenuItem podatekStronaToolStripMenuItem;
        private System.Windows.Forms.TabControl tabForm;
        private System.Windows.Forms.ToolStripMenuItem test2BazaToolStripMenuItem;
    }
}


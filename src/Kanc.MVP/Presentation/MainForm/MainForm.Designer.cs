namespace Kanc.MVP.Presentation.MainForm
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
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.klientToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.szukajToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.notesToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.newBtn = new System.Windows.Forms.ToolStripSplitButton();
            this.mailMessageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.noteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.taskToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.navigateBar = new MT.WindowsUI.NavigationPane.NavigateBar();
            this.mailNavBtn = new MT.WindowsUI.NavigationPane.NavigateBarButton();
            this.notesNavBtn = new MT.WindowsUI.NavigationPane.NavigateBarButton();
            this.szukajNavButton = new MT.WindowsUI.NavigationPane.NavigateBarButton();
            this.mtSplitter = new MT.WindowsUI.MTSplitter();
            this.contentPanel = new Owf.Controls.OutlookPanelEx();
            this.topSpacePanel = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mailMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip.SuspendLayout();
            this.navigateBar.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.klientToolStripButton,
            this.toolStripSeparator1,
            this.szukajToolStripButton,
            this.notesToolStripButton,
            this.btnSave,
            this.btnCancel,
            this.newBtn});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(440, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // klientToolStripButton
            // 
            this.klientToolStripButton.Image = global::Kanc.MVP.Properties.Resources.Mail24;
            this.klientToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.klientToolStripButton.Name = "klientToolStripButton";
            this.klientToolStripButton.Size = new System.Drawing.Size(58, 22);
            this.klientToolStripButton.Text = "Nowy";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // szukajToolStripButton
            // 
            this.szukajToolStripButton.Image = global::Kanc.MVP.Properties.Resources.Mail;
            this.szukajToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.szukajToolStripButton.Name = "szukajToolStripButton";
            this.szukajToolStripButton.Size = new System.Drawing.Size(60, 22);
            this.szukajToolStripButton.Text = "Szukaj";
            this.szukajToolStripButton.Click += new System.EventHandler(this.catToolStripItem_Click);
            // 
            // notesToolStripButton
            // 
            this.notesToolStripButton.Image = global::Kanc.MVP.Properties.Resources.Notes;
            this.notesToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.notesToolStripButton.Name = "notesToolStripButton";
            this.notesToolStripButton.Size = new System.Drawing.Size(58, 22);
            this.notesToolStripButton.Text = "Notes";
            this.notesToolStripButton.Click += new System.EventHandler(this.catToolStripItem_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(60, 22);
            this.btnSave.Text = "Zapisz";
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(62, 22);
            this.btnCancel.Text = "Anuluj";
            // 
            // newBtn
            // 
            this.newBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mailMessageToolStripMenuItem1,
            this.noteToolStripMenuItem1,
            this.taskToolStripMenuItem1});
            this.newBtn.Image = global::Kanc.MVP.Properties.Resources.New;
            this.newBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(63, 22);
            this.newBtn.Text = "New";
            // 
            // mailMessageToolStripMenuItem1
            // 
            this.mailMessageToolStripMenuItem1.Image = global::Kanc.MVP.Properties.Resources.Mail;
            this.mailMessageToolStripMenuItem1.Name = "mailMessageToolStripMenuItem1";
            this.mailMessageToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.mailMessageToolStripMenuItem1.Text = "Mail";
            this.mailMessageToolStripMenuItem1.Click += new System.EventHandler(this.newToolStripItem_Click);
            // 
            // noteToolStripMenuItem1
            // 
            this.noteToolStripMenuItem1.Image = global::Kanc.MVP.Properties.Resources.Notes;
            this.noteToolStripMenuItem1.Name = "noteToolStripMenuItem1";
            this.noteToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.noteToolStripMenuItem1.Text = "Note";
            this.noteToolStripMenuItem1.Click += new System.EventHandler(this.newToolStripItem_Click);
            // 
            // taskToolStripMenuItem1
            // 
            this.taskToolStripMenuItem1.Image = global::Kanc.MVP.Properties.Resources.Tasks;
            this.taskToolStripMenuItem1.Name = "taskToolStripMenuItem1";
            this.taskToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.taskToolStripMenuItem1.Text = "Task";
            this.taskToolStripMenuItem1.Click += new System.EventHandler(this.newToolStripItem_Click);
            // 
            // navigateBar
            // 
            this.navigateBar.AlwaysUseSystemColors = false;
            this.navigateBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.navigateBar.CollapsibleWidth = 27;
            this.navigateBar.Controls.Add(this.mailNavBtn);
            this.navigateBar.Controls.Add(this.notesNavBtn);
            this.navigateBar.Controls.Add(this.szukajNavButton);
            this.navigateBar.DisplayedButtonCount = 3;
            this.navigateBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigateBar.Location = new System.Drawing.Point(0, 51);
            this.navigateBar.Margin = new System.Windows.Forms.Padding(2);
            this.navigateBar.MinimumSize = new System.Drawing.Size(16, 81);
            this.navigateBar.Name = "navigateBar";
            this.navigateBar.NavigateBarButtons.AddRange(new MT.WindowsUI.NavigationPane.NavigateBarButton[] {
            this.mailNavBtn,
            this.notesNavBtn,
            this.szukajNavButton});
            this.navigateBar.NavigateBarColorTable = ((MT.WindowsUI.NavigationPane.NavigateBarColorTable)(resources.GetObject("navigateBar.NavigateBarColorTable")));
            this.navigateBar.NavigateBarDisplayedButtonCount = 3;
            this.navigateBar.SelectedButton = this.mailNavBtn;
            this.navigateBar.Size = new System.Drawing.Size(116, 300);
            this.navigateBar.TabIndex = 1;
            this.navigateBar.Text = "navigateBar";
            this.navigateBar.OnNavigateBarButtonSelected += new MT.WindowsUI.NavigationPane.NavigateBar.OnNavigateBarButtonEventHandler(this.navigateBar_OnNavigateBarButtonSelected);
            // 
            // mailNavBtn
            // 
            this.mailNavBtn.Caption = "Klient";
            this.mailNavBtn.CaptionDescription = "Mail items";
            this.mailNavBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mailNavBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mailNavBtn.Image = ((System.Drawing.Image)(resources.GetObject("mailNavBtn.Image")));
            this.mailNavBtn.IsSelected = true;
            this.mailNavBtn.IsShowCaptionDescription = false;
            this.mailNavBtn.IsShowCaptionImage = false;
            this.mailNavBtn.IsShowCollapseScreenCaption = false;
            this.mailNavBtn.Key = "C633862AFB6748E98839B2EDD82D1073";
            this.mailNavBtn.Location = new System.Drawing.Point(0, 172);
            this.mailNavBtn.Margin = new System.Windows.Forms.Padding(2);
            this.mailNavBtn.MinimumSize = new System.Drawing.Size(16, 16);
            this.mailNavBtn.MouseOverImage = ((System.Drawing.Image)(resources.GetObject("mailNavBtn.MouseOverImage")));
            this.mailNavBtn.Name = "mailNavBtn";
            this.mailNavBtn.SelectedImage = ((System.Drawing.Image)(resources.GetObject("mailNavBtn.SelectedImage")));
            this.mailNavBtn.Size = new System.Drawing.Size(116, 32);
            this.mailNavBtn.TabIndex = 4;
            this.mailNavBtn.ToolTipText = "Mail category";
            // 
            // notesNavBtn
            // 
            this.notesNavBtn.Caption = "Druki";
            this.notesNavBtn.CaptionDescription = "Notes category";
            this.notesNavBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.notesNavBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.notesNavBtn.Image = ((System.Drawing.Image)(resources.GetObject("notesNavBtn.Image")));
            this.notesNavBtn.IsSelected = false;
            this.notesNavBtn.IsShowCaptionDescription = false;
            this.notesNavBtn.IsShowCaptionImage = false;
            this.notesNavBtn.IsShowCollapseScreenCaption = false;
            this.notesNavBtn.Key = "7113C017B2324E83B0380687F78236BF";
            this.notesNavBtn.Location = new System.Drawing.Point(0, 204);
            this.notesNavBtn.Margin = new System.Windows.Forms.Padding(2);
            this.notesNavBtn.MinimumSize = new System.Drawing.Size(16, 16);
            this.notesNavBtn.MouseOverImage = ((System.Drawing.Image)(resources.GetObject("notesNavBtn.MouseOverImage")));
            this.notesNavBtn.Name = "notesNavBtn";
            this.notesNavBtn.SelectedImage = ((System.Drawing.Image)(resources.GetObject("notesNavBtn.SelectedImage")));
            this.notesNavBtn.Size = new System.Drawing.Size(116, 32);
            this.notesNavBtn.TabIndex = 5;
            this.notesNavBtn.ToolTipText = "Notes category";
            // 
            // szukajNavButton
            // 
            this.szukajNavButton.Caption = "Szukaj";
            this.szukajNavButton.CaptionDescription = "Szukaj";
            this.szukajNavButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.szukajNavButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.szukajNavButton.Image = global::Kanc.MVP.Properties.Resources.Notes24;
            this.szukajNavButton.IsSelected = false;
            this.szukajNavButton.IsShowCaptionDescription = false;
            this.szukajNavButton.IsShowCaptionImage = false;
            this.szukajNavButton.IsShowCollapseScreenCaption = false;
            this.szukajNavButton.Key = "E0601B65D9E34D0290254CFD59C96CF5";
            this.szukajNavButton.Location = new System.Drawing.Point(0, 236);
            this.szukajNavButton.MinimumSize = new System.Drawing.Size(22, 20);
            this.szukajNavButton.MouseOverImage = global::Kanc.MVP.Properties.Resources.Notes24;
            this.szukajNavButton.Name = "szukajNavButton";
            this.szukajNavButton.SelectedImage = global::Kanc.MVP.Properties.Resources.Notes24;
            this.szukajNavButton.Size = new System.Drawing.Size(116, 32);
            this.szukajNavButton.TabIndex = 7;
            this.szukajNavButton.ToolTipText = "NavigateBarButton";
            this.szukajNavButton.Click += new System.EventHandler(this.szukajNavButton_Click);
            // 
            // mtSplitter
            // 
            this.mtSplitter.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.mtSplitter.Location = new System.Drawing.Point(116, 51);
            this.mtSplitter.Margin = new System.Windows.Forms.Padding(2);
            this.mtSplitter.Name = "mtSplitter";
            this.mtSplitter.Size = new System.Drawing.Size(3, 300);
            this.mtSplitter.SplitterBorderColor = System.Drawing.Color.Transparent;
            this.mtSplitter.SplitterDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(144)))), ((int)(((byte)(212)))));
            this.mtSplitter.SplitterLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
            this.mtSplitter.SplitterPaintAngle = 90F;
            this.mtSplitter.TabIndex = 2;
            this.mtSplitter.TabStop = false;
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.contentPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(156)))), ((int)(((byte)(205)))));
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.HeaderColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.contentPanel.HeaderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(212)))), ((int)(((byte)(255)))));
            this.contentPanel.HeaderText = "Inbox";
            this.contentPanel.HeaderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.contentPanel.Icon = null;
            this.contentPanel.IconTransparentColor = System.Drawing.Color.White;
            this.contentPanel.Location = new System.Drawing.Point(119, 51);
            this.contentPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Padding = new System.Windows.Forms.Padding(4, 24, 4, 3);
            this.contentPanel.Size = new System.Drawing.Size(321, 300);
            this.contentPanel.TabIndex = 3;
            // 
            // topSpacePanel
            // 
            this.topSpacePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
            this.topSpacePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topSpacePanel.Location = new System.Drawing.Point(0, 49);
            this.topSpacePanel.Margin = new System.Windows.Forms.Padding(2);
            this.topSpacePanel.Name = "topSpacePanel";
            this.topSpacePanel.Size = new System.Drawing.Size(440, 2);
            this.topSpacePanel.TabIndex = 0;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(440, 24);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mailMessageToolStripMenuItem,
            this.noteToolStripMenuItem,
            this.taskToolStripMenuItem});
            this.newToolStripMenuItem.Image = global::Kanc.MVP.Properties.Resources.New;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // mailMessageToolStripMenuItem
            // 
            this.mailMessageToolStripMenuItem.Image = global::Kanc.MVP.Properties.Resources.Mail;
            this.mailMessageToolStripMenuItem.Name = "mailMessageToolStripMenuItem";
            this.mailMessageToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.mailMessageToolStripMenuItem.Text = "Mail";
            this.mailMessageToolStripMenuItem.Click += new System.EventHandler(this.newToolStripItem_Click);
            // 
            // noteToolStripMenuItem
            // 
            this.noteToolStripMenuItem.Image = global::Kanc.MVP.Properties.Resources.Notes;
            this.noteToolStripMenuItem.Name = "noteToolStripMenuItem";
            this.noteToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.noteToolStripMenuItem.Text = "Note";
            this.noteToolStripMenuItem.Click += new System.EventHandler(this.newToolStripItem_Click);
            // 
            // taskToolStripMenuItem
            // 
            this.taskToolStripMenuItem.Image = global::Kanc.MVP.Properties.Resources.Tasks;
            this.taskToolStripMenuItem.Name = "taskToolStripMenuItem";
            this.taskToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.taskToolStripMenuItem.Text = "Task";
            this.taskToolStripMenuItem.Click += new System.EventHandler(this.newToolStripItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mailToolStripMenuItem,
            this.notesToolStripMenuItem,
            this.tasksToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // mailToolStripMenuItem
            // 
            this.mailToolStripMenuItem.Image = global::Kanc.MVP.Properties.Resources.Mail;
            this.mailToolStripMenuItem.Name = "mailToolStripMenuItem";
            this.mailToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.mailToolStripMenuItem.Text = "Mail";
            this.mailToolStripMenuItem.Click += new System.EventHandler(this.catToolStripItem_Click);
            // 
            // notesToolStripMenuItem
            // 
            this.notesToolStripMenuItem.Image = global::Kanc.MVP.Properties.Resources.Notes;
            this.notesToolStripMenuItem.Name = "notesToolStripMenuItem";
            this.notesToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.notesToolStripMenuItem.Text = "Notes";
            this.notesToolStripMenuItem.Click += new System.EventHandler(this.catToolStripItem_Click);
            // 
            // tasksToolStripMenuItem
            // 
            this.tasksToolStripMenuItem.Image = global::Kanc.MVP.Properties.Resources.Tasks;
            this.tasksToolStripMenuItem.Name = "tasksToolStripMenuItem";
            this.tasksToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.tasksToolStripMenuItem.Text = "Tasks";
            this.tasksToolStripMenuItem.Click += new System.EventHandler(this.catToolStripItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(440, 351);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.mtSplitter);
            this.Controls.Add(this.navigateBar);
            this.Controls.Add(this.topSpacePanel);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rgw testing";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.navigateBar.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private MT.WindowsUI.NavigationPane.NavigateBar navigateBar;
        private MT.WindowsUI.MTSplitter mtSplitter;
        private MT.WindowsUI.NavigationPane.NavigateBarButton mailNavBtn;
        private MT.WindowsUI.NavigationPane.NavigateBarButton notesNavBtn;
        private Owf.Controls.OutlookPanelEx contentPanel;
        private System.Windows.Forms.Panel topSpacePanel;
        private System.Windows.Forms.ToolStripSplitButton newBtn;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mailMessageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton szukajToolStripButton;
        private System.Windows.Forms.ToolStripButton notesToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem mailMessageToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem noteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem taskToolStripMenuItem1;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private MT.WindowsUI.NavigationPane.NavigateBarButton szukajNavButton;
        private System.Windows.Forms.ToolStripButton klientToolStripButton;
    }
}


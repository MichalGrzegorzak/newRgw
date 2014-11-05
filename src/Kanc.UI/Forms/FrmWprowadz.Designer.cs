namespace Kanc.UI.Forms
{
    partial class FrmWprowadz
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label notkaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWprowadz));
            this.rozliczenieBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.lblStatus = new System.Windows.Forms.ToolStripLabel();
            this.notkaTextBox = new System.Windows.Forms.TextBox();
            this.ucKonto1 = new Kanc.UI.Ctrl.ucKonto();
            this.ucAdres1 = new Kanc.UI.Ctrl.ucAdres();
            this.ucDzieci1 = new Kanc.UI.Ctrl.ucDzieci();
            this.ucWlascicielKonta1 = new Kanc.UI.Ctrl.ucWlascicielKonta();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PodatekNiemcyTab = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.PodatekStrona = new System.Windows.Forms.Button();
            this.EuEwrButton = new System.Windows.Forms.Button();
            this.DrukujEstkButton = new System.Windows.Forms.Button();
            this.lblRok = new System.Windows.Forms.Label();
            this.JahrTextBox = new System.Windows.Forms.TextBox();
            this._ucEdycjaKlient1 = new Kanc.UI.Ctrl.ucEdycjaKlient();
            this.typyListGrpBox1 = new Kanc.Commons.TypyListGrpBox();
            this.ucMandatenID1 = new Kanc.UI.Ctrl.Klient.ucMandatenID();
            this.krajeDDL1 = new Kanc.Commons.KrajeDDL();
            this.ucNagrodaListy1 = new Kanc.UI.Ctrl.ucNagrodaListy();
            this.ucPartner1 = new Kanc.UI.Ctrl.ucPartner();
            this.poleconyDDL1 = new Kanc.Commons.PoleconyDDL();
            notkaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IdsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rozliczenieBindingNavigator)).BeginInit();
            this.rozliczenieBindingNavigator.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.PodatekNiemcyTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.DataSource = this.MainBindingSrc;
            // 
            // notkaLabel
            // 
            notkaLabel.AutoSize = true;
            notkaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            notkaLabel.Location = new System.Drawing.Point(773, 283);
            notkaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            notkaLabel.Name = "notkaLabel";
            notkaLabel.Size = new System.Drawing.Size(47, 16);
            notkaLabel.TabIndex = 19;
            notkaLabel.Text = "Notka:";
            // 
            // rozliczenieBindingNavigator
            // 
            this.rozliczenieBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.rozliczenieBindingNavigator.CanOverflow = false;
            this.rozliczenieBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.rozliczenieBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.rozliczenieBindingNavigator.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.rozliczenieBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.rozliczenieBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.bindingNavigatorSaveItem,
            this.toolStripTextBox1,
            this.toolStripButton1,
            this.lblStatus});
            this.rozliczenieBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.rozliczenieBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.rozliczenieBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.rozliczenieBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.rozliczenieBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.rozliczenieBindingNavigator.Name = "rozliczenieBindingNavigator";
            this.rozliczenieBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.rozliczenieBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.rozliczenieBindingNavigator.Size = new System.Drawing.Size(1034, 31);
            this.rozliczenieBindingNavigator.TabIndex = 0;
            this.rozliczenieBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(47, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(73, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorSaveItem
            // 
            this.bindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorSaveItem.Image")));
            this.bindingNavigatorSaveItem.Name = "bindingNavigatorSaveItem";
            this.bindingNavigatorSaveItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorSaveItem.Text = "Save Data";
            this.bindingNavigatorSaveItem.Click += new System.EventHandler(this.bindingNavigatorSavetItem_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(148, 31);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 28);
            // 
            // notkaTextBox
            // 
            this.notkaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notkaTextBox.Location = new System.Drawing.Point(590, 304);
            this.notkaTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.notkaTextBox.Multiline = true;
            this.notkaTextBox.Name = "notkaTextBox";
            this.notkaTextBox.Size = new System.Drawing.Size(230, 122);
            this.notkaTextBox.TabIndex = 20;
            // 
            // ucKonto1
            // 
            this.ucKonto1.Binder = null;
            this.ucKonto1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucKonto1.Location = new System.Drawing.Point(0, 299);
            this.ucKonto1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucKonto1.Name = "ucKonto1";
            this.ucKonto1.Session = null;
            this.ucKonto1.Size = new System.Drawing.Size(582, 127);
            this.ucKonto1.TabIndex = 9999;
            // 
            // ucAdres1
            // 
            this.ucAdres1.Binder = null;
            this.ucAdres1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucAdres1.Location = new System.Drawing.Point(0, 222);
            this.ucAdres1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucAdres1.Name = "ucAdres1";
            this.ucAdres1.Session = null;
            this.ucAdres1.Size = new System.Drawing.Size(676, 78);
            this.ucAdres1.TabIndex = 9999;
            // 
            // ucDzieci1
            // 
            this.ucDzieci1.Binder = null;
            this.ucDzieci1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucDzieci1.Location = new System.Drawing.Point(4, 596);
            this.ucDzieci1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucDzieci1.Name = "ucDzieci1";
            this.ucDzieci1.Session = null;
            this.ucDzieci1.Size = new System.Drawing.Size(721, 54);
            this.ucDzieci1.TabIndex = 9999;
            // 
            // ucWlascicielKonta1
            // 
            this.ucWlascicielKonta1.Binder = null;
            this.ucWlascicielKonta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucWlascicielKonta1.Location = new System.Drawing.Point(4, 436);
            this.ucWlascicielKonta1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucWlascicielKonta1.Name = "ucWlascicielKonta1";
            this.ucWlascicielKonta1.Session = null;
            this.ucWlascicielKonta1.Size = new System.Drawing.Size(717, 34);
            this.ucWlascicielKonta1.TabIndex = 9999;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.PodatekNiemcyTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(0, 804);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1034, 78);
            this.tabControl1.TabIndex = 85;
            // 
            // PodatekNiemcyTab
            // 
            this.PodatekNiemcyTab.Controls.Add(this.button3);
            this.PodatekNiemcyTab.Controls.Add(this.PodatekStrona);
            this.PodatekNiemcyTab.Controls.Add(this.EuEwrButton);
            this.PodatekNiemcyTab.Controls.Add(this.DrukujEstkButton);
            this.PodatekNiemcyTab.Location = new System.Drawing.Point(4, 25);
            this.PodatekNiemcyTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PodatekNiemcyTab.Name = "PodatekNiemcyTab";
            this.PodatekNiemcyTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PodatekNiemcyTab.Size = new System.Drawing.Size(1026, 49);
            this.PodatekNiemcyTab.TabIndex = 0;
            this.PodatekNiemcyTab.Text = "Podatek - Niemcy";
            this.PodatekNiemcyTab.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(605, 25);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 35);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // PodatekStrona
            // 
            this.PodatekStrona.Location = new System.Drawing.Point(321, 25);
            this.PodatekStrona.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PodatekStrona.Name = "PodatekStrona";
            this.PodatekStrona.Size = new System.Drawing.Size(141, 35);
            this.PodatekStrona.TabIndex = 2;
            this.PodatekStrona.Text = "PodatekStrona";
            this.PodatekStrona.UseVisualStyleBackColor = true;
            this.PodatekStrona.Click += new System.EventHandler(this.PodatekStrona_Click);
            // 
            // EuEwrButton
            // 
            this.EuEwrButton.Location = new System.Drawing.Point(168, 25);
            this.EuEwrButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EuEwrButton.Name = "EuEwrButton";
            this.EuEwrButton.Size = new System.Drawing.Size(112, 35);
            this.EuEwrButton.TabIndex = 1;
            this.EuEwrButton.Text = "EuEwr";
            this.EuEwrButton.UseVisualStyleBackColor = true;
            this.EuEwrButton.Click += new System.EventHandler(this.EuEwrButton_Click);
            // 
            // DrukujEstkButton
            // 
            this.DrukujEstkButton.Location = new System.Drawing.Point(21, 25);
            this.DrukujEstkButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DrukujEstkButton.Name = "DrukujEstkButton";
            this.DrukujEstkButton.Size = new System.Drawing.Size(112, 35);
            this.DrukujEstkButton.TabIndex = 0;
            this.DrukujEstkButton.Text = "Drukuj EsTK";
            this.DrukujEstkButton.UseVisualStyleBackColor = true;
            this.DrukujEstkButton.Click += new System.EventHandler(this.DrukujEstkButton_Click);
            // 
            // lblRok
            // 
            this.lblRok.AutoSize = true;
            this.lblRok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRok.Location = new System.Drawing.Point(477, 30);
            this.lblRok.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRok.Name = "lblRok";
            this.lblRok.Size = new System.Drawing.Size(36, 16);
            this.lblRok.TabIndex = 86;
            this.lblRok.Text = "Rok:";
            // 
            // JahrTextBox
            // 
            this.JahrTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JahrTextBox.Location = new System.Drawing.Point(525, 28);
            this.JahrTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.JahrTextBox.Name = "JahrTextBox";
            this.JahrTextBox.Size = new System.Drawing.Size(77, 22);
            this.JahrTextBox.TabIndex = 100;
            this.JahrTextBox.Text = "1111";
            // 
            // _ucEdycjaKlient1
            // 
            this._ucEdycjaKlient1.Binder = null;
            this._ucEdycjaKlient1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ucEdycjaKlient1.Location = new System.Drawing.Point(4, 51);
            this._ucEdycjaKlient1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._ucEdycjaKlient1.Name = "_ucEdycjaKlient1";
            this._ucEdycjaKlient1.Session = null;
            this._ucEdycjaKlient1.Size = new System.Drawing.Size(966, 428);
            this._ucEdycjaKlient1.TabIndex = 9999;
            // 
            // typyListGrpBox1
            // 
            this.typyListGrpBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typyListGrpBox1.Location = new System.Drawing.Point(752, 436);
            this.typyListGrpBox1.Name = "typyListGrpBox1";
            this.typyListGrpBox1.Selected = 0;
            this.typyListGrpBox1.Size = new System.Drawing.Size(128, 218);
            this.typyListGrpBox1.TabIndex = 9999;
            this.typyListGrpBox1.TabStop = false;
            this.typyListGrpBox1.Text = "Wybor listy";
            // 
            // ucMandatenID1
            // 
            this.ucMandatenID1.Binder = null;
            this.ucMandatenID1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucMandatenID1.Location = new System.Drawing.Point(325, 25);
            this.ucMandatenID1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucMandatenID1.Name = "ucMandatenID1";
            this.ucMandatenID1.Session = null;
            this.ucMandatenID1.Size = new System.Drawing.Size(146, 29);
            this.ucMandatenID1.TabIndex = 1111;
            // 
            // krajeDDL1
            // 
            this.krajeDDL1.DisplayMember = "Value";
            this.krajeDDL1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.krajeDDL1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.krajeDDL1.FormattingEnabled = true;
            this.krajeDDL1.Location = new System.Drawing.Point(609, 26);
            this.krajeDDL1.Name = "krajeDDL1";
            this.krajeDDL1.Size = new System.Drawing.Size(121, 24);
            this.krajeDDL1.TabIndex = 110;
            this.krajeDDL1.ValueMember = "numericKey";
            // 
            // ucNagrodaListy1
            // 
            this.ucNagrodaListy1.Binder = null;
            this.ucNagrodaListy1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucNagrodaListy1.Location = new System.Drawing.Point(138, 644);
            this.ucNagrodaListy1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucNagrodaListy1.Name = "ucNagrodaListy1";
            this.ucNagrodaListy1.Session = null;
            this.ucNagrodaListy1.Size = new System.Drawing.Size(412, 37);
            this.ucNagrodaListy1.TabIndex = 9999;
            // 
            // ucPartner1
            // 
            this.ucPartner1.Binder = null;
            this.ucPartner1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucPartner1.Location = new System.Drawing.Point(4, 480);
            this.ucPartner1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucPartner1.Name = "ucPartner1";
            this.ucPartner1.Session = null;
            this.ucPartner1.Size = new System.Drawing.Size(515, 106);
            this.ucPartner1.TabIndex = 9999;
            // 
            // poleconyDDL1
            // 
            this.poleconyDDL1.DisplayMember = "Value";
            this.poleconyDDL1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.poleconyDDL1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poleconyDDL1.FormattingEnabled = true;
            this.poleconyDDL1.Location = new System.Drawing.Point(604, 644);
            this.poleconyDDL1.Name = "poleconyDDL1";
            this.poleconyDDL1.Size = new System.Drawing.Size(121, 23);
            this.poleconyDDL1.TabIndex = 9999;
            this.poleconyDDL1.ValueMember = "numericKey";
            // 
            // FrmWprowadz
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1034, 882);
            this.Controls.Add(this.poleconyDDL1);
            this.Controls.Add(this.notkaTextBox);
            this.Controls.Add(this.ucPartner1);
            this.Controls.Add(this.ucNagrodaListy1);
            this.Controls.Add(this.krajeDDL1);
            this.Controls.Add(this.ucMandatenID1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.typyListGrpBox1);
            this.Controls.Add(this._ucEdycjaKlient1);
            this.Controls.Add(this.JahrTextBox);
            this.Controls.Add(this.lblRok);
            this.Controls.Add(this.ucWlascicielKonta1);
            this.Controls.Add(this.ucDzieci1);
            this.Controls.Add(this.ucAdres1);
            this.Controls.Add(this.ucKonto1);
            this.Controls.Add(notkaLabel);
            this.Controls.Add(this.rozliczenieBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.Name = "FrmWprowadz";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "FrmWprowadz";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.IdsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rozliczenieBindingNavigator)).EndInit();
            this.rozliczenieBindingNavigator.ResumeLayout(false);
            this.rozliczenieBindingNavigator.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.PodatekNiemcyTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator rozliczenieBindingNavigator;

        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox notkaTextBox;
        private Ctrl.ucKonto ucKonto1;
        private Ctrl.ucAdres ucAdres1;
        private Ctrl.ucDzieci ucDzieci1;
        private Ctrl.ucWlascicielKonta ucWlascicielKonta1;

        //private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage PodatekNiemcyTab;
        private System.Windows.Forms.Button DrukujEstkButton;
        private System.Windows.Forms.TextBox JahrTextBox;
        private System.Windows.Forms.Label lblRok;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button PodatekStrona;
        private System.Windows.Forms.Button EuEwrButton;
        private Ctrl.ucEdycjaKlient _ucEdycjaKlient1;
        private Commons.TypyListGrpBox typyListGrpBox1;
        private Ctrl.Klient.ucMandatenID ucMandatenID1;
        private Commons.KrajeDDL krajeDDL1;
        private Ctrl.ucPartner ucPartner1;
        private Ctrl.ucNagrodaListy ucNagrodaListy1;
        private Commons.PoleconyDDL poleconyDDL1;
        private System.Windows.Forms.ToolStripLabel lblStatus;
        

    }
}
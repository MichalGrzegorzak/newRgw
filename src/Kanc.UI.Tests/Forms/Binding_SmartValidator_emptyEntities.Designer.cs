using System.Windows.Forms;
using Kanc.Commons;
using Kanc.UI.Tests.Controls;
using NHibernate.Validator.Binding.Controls;

namespace Kanc.UI.Tests
{
    partial class Binding_SmartValidator_emptyEntities
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label isModifiedLabel;
            System.Windows.Forms.Label isTrackingLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label idLabel1;
            System.Windows.Forms.Label isModifiedLabel1;
            System.Windows.Forms.Label isTrackingLabel1;
            System.Windows.Forms.Label nameLabel1;
            System.Windows.Forms.Label urodzLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Binding_SmartValidator_emptyEntities));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.rachunek_BBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.rachunek_BBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.txtId = new System.Windows.Forms.TextBox();
            this.isModifiedCheckBox = new System.Windows.Forms.CheckBox();
            this.isTrackingCheckBox = new System.Windows.Forms.CheckBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.idTextBox1 = new System.Windows.Forms.TextBox();
            this.isModifiedCheckBox1 = new System.Windows.Forms.CheckBox();
            this.isTrackingCheckBox1 = new System.Windows.Forms.CheckBox();
            this.txtklientName = new System.Windows.Forms.TextBox();
            this.urodzDateTimePicker = new Kanc.Commons.NullableDateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            isModifiedLabel = new System.Windows.Forms.Label();
            isTrackingLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            idLabel1 = new System.Windows.Forms.Label();
            isModifiedLabel1 = new System.Windows.Forms.Label();
            isTrackingLabel1 = new System.Windows.Forms.Label();
            nameLabel1 = new System.Windows.Forms.Label();
            urodzLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rachunek_BBindingNavigator)).BeginInit();
            this.rachunek_BBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(43, 67);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // isModifiedLabel
            // 
            isModifiedLabel.AutoSize = true;
            isModifiedLabel.Location = new System.Drawing.Point(43, 95);
            isModifiedLabel.Name = "isModifiedLabel";
            isModifiedLabel.Size = new System.Drawing.Size(61, 13);
            isModifiedLabel.TabIndex = 3;
            isModifiedLabel.Text = "Is Modified:";
            // 
            // isTrackingLabel
            // 
            isTrackingLabel.AutoSize = true;
            isTrackingLabel.Location = new System.Drawing.Point(43, 125);
            isTrackingLabel.Name = "isTrackingLabel";
            isTrackingLabel.Size = new System.Drawing.Size(63, 13);
            isTrackingLabel.TabIndex = 5;
            isTrackingLabel.Text = "Is Tracking:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(43, 153);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 7;
            nameLabel.Text = "Name:";
            // 
            // idLabel1
            // 
            idLabel1.AutoSize = true;
            idLabel1.Location = new System.Drawing.Point(272, 62);
            idLabel1.Name = "idLabel1";
            idLabel1.Size = new System.Drawing.Size(19, 13);
            idLabel1.TabIndex = 9;
            idLabel1.Text = "Id:";
            // 
            // isModifiedLabel1
            // 
            isModifiedLabel1.AutoSize = true;
            isModifiedLabel1.Location = new System.Drawing.Point(272, 90);
            isModifiedLabel1.Name = "isModifiedLabel1";
            isModifiedLabel1.Size = new System.Drawing.Size(61, 13);
            isModifiedLabel1.TabIndex = 11;
            isModifiedLabel1.Text = "Is Modified:";
            // 
            // isTrackingLabel1
            // 
            isTrackingLabel1.AutoSize = true;
            isTrackingLabel1.Location = new System.Drawing.Point(272, 120);
            isTrackingLabel1.Name = "isTrackingLabel1";
            isTrackingLabel1.Size = new System.Drawing.Size(63, 13);
            isTrackingLabel1.TabIndex = 13;
            isTrackingLabel1.Text = "Is Tracking:";
            // 
            // nameLabel1
            // 
            nameLabel1.AutoSize = true;
            nameLabel1.Location = new System.Drawing.Point(272, 148);
            nameLabel1.Name = "nameLabel1";
            nameLabel1.Size = new System.Drawing.Size(38, 13);
            nameLabel1.TabIndex = 15;
            nameLabel1.Text = "Name:";
            // 
            // urodzLabel
            // 
            urodzLabel.AutoSize = true;
            urodzLabel.Location = new System.Drawing.Point(272, 175);
            urodzLabel.Name = "urodzLabel";
            urodzLabel.Size = new System.Drawing.Size(38, 13);
            urodzLabel.TabIndex = 17;
            urodzLabel.Text = "Urodz:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // rachunek_BBindingNavigator
            // 
            this.rachunek_BBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.rachunek_BBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.rachunek_BBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.rachunek_BBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.rachunek_BBindingNavigatorSaveItem});
            this.rachunek_BBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.rachunek_BBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.rachunek_BBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.rachunek_BBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.rachunek_BBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.rachunek_BBindingNavigator.Name = "rachunek_BBindingNavigator";
            this.rachunek_BBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.rachunek_BBindingNavigator.Size = new System.Drawing.Size(999, 25);
            this.rachunek_BBindingNavigator.TabIndex = 0;
            this.rachunek_BBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // rachunek_BBindingNavigatorSaveItem
            // 
            this.rachunek_BBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rachunek_BBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("rachunek_BBindingNavigatorSaveItem.Image")));
            this.rachunek_BBindingNavigatorSaveItem.Name = "rachunek_BBindingNavigatorSaveItem";
            this.rachunek_BBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.rachunek_BBindingNavigatorSaveItem.Text = "Save Data";
            this.rachunek_BBindingNavigatorSaveItem.Click += new System.EventHandler(this.rachunek_BBindingNavigatorSaveItem_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(112, 64);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(104, 20);
            this.txtId.TabIndex = 2;
            // 
            // isModifiedCheckBox
            // 
            this.isModifiedCheckBox.Location = new System.Drawing.Point(112, 90);
            this.isModifiedCheckBox.Name = "isModifiedCheckBox";
            this.isModifiedCheckBox.Size = new System.Drawing.Size(104, 24);
            this.isModifiedCheckBox.TabIndex = 4;
            this.isModifiedCheckBox.Text = "checkBox1";
            this.isModifiedCheckBox.UseVisualStyleBackColor = true;
            // 
            // isTrackingCheckBox
            // 
            this.isTrackingCheckBox.Location = new System.Drawing.Point(112, 120);
            this.isTrackingCheckBox.Name = "isTrackingCheckBox";
            this.isTrackingCheckBox.Size = new System.Drawing.Size(104, 24);
            this.isTrackingCheckBox.TabIndex = 6;
            this.isTrackingCheckBox.Text = "checkBox1";
            this.isTrackingCheckBox.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(112, 150);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(104, 20);
            this.txtName.TabIndex = 8;
            // 
            // idTextBox1
            // 
            this.idTextBox1.Location = new System.Drawing.Point(341, 59);
            this.idTextBox1.Name = "idTextBox1";
            this.idTextBox1.Size = new System.Drawing.Size(200, 20);
            this.idTextBox1.TabIndex = 10;
            // 
            // isModifiedCheckBox1
            // 
            this.isModifiedCheckBox1.Location = new System.Drawing.Point(341, 85);
            this.isModifiedCheckBox1.Name = "isModifiedCheckBox1";
            this.isModifiedCheckBox1.Size = new System.Drawing.Size(200, 24);
            this.isModifiedCheckBox1.TabIndex = 12;
            this.isModifiedCheckBox1.Text = "checkBox1";
            this.isModifiedCheckBox1.UseVisualStyleBackColor = true;
            // 
            // isTrackingCheckBox1
            // 
            this.isTrackingCheckBox1.Location = new System.Drawing.Point(341, 115);
            this.isTrackingCheckBox1.Name = "isTrackingCheckBox1";
            this.isTrackingCheckBox1.Size = new System.Drawing.Size(200, 24);
            this.isTrackingCheckBox1.TabIndex = 14;
            this.isTrackingCheckBox1.Text = "checkBox1";
            this.isTrackingCheckBox1.UseVisualStyleBackColor = true;
            // 
            // txtklientName
            // 
            this.txtklientName.Location = new System.Drawing.Point(341, 145);
            this.txtklientName.Name = "txtklientName";
            this.txtklientName.Size = new System.Drawing.Size(200, 20);
            this.txtklientName.TabIndex = 16;
            // 
            // urodzDateTimePicker
            // 
            this.urodzDateTimePicker.Location = new System.Drawing.Point(341, 171);
            this.urodzDateTimePicker.Name = "urodzDateTimePicker";
            this.urodzDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.urodzDateTimePicker.TabIndex = 18;
            this.urodzDateTimePicker.Value = new System.DateTime(2012, 7, 8, 18, 55, 14, 414);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(760, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Binding_SmartValidator_emptyEntities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 445);
            this.Controls.Add(this.button1);
            this.Controls.Add(idLabel1);
            this.Controls.Add(this.idTextBox1);
            this.Controls.Add(isModifiedLabel1);
            this.Controls.Add(this.isModifiedCheckBox1);
            this.Controls.Add(isTrackingLabel1);
            this.Controls.Add(this.isTrackingCheckBox1);
            this.Controls.Add(nameLabel1);
            this.Controls.Add(this.txtklientName);
            this.Controls.Add(urodzLabel);
            this.Controls.Add(this.urodzDateTimePicker);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.txtId);
            this.Controls.Add(isModifiedLabel);
            this.Controls.Add(this.isModifiedCheckBox);
            this.Controls.Add(isTrackingLabel);
            this.Controls.Add(this.isTrackingCheckBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.rachunek_BBindingNavigator);
            this.Name = "Binding_SmartValidator_emptyEntities";
            this.Text = "Binding_SmartValidator_emptyEntities";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rachunek_BBindingNavigator)).EndInit();
            this.rachunek_BBindingNavigator.ResumeLayout(false);
            this.rachunek_BBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox idTextBox1;
        private System.Windows.Forms.CheckBox isModifiedCheckBox1;
        private System.Windows.Forms.CheckBox isTrackingCheckBox1;
        private System.Windows.Forms.TextBox txtklientName;
        private NullableDateTimePicker urodzDateTimePicker;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.CheckBox isModifiedCheckBox;
        private System.Windows.Forms.CheckBox isTrackingCheckBox;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.BindingNavigator rachunek_BBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton rachunek_BBindingNavigatorSaveItem;
        private Button button1;
    }
}
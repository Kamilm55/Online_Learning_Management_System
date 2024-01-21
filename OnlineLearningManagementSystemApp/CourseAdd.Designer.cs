namespace OnlineLearningManagementSystemApp
{
    partial class CourseAdd
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
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseAdd));
            this.online_learning_management_system_dbDataSet = new OnlineLearningManagementSystemApp.online_learning_management_system_dbDataSet();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseTableAdapter = new OnlineLearningManagementSystemApp.online_learning_management_system_dbDataSetTableAdapters.CourseTableAdapter();
            this.tableAdapterManager = new OnlineLearningManagementSystemApp.online_learning_management_system_dbDataSetTableAdapters.TableAdapterManager();
            this.courseBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.courseBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.CourseAddSubmitBtn = new Guna.UI2.WinForms.Guna2Button();
            this.CourseAddTitleTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.courseAddMessageDialog = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.CourseAddDescTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            titleLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.online_learning_management_system_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingNavigator)).BeginInit();
            this.courseBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new System.Drawing.Font("Monospac821 BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            titleLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            titleLabel.Location = new System.Drawing.Point(231, 105);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(69, 20);
            titleLabel.TabIndex = 3;
            titleLabel.Text = "Title:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Monospac821 BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descriptionLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            descriptionLabel.Location = new System.Drawing.Point(231, 203);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(129, 20);
            descriptionLabel.TabIndex = 5;
            descriptionLabel.Text = "Description:";
            // 
            // online_learning_management_system_dbDataSet
            // 
            this.online_learning_management_system_dbDataSet.DataSetName = "online_learning_management_system_dbDataSet";
            this.online_learning_management_system_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.online_learning_management_system_dbDataSet;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Assessment_UserTableAdapter = null;
            this.tableAdapterManager.AssessmentTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CourseTableAdapter = this.courseTableAdapter;
            this.tableAdapterManager.EnrollmentTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = OnlineLearningManagementSystemApp.online_learning_management_system_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // courseBindingNavigator
            // 
            this.courseBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.courseBindingNavigator.BindingSource = this.courseBindingSource;
            this.courseBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.courseBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.courseBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.courseBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.courseBindingNavigatorSaveItem});
            this.courseBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.courseBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.courseBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.courseBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.courseBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.courseBindingNavigator.Name = "courseBindingNavigator";
            this.courseBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.courseBindingNavigator.Size = new System.Drawing.Size(761, 27);
            this.courseBindingNavigator.TabIndex = 0;
            this.courseBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // courseBindingNavigatorSaveItem
            // 
            this.courseBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.courseBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("courseBindingNavigatorSaveItem.Image")));
            this.courseBindingNavigatorSaveItem.Name = "courseBindingNavigatorSaveItem";
            this.courseBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.courseBindingNavigatorSaveItem.Text = "Save Data";
            this.courseBindingNavigatorSaveItem.Click += new System.EventHandler(this.courseBindingNavigatorSaveItem_Click);
            // 
            // CourseAddSubmitBtn
            // 
            this.CourseAddSubmitBtn.AutoRoundedCorners = true;
            this.CourseAddSubmitBtn.BorderRadius = 21;
            this.CourseAddSubmitBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CourseAddSubmitBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CourseAddSubmitBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CourseAddSubmitBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CourseAddSubmitBtn.FillColor = System.Drawing.Color.Green;
            this.CourseAddSubmitBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CourseAddSubmitBtn.ForeColor = System.Drawing.Color.White;
            this.CourseAddSubmitBtn.Location = new System.Drawing.Point(235, 309);
            this.CourseAddSubmitBtn.Name = "CourseAddSubmitBtn";
            this.CourseAddSubmitBtn.Size = new System.Drawing.Size(244, 45);
            this.CourseAddSubmitBtn.TabIndex = 46;
            this.CourseAddSubmitBtn.Text = "Submit";
            this.CourseAddSubmitBtn.Click += new System.EventHandler(this.CourseAddSubmitBtn_Click);
            // 
            // CourseAddTitleTextBox
            // 
            this.CourseAddTitleTextBox.BackColor = System.Drawing.Color.Transparent;
            this.CourseAddTitleTextBox.BorderColor = System.Drawing.Color.DarkGray;
            this.CourseAddTitleTextBox.BorderRadius = 6;
            this.CourseAddTitleTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CourseAddTitleTextBox.DefaultText = "";
            this.CourseAddTitleTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CourseAddTitleTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CourseAddTitleTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CourseAddTitleTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CourseAddTitleTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CourseAddTitleTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.CourseAddTitleTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CourseAddTitleTextBox.Location = new System.Drawing.Point(223, 138);
            this.CourseAddTitleTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CourseAddTitleTextBox.Name = "CourseAddTitleTextBox";
            this.CourseAddTitleTextBox.PasswordChar = '\0';
            this.CourseAddTitleTextBox.PlaceholderText = "Enter course title";
            this.CourseAddTitleTextBox.SelectedText = "";
            this.CourseAddTitleTextBox.Size = new System.Drawing.Size(287, 53);
            this.CourseAddTitleTextBox.TabIndex = 54;
            // 
            // courseAddMessageDialog
            // 
            this.courseAddMessageDialog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.courseAddMessageDialog.Caption = null;
            this.courseAddMessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            this.courseAddMessageDialog.Parent = this;
            this.courseAddMessageDialog.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.courseAddMessageDialog.Text = null;
            // 
            // CourseAddDescTextBox
            // 
            this.CourseAddDescTextBox.BackColor = System.Drawing.Color.Transparent;
            this.CourseAddDescTextBox.BorderColor = System.Drawing.Color.DarkGray;
            this.CourseAddDescTextBox.BorderRadius = 6;
            this.CourseAddDescTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CourseAddDescTextBox.DefaultText = "";
            this.CourseAddDescTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CourseAddDescTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CourseAddDescTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CourseAddDescTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CourseAddDescTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CourseAddDescTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.CourseAddDescTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CourseAddDescTextBox.Location = new System.Drawing.Point(223, 238);
            this.CourseAddDescTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CourseAddDescTextBox.Name = "CourseAddDescTextBox";
            this.CourseAddDescTextBox.PasswordChar = '\0';
            this.CourseAddDescTextBox.PlaceholderText = "Enter course description";
            this.CourseAddDescTextBox.SelectedText = "";
            this.CourseAddDescTextBox.Size = new System.Drawing.Size(287, 53);
            this.CourseAddDescTextBox.TabIndex = 65;
            // 
            // CourseAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(97)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(761, 464);
            this.Controls.Add(this.CourseAddDescTextBox);
            this.Controls.Add(this.CourseAddTitleTextBox);
            this.Controls.Add(this.CourseAddSubmitBtn);
            this.Controls.Add(titleLabel);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.courseBindingNavigator);
            this.Name = "CourseAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CoursesCRUD";
            this.Load += new System.EventHandler(this.CoursesCRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.online_learning_management_system_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingNavigator)).EndInit();
            this.courseBindingNavigator.ResumeLayout(false);
            this.courseBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private online_learning_management_system_dbDataSet online_learning_management_system_dbDataSet;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private online_learning_management_system_dbDataSetTableAdapters.CourseTableAdapter courseTableAdapter;
        private online_learning_management_system_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator courseBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton courseBindingNavigatorSaveItem;
        private Guna.UI2.WinForms.Guna2Button CourseAddSubmitBtn;
        private Guna.UI2.WinForms.Guna2TextBox CourseAddTitleTextBox;
        private Guna.UI2.WinForms.Guna2MessageDialog courseAddMessageDialog;
        private Guna.UI2.WinForms.Guna2TextBox CourseAddDescTextBox;
    }
}
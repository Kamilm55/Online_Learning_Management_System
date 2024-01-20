namespace OnlineLearningManagementSystemApp
{
    partial class AssesmentCRUD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssesmentCRUD));
            System.Windows.Forms.Label assessmentIDLabel;
            System.Windows.Forms.Label courseIDLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label dueDateLabel;
            System.Windows.Forms.Label userIDLabel;
            System.Windows.Forms.Label gradeLabel;
            this.online_learning_management_system_dbDataSet = new OnlineLearningManagementSystemApp.online_learning_management_system_dbDataSet();
            this.assessmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assessmentTableAdapter = new OnlineLearningManagementSystemApp.online_learning_management_system_dbDataSetTableAdapters.AssessmentTableAdapter();
            this.tableAdapterManager = new OnlineLearningManagementSystemApp.online_learning_management_system_dbDataSetTableAdapters.TableAdapterManager();
            this.assessmentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.assessmentBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.assessmentIDTextBox = new System.Windows.Forms.TextBox();
            this.courseIDTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.dueDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.assessment_UserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assessment_UserTableAdapter = new OnlineLearningManagementSystemApp.online_learning_management_system_dbDataSetTableAdapters.Assessment_UserTableAdapter();
            this.userIDTextBox = new System.Windows.Forms.TextBox();
            this.gradeTextBox = new System.Windows.Forms.TextBox();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            assessmentIDLabel = new System.Windows.Forms.Label();
            courseIDLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            dueDateLabel = new System.Windows.Forms.Label();
            userIDLabel = new System.Windows.Forms.Label();
            gradeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.online_learning_management_system_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentBindingNavigator)).BeginInit();
            this.assessmentBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assessment_UserBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // online_learning_management_system_dbDataSet
            // 
            this.online_learning_management_system_dbDataSet.DataSetName = "online_learning_management_system_dbDataSet";
            this.online_learning_management_system_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assessmentBindingSource
            // 
            this.assessmentBindingSource.DataMember = "Assessment";
            this.assessmentBindingSource.DataSource = this.online_learning_management_system_dbDataSet;
            // 
            // assessmentTableAdapter
            // 
            this.assessmentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Assessment_UserTableAdapter = this.assessment_UserTableAdapter;
            this.tableAdapterManager.AssessmentTableAdapter = this.assessmentTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CourseTableAdapter = null;
            this.tableAdapterManager.EnrollmentTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = OnlineLearningManagementSystemApp.online_learning_management_system_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // assessmentBindingNavigator
            // 
            this.assessmentBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.assessmentBindingNavigator.BindingSource = this.assessmentBindingSource;
            this.assessmentBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.assessmentBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.assessmentBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.assessmentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.assessmentBindingNavigatorSaveItem});
            this.assessmentBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.assessmentBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.assessmentBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.assessmentBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.assessmentBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.assessmentBindingNavigator.Name = "assessmentBindingNavigator";
            this.assessmentBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.assessmentBindingNavigator.Size = new System.Drawing.Size(1033, 31);
            this.assessmentBindingNavigator.TabIndex = 0;
            this.assessmentBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 20);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
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
            // assessmentBindingNavigatorSaveItem
            // 
            this.assessmentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.assessmentBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("assessmentBindingNavigatorSaveItem.Image")));
            this.assessmentBindingNavigatorSaveItem.Name = "assessmentBindingNavigatorSaveItem";
            this.assessmentBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.assessmentBindingNavigatorSaveItem.Text = "Save Data";
            this.assessmentBindingNavigatorSaveItem.Click += new System.EventHandler(this.assessmentBindingNavigatorSaveItem_Click);
            // 
            // assessmentIDLabel
            // 
            assessmentIDLabel.AutoSize = true;
            assessmentIDLabel.Location = new System.Drawing.Point(176, 156);
            assessmentIDLabel.Name = "assessmentIDLabel";
            assessmentIDLabel.Size = new System.Drawing.Size(100, 16);
            assessmentIDLabel.TabIndex = 1;
            assessmentIDLabel.Text = "Assessment ID:";
            // 
            // assessmentIDTextBox
            // 
            this.assessmentIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assessmentBindingSource, "AssessmentID", true));
            this.assessmentIDTextBox.Location = new System.Drawing.Point(282, 153);
            this.assessmentIDTextBox.Name = "assessmentIDTextBox";
            this.assessmentIDTextBox.Size = new System.Drawing.Size(200, 22);
            this.assessmentIDTextBox.TabIndex = 2;
            // 
            // courseIDLabel
            // 
            courseIDLabel.AutoSize = true;
            courseIDLabel.Location = new System.Drawing.Point(176, 184);
            courseIDLabel.Name = "courseIDLabel";
            courseIDLabel.Size = new System.Drawing.Size(69, 16);
            courseIDLabel.TabIndex = 3;
            courseIDLabel.Text = "Course ID:";
            // 
            // courseIDTextBox
            // 
            this.courseIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assessmentBindingSource, "CourseID", true));
            this.courseIDTextBox.Location = new System.Drawing.Point(282, 181);
            this.courseIDTextBox.Name = "courseIDTextBox";
            this.courseIDTextBox.Size = new System.Drawing.Size(200, 22);
            this.courseIDTextBox.TabIndex = 4;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(176, 212);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(36, 16);
            titleLabel.TabIndex = 5;
            titleLabel.Text = "Title:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assessmentBindingSource, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(282, 209);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(200, 22);
            this.titleTextBox.TabIndex = 6;
            // 
            // dueDateLabel
            // 
            dueDateLabel.AutoSize = true;
            dueDateLabel.Location = new System.Drawing.Point(176, 241);
            dueDateLabel.Name = "dueDateLabel";
            dueDateLabel.Size = new System.Drawing.Size(67, 16);
            dueDateLabel.TabIndex = 7;
            dueDateLabel.Text = "Due Date:";
            // 
            // dueDateDateTimePicker
            // 
            this.dueDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.assessmentBindingSource, "DueDate", true));
            this.dueDateDateTimePicker.Location = new System.Drawing.Point(282, 237);
            this.dueDateDateTimePicker.Name = "dueDateDateTimePicker";
            this.dueDateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dueDateDateTimePicker.TabIndex = 8;
            // 
            // assessment_UserBindingSource
            // 
            this.assessment_UserBindingSource.DataMember = "Assessment_User";
            this.assessment_UserBindingSource.DataSource = this.online_learning_management_system_dbDataSet;
            // 
            // assessment_UserTableAdapter
            // 
            this.assessment_UserTableAdapter.ClearBeforeFill = true;
            // 
            // userIDLabel
            // 
            userIDLabel.AutoSize = true;
            userIDLabel.Location = new System.Drawing.Point(176, 278);
            userIDLabel.Name = "userIDLabel";
            userIDLabel.Size = new System.Drawing.Size(55, 16);
            userIDLabel.TabIndex = 11;
            userIDLabel.Text = "User ID:";
            // 
            // userIDTextBox
            // 
            this.userIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assessment_UserBindingSource, "UserID", true));
            this.userIDTextBox.Location = new System.Drawing.Point(314, 275);
            this.userIDTextBox.Name = "userIDTextBox";
            this.userIDTextBox.Size = new System.Drawing.Size(100, 22);
            this.userIDTextBox.TabIndex = 12;
            // 
            // gradeLabel
            // 
            gradeLabel.AutoSize = true;
            gradeLabel.Location = new System.Drawing.Point(176, 319);
            gradeLabel.Name = "gradeLabel";
            gradeLabel.Size = new System.Drawing.Size(48, 16);
            gradeLabel.TabIndex = 15;
            gradeLabel.Text = "Grade:";
            // 
            // gradeTextBox
            // 
            this.gradeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assessment_UserBindingSource, "Grade", true));
            this.gradeTextBox.Location = new System.Drawing.Point(314, 316);
            this.gradeTextBox.Name = "gradeTextBox";
            this.gradeTextBox.Size = new System.Drawing.Size(100, 22);
            this.gradeTextBox.TabIndex = 16;
            // 
            // guna2Button2
            // 
            this.guna2Button2.AutoRoundedCorners = true;
            this.guna2Button2.BorderRadius = 21;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Green;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(195, 374);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(244, 45);
            this.guna2Button2.TabIndex = 47;
            this.guna2Button2.Text = "Submit";
            // 
            // AssesmentCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 667);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(userIDLabel);
            this.Controls.Add(this.userIDTextBox);
            this.Controls.Add(gradeLabel);
            this.Controls.Add(this.gradeTextBox);
            this.Controls.Add(assessmentIDLabel);
            this.Controls.Add(this.assessmentIDTextBox);
            this.Controls.Add(courseIDLabel);
            this.Controls.Add(this.courseIDTextBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(dueDateLabel);
            this.Controls.Add(this.dueDateDateTimePicker);
            this.Controls.Add(this.assessmentBindingNavigator);
            this.Name = "AssesmentCRUD";
            this.Text = "AssesmentCRUD";
            this.Load += new System.EventHandler(this.AssesmentCRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.online_learning_management_system_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentBindingNavigator)).EndInit();
            this.assessmentBindingNavigator.ResumeLayout(false);
            this.assessmentBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assessment_UserBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private online_learning_management_system_dbDataSet online_learning_management_system_dbDataSet;
        private System.Windows.Forms.BindingSource assessmentBindingSource;
        private online_learning_management_system_dbDataSetTableAdapters.AssessmentTableAdapter assessmentTableAdapter;
        private online_learning_management_system_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator assessmentBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton assessmentBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox assessmentIDTextBox;
        private System.Windows.Forms.TextBox courseIDTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.DateTimePicker dueDateDateTimePicker;
        private online_learning_management_system_dbDataSetTableAdapters.Assessment_UserTableAdapter assessment_UserTableAdapter;
        private System.Windows.Forms.BindingSource assessment_UserBindingSource;
        private System.Windows.Forms.TextBox userIDTextBox;
        private System.Windows.Forms.TextBox gradeTextBox;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}
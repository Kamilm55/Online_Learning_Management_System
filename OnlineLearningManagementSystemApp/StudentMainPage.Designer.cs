namespace OnlineLearningManagementSystemApp
{
    partial class StudentMainPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.studentSearchTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.SearchlabelMain = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.studentEnrollCourseTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.studentEnrollCourseButton = new Guna.UI2.WinForms.Guna2Button();
            this.studentDataComboBox = new System.Windows.Forms.ComboBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.courseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.online_learning_management_system_dbDataSet = new OnlineLearningManagementSystemApp.online_learning_management_system_dbDataSet();
            this.courseTableAdapter = new OnlineLearningManagementSystemApp.online_learning_management_system_dbDataSetTableAdapters.CourseTableAdapter();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.studentUnenrollCourseButton = new Guna.UI2.WinForms.Guna2Button();
            this.studentUnenrollCourseTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.assesmentPageLink = new Guna.UI2.WinForms.Guna2Button();
            this.userProfileLink = new Guna.UI2.WinForms.Guna2Button();
            this.logoutBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.online_learning_management_system_dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // studentSearchTextBox
            // 
            this.studentSearchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.studentSearchTextBox.DefaultText = "";
            this.studentSearchTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.studentSearchTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.studentSearchTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.studentSearchTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.studentSearchTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.studentSearchTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.studentSearchTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.studentSearchTextBox.Location = new System.Drawing.Point(105, 115);
            this.studentSearchTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.studentSearchTextBox.Name = "studentSearchTextBox";
            this.studentSearchTextBox.PasswordChar = '\0';
            this.studentSearchTextBox.PlaceholderText = "";
            this.studentSearchTextBox.SelectedText = "";
            this.studentSearchTextBox.Size = new System.Drawing.Size(245, 36);
            this.studentSearchTextBox.TabIndex = 2;
            this.studentSearchTextBox.TextChanged += new System.EventHandler(this.studentSearchTextBox_TextChanged);
            // 
            // SearchlabelMain
            // 
            this.SearchlabelMain.BackColor = System.Drawing.Color.Transparent;
            this.SearchlabelMain.Location = new System.Drawing.Point(53, 124);
            this.SearchlabelMain.Name = "SearchlabelMain";
            this.SearchlabelMain.Size = new System.Drawing.Size(46, 18);
            this.SearchlabelMain.TabIndex = 3;
            this.SearchlabelMain.Text = "Search";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(49, 173);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(83, 18);
            this.guna2HtmlLabel2.TabIndex = 4;
            this.guna2HtmlLabel2.Text = "Enroll Course";
            // 
            // studentEnrollCourseTextBox
            // 
            this.studentEnrollCourseTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.studentEnrollCourseTextBox.DefaultText = "";
            this.studentEnrollCourseTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.studentEnrollCourseTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.studentEnrollCourseTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.studentEnrollCourseTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.studentEnrollCourseTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.studentEnrollCourseTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.studentEnrollCourseTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.studentEnrollCourseTextBox.Location = new System.Drawing.Point(35, 198);
            this.studentEnrollCourseTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.studentEnrollCourseTextBox.Name = "studentEnrollCourseTextBox";
            this.studentEnrollCourseTextBox.PasswordChar = '\0';
            this.studentEnrollCourseTextBox.PlaceholderText = "Enter course id";
            this.studentEnrollCourseTextBox.SelectedText = "";
            this.studentEnrollCourseTextBox.Size = new System.Drawing.Size(229, 48);
            this.studentEnrollCourseTextBox.TabIndex = 5;
            // 
            // studentEnrollCourseButton
            // 
            this.studentEnrollCourseButton.AutoRoundedCorners = true;
            this.studentEnrollCourseButton.BorderRadius = 21;
            this.studentEnrollCourseButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.studentEnrollCourseButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.studentEnrollCourseButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.studentEnrollCourseButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.studentEnrollCourseButton.FillColor = System.Drawing.Color.Green;
            this.studentEnrollCourseButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.studentEnrollCourseButton.ForeColor = System.Drawing.Color.White;
            this.studentEnrollCourseButton.Location = new System.Drawing.Point(285, 201);
            this.studentEnrollCourseButton.Name = "studentEnrollCourseButton";
            this.studentEnrollCourseButton.Size = new System.Drawing.Size(180, 45);
            this.studentEnrollCourseButton.TabIndex = 6;
            this.studentEnrollCourseButton.Text = "guna2Button1";
            this.studentEnrollCourseButton.Click += new System.EventHandler(this.studentEnrollCourseButton_Click);
            // 
            // studentDataComboBox
            // 
            this.studentDataComboBox.DisplayMember = "All Courses";
            this.studentDataComboBox.FormattingEnabled = true;
            this.studentDataComboBox.Items.AddRange(new object[] {
            "All Courses",
            "Enrolled Courses"});
            this.studentDataComboBox.Location = new System.Drawing.Point(105, 67);
            this.studentDataComboBox.Name = "studentDataComboBox";
            this.studentDataComboBox.Size = new System.Drawing.Size(236, 24);
            this.studentDataComboBox.TabIndex = 7;
            this.studentDataComboBox.SelectedIndexChanged += new System.EventHandler(this.studentDataComboBox_SelectedIndexChanged);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(521, 12);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(84, 18);
            this.guna2HtmlLabel4.TabIndex = 9;
            this.guna2HtmlLabel4.Text = "Student Page";
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.AutoGenerateColumns = false;
            this.guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 35;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseIDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.instructorIDDataGridViewTextBoxColumn});
            this.guna2DataGridView1.DataSource = this.courseBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(504, 89);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 51;
            this.guna2DataGridView1.RowTemplate.Height = 24;
            this.guna2DataGridView1.Size = new System.Drawing.Size(582, 333);
            this.guna2DataGridView1.TabIndex = 12;
            this.guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightBlue;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 35;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // courseIDDataGridViewTextBoxColumn
            // 
            this.courseIDDataGridViewTextBoxColumn.DataPropertyName = "CourseID";
            this.courseIDDataGridViewTextBoxColumn.HeaderText = "CourseID";
            this.courseIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.courseIDDataGridViewTextBoxColumn.Name = "courseIDDataGridViewTextBoxColumn";
            this.courseIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // instructorIDDataGridViewTextBoxColumn
            // 
            this.instructorIDDataGridViewTextBoxColumn.DataPropertyName = "InstructorID";
            this.instructorIDDataGridViewTextBoxColumn.HeaderText = "InstructorID";
            this.instructorIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.instructorIDDataGridViewTextBoxColumn.Name = "instructorIDDataGridViewTextBoxColumn";
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.online_learning_management_system_dbDataSet;
            // 
            // online_learning_management_system_dbDataSet
            // 
            this.online_learning_management_system_dbDataSet.DataSetName = "online_learning_management_system_dbDataSet";
            this.online_learning_management_system_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(111, 43);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(85, 18);
            this.guna2HtmlLabel1.TabIndex = 13;
            this.guna2HtmlLabel1.Text = "Choose Data:";
            // 
            // studentUnenrollCourseButton
            // 
            this.studentUnenrollCourseButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.studentUnenrollCourseButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.studentUnenrollCourseButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.studentUnenrollCourseButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.studentUnenrollCourseButton.FillColor = System.Drawing.Color.Green;
            this.studentUnenrollCourseButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.studentUnenrollCourseButton.ForeColor = System.Drawing.Color.White;
            this.studentUnenrollCourseButton.Location = new System.Drawing.Point(285, 293);
            this.studentUnenrollCourseButton.Name = "studentUnenrollCourseButton";
            this.studentUnenrollCourseButton.Size = new System.Drawing.Size(180, 45);
            this.studentUnenrollCourseButton.TabIndex = 16;
            this.studentUnenrollCourseButton.Text = "guna2Button3";
            this.studentUnenrollCourseButton.Click += new System.EventHandler(this.studentUnenrollCourseButton_Click);
            // 
            // studentUnenrollCourseTextBox
            // 
            this.studentUnenrollCourseTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.studentUnenrollCourseTextBox.DefaultText = "";
            this.studentUnenrollCourseTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.studentUnenrollCourseTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.studentUnenrollCourseTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.studentUnenrollCourseTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.studentUnenrollCourseTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.studentUnenrollCourseTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.studentUnenrollCourseTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.studentUnenrollCourseTextBox.Location = new System.Drawing.Point(35, 290);
            this.studentUnenrollCourseTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.studentUnenrollCourseTextBox.Name = "studentUnenrollCourseTextBox";
            this.studentUnenrollCourseTextBox.PasswordChar = '\0';
            this.studentUnenrollCourseTextBox.PlaceholderText = "Enter course id";
            this.studentUnenrollCourseTextBox.SelectedText = "";
            this.studentUnenrollCourseTextBox.Size = new System.Drawing.Size(229, 48);
            this.studentUnenrollCourseTextBox.TabIndex = 15;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(49, 265);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(99, 18);
            this.guna2HtmlLabel3.TabIndex = 14;
            this.guna2HtmlLabel3.Text = "Unenroll Course";
            // 
            // assesmentPageLink
            // 
            this.assesmentPageLink.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.assesmentPageLink.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.assesmentPageLink.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.assesmentPageLink.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.assesmentPageLink.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.assesmentPageLink.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.assesmentPageLink.ForeColor = System.Drawing.Color.White;
            this.assesmentPageLink.Location = new System.Drawing.Point(49, 451);
            this.assesmentPageLink.Name = "assesmentPageLink";
            this.assesmentPageLink.Size = new System.Drawing.Size(180, 45);
            this.assesmentPageLink.TabIndex = 17;
            this.assesmentPageLink.Text = "Go to My Assesments";
            // 
            // userProfileLink
            // 
            this.userProfileLink.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.userProfileLink.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.userProfileLink.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.userProfileLink.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.userProfileLink.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.userProfileLink.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.userProfileLink.ForeColor = System.Drawing.Color.White;
            this.userProfileLink.Location = new System.Drawing.Point(49, 520);
            this.userProfileLink.Name = "userProfileLink";
            this.userProfileLink.Size = new System.Drawing.Size(180, 45);
            this.userProfileLink.TabIndex = 18;
            this.userProfileLink.Text = "Go to User Profile";
            // 
            // logoutBtn
            // 
            this.logoutBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.logoutBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.logoutBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.logoutBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.logoutBtn.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.logoutBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.logoutBtn.ForeColor = System.Drawing.Color.White;
            this.logoutBtn.Location = new System.Drawing.Point(49, 583);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(180, 45);
            this.logoutBtn.TabIndex = 19;
            this.logoutBtn.Text = "Logout";
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(49, 390);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 20;
            this.guna2Button1.Text = "Main Page";
            // 
            // StudentMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 683);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.userProfileLink);
            this.Controls.Add(this.assesmentPageLink);
            this.Controls.Add(this.studentUnenrollCourseButton);
            this.Controls.Add(this.studentUnenrollCourseTextBox);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.studentDataComboBox);
            this.Controls.Add(this.studentEnrollCourseButton);
            this.Controls.Add(this.studentEnrollCourseTextBox);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.SearchlabelMain);
            this.Controls.Add(this.studentSearchTextBox);
            this.Name = "StudentMainPage";
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.online_learning_management_system_dbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox studentSearchTextBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel SearchlabelMain;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox studentEnrollCourseTextBox;
        private Guna.UI2.WinForms.Guna2Button studentEnrollCourseButton;
        private System.Windows.Forms.ComboBox studentDataComboBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private online_learning_management_system_dbDataSet online_learning_management_system_dbDataSet;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private online_learning_management_system_dbDataSetTableAdapters.CourseTableAdapter courseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIDDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn instructorIDDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2Button studentUnenrollCourseButton;
        private Guna.UI2.WinForms.Guna2TextBox studentUnenrollCourseTextBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2Button assesmentPageLink;
        private Guna.UI2.WinForms.Guna2Button userProfileLink;
        private Guna.UI2.WinForms.Guna2Button logoutBtn;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
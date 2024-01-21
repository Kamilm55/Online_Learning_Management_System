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
            this.SearchlabelMain = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.studentEnrollCourseButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.courseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.online_learning_management_system_dbDataSet = new OnlineLearningManagementSystemApp.online_learning_management_system_dbDataSet();
            this.courseTableAdapter = new OnlineLearningManagementSystemApp.online_learning_management_system_dbDataSetTableAdapters.CourseTableAdapter();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.StMainPageMessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.assesmentPageLink = new Guna.UI2.WinForms.Guna2Button();
            this.userProfileLink = new Guna.UI2.WinForms.Guna2Button();
            this.logoutBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.studentDataComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CourseSearchTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.studentEnrollCourseTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.studentUnenrollCourseTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.studentUnenrollCourseButton = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.online_learning_management_system_dbDataSet)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchlabelMain
            // 
            this.SearchlabelMain.BackColor = System.Drawing.Color.Transparent;
            this.SearchlabelMain.Location = new System.Drawing.Point(345, 181);
            this.SearchlabelMain.Name = "SearchlabelMain";
            this.SearchlabelMain.Size = new System.Drawing.Size(3, 2);
            this.SearchlabelMain.TabIndex = 3;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(622, 100);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(3, 2);
            this.guna2HtmlLabel2.TabIndex = 4;
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
            this.studentEnrollCourseButton.Location = new System.Drawing.Point(876, 128);
            this.studentEnrollCourseButton.Name = "studentEnrollCourseButton";
            this.studentEnrollCourseButton.Size = new System.Drawing.Size(134, 45);
            this.studentEnrollCourseButton.TabIndex = 6;
            this.studentEnrollCourseButton.Text = "Enroll";
            this.studentEnrollCourseButton.Click += new System.EventHandler(this.studentEnrollCourseButton_Click);
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.AutoGenerateColumns = false;
            this.guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(317, 320);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 51;
            this.guna2DataGridView1.RowTemplate.Height = 30;
            this.guna2DataGridView1.Size = new System.Drawing.Size(751, 333);
            this.guna2DataGridView1.TabIndex = 12;
            this.guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 35;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 30;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
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
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Enabled = false;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.guna2Button1.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(0, 192);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(267, 58);
            this.guna2Button1.TabIndex = 20;
            this.guna2Button1.Text = "Main Page";
            // 
            // StMainPageMessageDialog1
            // 
            this.StMainPageMessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.StMainPageMessageDialog1.Caption = null;
            this.StMainPageMessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            this.StMainPageMessageDialog1.Parent = this;
            this.StMainPageMessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.StMainPageMessageDialog1.Text = null;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(19)))), ((int)(((byte)(28)))));
            this.guna2Panel1.Controls.Add(this.logoutBtn);
            this.guna2Panel1.Controls.Add(this.userProfileLink);
            this.guna2Panel1.Controls.Add(this.assesmentPageLink);
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.Location = new System.Drawing.Point(2, 1);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(267, 670);
            this.guna2Panel1.TabIndex = 21;
            // 
            // assesmentPageLink
            // 
            this.assesmentPageLink.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.assesmentPageLink.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.assesmentPageLink.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.assesmentPageLink.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.assesmentPageLink.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.assesmentPageLink.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.assesmentPageLink.ForeColor = System.Drawing.Color.White;
            this.assesmentPageLink.Location = new System.Drawing.Point(0, 256);
            this.assesmentPageLink.Name = "assesmentPageLink";
            this.assesmentPageLink.Size = new System.Drawing.Size(267, 58);
            this.assesmentPageLink.TabIndex = 21;
            this.assesmentPageLink.Text = "Assessments";
            this.assesmentPageLink.Click += new System.EventHandler(this.assesmentPageLink_Click);
            // 
            // userProfileLink
            // 
            this.userProfileLink.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.userProfileLink.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.userProfileLink.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.userProfileLink.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.userProfileLink.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.userProfileLink.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.userProfileLink.ForeColor = System.Drawing.Color.White;
            this.userProfileLink.Location = new System.Drawing.Point(3, 319);
            this.userProfileLink.Name = "userProfileLink";
            this.userProfileLink.Size = new System.Drawing.Size(267, 58);
            this.userProfileLink.TabIndex = 22;
            this.userProfileLink.Text = "Profile";
            this.userProfileLink.Click += new System.EventHandler(this.userProfileLink_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.logoutBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.logoutBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.logoutBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.logoutBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.logoutBtn.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.logoutBtn.ForeColor = System.Drawing.Color.White;
            this.logoutBtn.Location = new System.Drawing.Point(0, 382);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(267, 58);
            this.logoutBtn.TabIndex = 23;
            this.logoutBtn.Text = "Log out";
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Monospac821 BT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(528, 25);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(195, 34);
            this.guna2HtmlLabel5.TabIndex = 28;
            this.guna2HtmlLabel5.Text = "Student Page";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(330, 92);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(147, 26);
            this.guna2HtmlLabel4.TabIndex = 40;
            this.guna2HtmlLabel4.Text = "Choose Data:";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(330, 190);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(75, 26);
            this.guna2HtmlLabel1.TabIndex = 41;
            this.guna2HtmlLabel1.Text = "Search";
            // 
            // studentDataComboBox
            // 
            this.studentDataComboBox.AutoRoundedCorners = true;
            this.studentDataComboBox.BackColor = System.Drawing.Color.Transparent;
            this.studentDataComboBox.BorderRadius = 17;
            this.studentDataComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.studentDataComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.studentDataComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.studentDataComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.studentDataComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.studentDataComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.studentDataComboBox.ItemHeight = 30;
            this.studentDataComboBox.Items.AddRange(new object[] {
            "All Courses",
            "Enrolled Courses"});
            this.studentDataComboBox.Location = new System.Drawing.Point(319, 128);
            this.studentDataComboBox.Name = "studentDataComboBox";
            this.studentDataComboBox.Size = new System.Drawing.Size(235, 36);
            this.studentDataComboBox.TabIndex = 42;
            this.studentDataComboBox.SelectedIndexChanged += new System.EventHandler(this.studentDataComboBox_SelectedIndexChanged);
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(622, 92);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(159, 26);
            this.guna2HtmlLabel6.TabIndex = 43;
            this.guna2HtmlLabel6.Text = "Enroll Course";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(622, 190);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(183, 26);
            this.guna2HtmlLabel3.TabIndex = 44;
            this.guna2HtmlLabel3.Text = "Unenroll Course";
            // 
            // CourseSearchTextBox
            // 
            this.CourseSearchTextBox.BackColor = System.Drawing.Color.Transparent;
            this.CourseSearchTextBox.BorderColor = System.Drawing.Color.DarkGray;
            this.CourseSearchTextBox.BorderRadius = 6;
            this.CourseSearchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CourseSearchTextBox.DefaultText = "";
            this.CourseSearchTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CourseSearchTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CourseSearchTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CourseSearchTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CourseSearchTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CourseSearchTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.CourseSearchTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CourseSearchTextBox.Location = new System.Drawing.Point(319, 231);
            this.CourseSearchTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CourseSearchTextBox.Name = "CourseSearchTextBox";
            this.CourseSearchTextBox.PasswordChar = '\0';
            this.CourseSearchTextBox.PlaceholderText = "Write text to search";
            this.CourseSearchTextBox.SelectedText = "";
            this.CourseSearchTextBox.Size = new System.Drawing.Size(235, 45);
            this.CourseSearchTextBox.TabIndex = 45;
            this.CourseSearchTextBox.TextChanged += new System.EventHandler(this.CourseSearchTextBox_TextChanged);
            // 
            // studentEnrollCourseTextBox
            // 
            this.studentEnrollCourseTextBox.BackColor = System.Drawing.Color.Transparent;
            this.studentEnrollCourseTextBox.BorderColor = System.Drawing.Color.DarkGray;
            this.studentEnrollCourseTextBox.BorderRadius = 6;
            this.studentEnrollCourseTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.studentEnrollCourseTextBox.DefaultText = "";
            this.studentEnrollCourseTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.studentEnrollCourseTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.studentEnrollCourseTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.studentEnrollCourseTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.studentEnrollCourseTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.studentEnrollCourseTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.studentEnrollCourseTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.studentEnrollCourseTextBox.Location = new System.Drawing.Point(608, 125);
            this.studentEnrollCourseTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.studentEnrollCourseTextBox.Name = "studentEnrollCourseTextBox";
            this.studentEnrollCourseTextBox.PasswordChar = '\0';
            this.studentEnrollCourseTextBox.PlaceholderText = "Enter course id";
            this.studentEnrollCourseTextBox.SelectedText = "";
            this.studentEnrollCourseTextBox.Size = new System.Drawing.Size(235, 45);
            this.studentEnrollCourseTextBox.TabIndex = 46;
            // 
            // studentUnenrollCourseTextBox
            // 
            this.studentUnenrollCourseTextBox.BackColor = System.Drawing.Color.Transparent;
            this.studentUnenrollCourseTextBox.BorderColor = System.Drawing.Color.DarkGray;
            this.studentUnenrollCourseTextBox.BorderRadius = 6;
            this.studentUnenrollCourseTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.studentUnenrollCourseTextBox.DefaultText = "";
            this.studentUnenrollCourseTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.studentUnenrollCourseTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.studentUnenrollCourseTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.studentUnenrollCourseTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.studentUnenrollCourseTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.studentUnenrollCourseTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.studentUnenrollCourseTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.studentUnenrollCourseTextBox.Location = new System.Drawing.Point(608, 231);
            this.studentUnenrollCourseTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.studentUnenrollCourseTextBox.Name = "studentUnenrollCourseTextBox";
            this.studentUnenrollCourseTextBox.PasswordChar = '\0';
            this.studentUnenrollCourseTextBox.PlaceholderText = "Enter course id";
            this.studentUnenrollCourseTextBox.SelectedText = "";
            this.studentUnenrollCourseTextBox.Size = new System.Drawing.Size(235, 45);
            this.studentUnenrollCourseTextBox.TabIndex = 47;
            // 
            // studentUnenrollCourseButton
            // 
            this.studentUnenrollCourseButton.AutoRoundedCorners = true;
            this.studentUnenrollCourseButton.BorderRadius = 21;
            this.studentUnenrollCourseButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.studentUnenrollCourseButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.studentUnenrollCourseButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.studentUnenrollCourseButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.studentUnenrollCourseButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(38)))), ((int)(((byte)(55)))));
            this.studentUnenrollCourseButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.studentUnenrollCourseButton.ForeColor = System.Drawing.Color.White;
            this.studentUnenrollCourseButton.Location = new System.Drawing.Point(876, 231);
            this.studentUnenrollCourseButton.Name = "studentUnenrollCourseButton";
            this.studentUnenrollCourseButton.Size = new System.Drawing.Size(134, 45);
            this.studentUnenrollCourseButton.TabIndex = 48;
            this.studentUnenrollCourseButton.Text = "Unenroll";
            this.studentUnenrollCourseButton.Click += new System.EventHandler(this.studentUnenrollCourseButton_Click);
            // 
            // StudentMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1112, 683);
            this.Controls.Add(this.studentUnenrollCourseButton);
            this.Controls.Add(this.studentUnenrollCourseTextBox);
            this.Controls.Add(this.studentEnrollCourseTextBox);
            this.Controls.Add(this.CourseSearchTextBox);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.studentDataComboBox);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.studentEnrollCourseButton);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.SearchlabelMain);
            this.Name = "StudentMainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.online_learning_management_system_dbDataSet)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel SearchlabelMain;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Button studentEnrollCourseButton;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private online_learning_management_system_dbDataSet online_learning_management_system_dbDataSet;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private online_learning_management_system_dbDataSetTableAdapters.CourseTableAdapter courseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn instructorIDDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2MessageDialog StMainPageMessageDialog1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button assesmentPageLink;
        private Guna.UI2.WinForms.Guna2Button logoutBtn;
        private Guna.UI2.WinForms.Guna2Button userProfileLink;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2ComboBox studentDataComboBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2TextBox CourseSearchTextBox;
        private Guna.UI2.WinForms.Guna2TextBox studentEnrollCourseTextBox;
        private Guna.UI2.WinForms.Guna2TextBox studentUnenrollCourseTextBox;
        private Guna.UI2.WinForms.Guna2Button studentUnenrollCourseButton;
    }
}
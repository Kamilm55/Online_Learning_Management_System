namespace OnlineLearningManagementSystemApp
{
    partial class StudentAssesmentPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.assessmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assessmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.online_learning_management_system_dbDataSet = new OnlineLearningManagementSystemApp.online_learning_management_system_dbDataSet();
            this.assessmentTableAdapter = new OnlineLearningManagementSystemApp.online_learning_management_system_dbDataSetTableAdapters.AssessmentTableAdapter();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.logoutBtn = new Guna.UI2.WinForms.Guna2Button();
            this.userProfileLink = new Guna.UI2.WinForms.Guna2Button();
            this.assesmentPageLink = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.StAssTExtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.studentDataComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.online_learning_management_system_dbDataSet)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Monospac821 BT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.guna2DataGridView1.AutoGenerateColumns = false;
            this.guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.guna2DataGridView1.ColumnHeadersHeight = 35;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.assessmentIDDataGridViewTextBoxColumn,
            this.courseIDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.dueDateDataGridViewTextBoxColumn});
            this.guna2DataGridView1.DataSource = this.assessmentBindingSource;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle11;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(301, 222);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Monospac821 BT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.guna2DataGridView1.RowTemplate.Height = 24;
            this.guna2DataGridView1.Size = new System.Drawing.Size(764, 408);
            this.guna2DataGridView1.TabIndex = 13;
            this.guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Monospac821 BT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 35;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // assessmentIDDataGridViewTextBoxColumn
            // 
            this.assessmentIDDataGridViewTextBoxColumn.DataPropertyName = "AssessmentID";
            this.assessmentIDDataGridViewTextBoxColumn.HeaderText = "AssessmentID";
            this.assessmentIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.assessmentIDDataGridViewTextBoxColumn.Name = "assessmentIDDataGridViewTextBoxColumn";
            this.assessmentIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseIDDataGridViewTextBoxColumn
            // 
            this.courseIDDataGridViewTextBoxColumn.DataPropertyName = "CourseID";
            this.courseIDDataGridViewTextBoxColumn.HeaderText = "CourseID";
            this.courseIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.courseIDDataGridViewTextBoxColumn.Name = "courseIDDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // dueDateDataGridViewTextBoxColumn
            // 
            this.dueDateDataGridViewTextBoxColumn.DataPropertyName = "DueDate";
            this.dueDateDataGridViewTextBoxColumn.HeaderText = "DueDate";
            this.dueDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dueDateDataGridViewTextBoxColumn.Name = "dueDateDataGridViewTextBoxColumn";
            // 
            // assessmentBindingSource
            // 
            this.assessmentBindingSource.DataMember = "Assessment";
            this.assessmentBindingSource.DataSource = this.online_learning_management_system_dbDataSet;
            this.assessmentBindingSource.Filter = "";
            // 
            // online_learning_management_system_dbDataSet
            // 
            this.online_learning_management_system_dbDataSet.DataSetName = "online_learning_management_system_dbDataSet";
            this.online_learning_management_system_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assessmentTableAdapter
            // 
            this.assessmentTableAdapter.ClearBeforeFill = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(19)))), ((int)(((byte)(28)))));
            this.guna2Panel1.Controls.Add(this.logoutBtn);
            this.guna2Panel1.Controls.Add(this.userProfileLink);
            this.guna2Panel1.Controls.Add(this.assesmentPageLink);
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.Location = new System.Drawing.Point(1, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(267, 681);
            this.guna2Panel1.TabIndex = 22;
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
            // assesmentPageLink
            // 
            this.assesmentPageLink.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.assesmentPageLink.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.assesmentPageLink.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.assesmentPageLink.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.assesmentPageLink.Enabled = false;
            this.assesmentPageLink.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.assesmentPageLink.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.assesmentPageLink.ForeColor = System.Drawing.Color.White;
            this.assesmentPageLink.Location = new System.Drawing.Point(0, 256);
            this.assesmentPageLink.Name = "assesmentPageLink";
            this.assesmentPageLink.Size = new System.Drawing.Size(267, 58);
            this.assesmentPageLink.TabIndex = 21;
            this.assesmentPageLink.Text = "Assessments";
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.guna2Button1.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(0, 192);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(267, 58);
            this.guna2Button1.TabIndex = 20;
            this.guna2Button1.Text = "Main Page";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // StAssTExtBox
            // 
            this.StAssTExtBox.BackColor = System.Drawing.Color.Transparent;
            this.StAssTExtBox.BorderColor = System.Drawing.Color.DarkGray;
            this.StAssTExtBox.BorderRadius = 6;
            this.StAssTExtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StAssTExtBox.DefaultText = "";
            this.StAssTExtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.StAssTExtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.StAssTExtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StAssTExtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StAssTExtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StAssTExtBox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.StAssTExtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StAssTExtBox.Location = new System.Drawing.Point(743, 130);
            this.StAssTExtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StAssTExtBox.Name = "StAssTExtBox";
            this.StAssTExtBox.PasswordChar = '\0';
            this.StAssTExtBox.PlaceholderText = "Write text to search";
            this.StAssTExtBox.SelectedText = "";
            this.StAssTExtBox.Size = new System.Drawing.Size(235, 45);
            this.StAssTExtBox.TabIndex = 50;
            this.StAssTExtBox.TextChanged += new System.EventHandler(this.StAssTExtBox_TextChanged);
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
            "All Assessments",
            "Graded Assessments",
            "Non-graded Assessments"});
            this.studentDataComboBox.Location = new System.Drawing.Point(355, 139);
            this.studentDataComboBox.Name = "studentDataComboBox";
            this.studentDataComboBox.Size = new System.Drawing.Size(235, 36);
            this.studentDataComboBox.TabIndex = 49;
            this.studentDataComboBox.SelectedIndexChanged += new System.EventHandler(this.studentDataComboBox_SelectedIndexChanged);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(753, 87);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(75, 26);
            this.guna2HtmlLabel2.TabIndex = 48;
            this.guna2HtmlLabel2.Text = "Search";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(365, 96);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(147, 26);
            this.guna2HtmlLabel4.TabIndex = 47;
            this.guna2HtmlLabel4.Text = "Choose Data:";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(380, 237);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(3, 2);
            this.guna2HtmlLabel3.TabIndex = 46;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Monospac821 BT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(577, 24);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(163, 34);
            this.guna2HtmlLabel5.TabIndex = 51;
            this.guna2HtmlLabel5.Text = "Assesments";
            // 
            // StudentAssesmentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1112, 683);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.StAssTExtBox);
            this.Controls.Add(this.studentDataComboBox);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2DataGridView1);
            this.Name = "StudentAssesmentPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentAssesmentPage";
            this.Load += new System.EventHandler(this.StudentAssesmentPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.online_learning_management_system_dbDataSet)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private online_learning_management_system_dbDataSet online_learning_management_system_dbDataSet;
        private System.Windows.Forms.BindingSource assessmentBindingSource;
        private online_learning_management_system_dbDataSetTableAdapters.AssessmentTableAdapter assessmentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn assessmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button logoutBtn;
        private Guna.UI2.WinForms.Guna2Button userProfileLink;
        private Guna.UI2.WinForms.Guna2Button assesmentPageLink;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox StAssTExtBox;
        private Guna.UI2.WinForms.Guna2ComboBox studentDataComboBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
    }
}
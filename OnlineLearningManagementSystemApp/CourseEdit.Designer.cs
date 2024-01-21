namespace OnlineLearningManagementSystemApp
{
    partial class CourseEdit
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
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label label1;
            this.CourseEditTitleTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.CourseEditDescBtn = new Guna.UI2.WinForms.Guna2Button();
            this.CourseEditTitleBtn = new Guna.UI2.WinForms.Guna2Button();
            this.CourseEditMessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.courseIdComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.CourseEditDescTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            titleLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            titleLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            titleLabel.Location = new System.Drawing.Point(215, 148);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(46, 20);
            titleLabel.TabIndex = 56;
            titleLabel.Text = "Title:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descriptionLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            descriptionLabel.Location = new System.Drawing.Point(215, 251);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(100, 20);
            descriptionLabel.TabIndex = 57;
            descriptionLabel.Text = "Description:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label1.Location = new System.Drawing.Point(215, 43);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(86, 20);
            label1.TabIndex = 62;
            label1.Text = "Course id:";
            // 
            // CourseEditTitleTextBox
            // 
            this.CourseEditTitleTextBox.BackColor = System.Drawing.Color.Transparent;
            this.CourseEditTitleTextBox.BorderColor = System.Drawing.Color.DarkGray;
            this.CourseEditTitleTextBox.BorderRadius = 6;
            this.CourseEditTitleTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CourseEditTitleTextBox.DefaultText = "";
            this.CourseEditTitleTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CourseEditTitleTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CourseEditTitleTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CourseEditTitleTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CourseEditTitleTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CourseEditTitleTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.CourseEditTitleTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CourseEditTitleTextBox.Location = new System.Drawing.Point(210, 184);
            this.CourseEditTitleTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CourseEditTitleTextBox.Name = "CourseEditTitleTextBox";
            this.CourseEditTitleTextBox.PasswordChar = '\0';
            this.CourseEditTitleTextBox.PlaceholderText = "Enter course title";
            this.CourseEditTitleTextBox.SelectedText = "";
            this.CourseEditTitleTextBox.Size = new System.Drawing.Size(287, 53);
            this.CourseEditTitleTextBox.TabIndex = 58;
            // 
            // CourseEditDescBtn
            // 
            this.CourseEditDescBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CourseEditDescBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CourseEditDescBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CourseEditDescBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CourseEditDescBtn.FillColor = System.Drawing.Color.Green;
            this.CourseEditDescBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CourseEditDescBtn.ForeColor = System.Drawing.Color.White;
            this.CourseEditDescBtn.Location = new System.Drawing.Point(525, 285);
            this.CourseEditDescBtn.Name = "CourseEditDescBtn";
            this.CourseEditDescBtn.Size = new System.Drawing.Size(128, 53);
            this.CourseEditDescBtn.TabIndex = 61;
            this.CourseEditDescBtn.Text = "Edit";
            this.CourseEditDescBtn.Click += new System.EventHandler(this.CourseEditDescBtn_Click);
            // 
            // CourseEditTitleBtn
            // 
            this.CourseEditTitleBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CourseEditTitleBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CourseEditTitleBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CourseEditTitleBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CourseEditTitleBtn.FillColor = System.Drawing.Color.Green;
            this.CourseEditTitleBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CourseEditTitleBtn.ForeColor = System.Drawing.Color.White;
            this.CourseEditTitleBtn.Location = new System.Drawing.Point(525, 184);
            this.CourseEditTitleBtn.Name = "CourseEditTitleBtn";
            this.CourseEditTitleBtn.Size = new System.Drawing.Size(128, 53);
            this.CourseEditTitleBtn.TabIndex = 60;
            this.CourseEditTitleBtn.Text = "Edit";
            this.CourseEditTitleBtn.Click += new System.EventHandler(this.CourseEditTitleBtn_Click);
            // 
            // CourseEditMessageDialog1
            // 
            this.CourseEditMessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.CourseEditMessageDialog1.Caption = null;
            this.CourseEditMessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            this.CourseEditMessageDialog1.Parent = this;
            this.CourseEditMessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.CourseEditMessageDialog1.Text = null;
            // 
            // courseIdComboBox
            // 
            this.courseIdComboBox.BackColor = System.Drawing.Color.Transparent;
            this.courseIdComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.courseIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.courseIdComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.courseIdComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.courseIdComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.courseIdComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.courseIdComboBox.ItemHeight = 30;
            this.courseIdComboBox.Location = new System.Drawing.Point(210, 75);
            this.courseIdComboBox.Name = "courseIdComboBox";
            this.courseIdComboBox.Size = new System.Drawing.Size(287, 36);
            this.courseIdComboBox.TabIndex = 63;
            this.courseIdComboBox.SelectedIndexChanged += new System.EventHandler(this.courseIdComboBox_SelectedIndexChanged);
            // 
            // CourseEditDescTextBox
            // 
            this.CourseEditDescTextBox.BackColor = System.Drawing.Color.Transparent;
            this.CourseEditDescTextBox.BorderColor = System.Drawing.Color.DarkGray;
            this.CourseEditDescTextBox.BorderRadius = 6;
            this.CourseEditDescTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CourseEditDescTextBox.DefaultText = "";
            this.CourseEditDescTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CourseEditDescTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CourseEditDescTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CourseEditDescTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CourseEditDescTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CourseEditDescTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.CourseEditDescTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CourseEditDescTextBox.Location = new System.Drawing.Point(210, 285);
            this.CourseEditDescTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CourseEditDescTextBox.Name = "CourseEditDescTextBox";
            this.CourseEditDescTextBox.PasswordChar = '\0';
            this.CourseEditDescTextBox.PlaceholderText = "Enter course description";
            this.CourseEditDescTextBox.SelectedText = "";
            this.CourseEditDescTextBox.Size = new System.Drawing.Size(287, 53);
            this.CourseEditDescTextBox.TabIndex = 64;
            // 
            // CourseEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(97)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(761, 464);
            this.Controls.Add(this.CourseEditDescTextBox);
            this.Controls.Add(this.courseIdComboBox);
            this.Controls.Add(label1);
            this.Controls.Add(this.CourseEditDescBtn);
            this.Controls.Add(this.CourseEditTitleBtn);
            this.Controls.Add(this.CourseEditTitleTextBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(descriptionLabel);
            this.Name = "CourseEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CourseEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox CourseEditTitleTextBox;
        private Guna.UI2.WinForms.Guna2Button CourseEditDescBtn;
        private Guna.UI2.WinForms.Guna2Button CourseEditTitleBtn;
        private Guna.UI2.WinForms.Guna2MessageDialog CourseEditMessageDialog1;
        private Guna.UI2.WinForms.Guna2ComboBox courseIdComboBox;
        private Guna.UI2.WinForms.Guna2TextBox CourseEditDescTextBox;
    }
}
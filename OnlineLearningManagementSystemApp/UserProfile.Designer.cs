namespace OnlineLearningManagementSystemApp
{
    partial class UserProfile
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
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label passwordLabel;
            this.online_learning_management_system_dbDataSet = new OnlineLearningManagementSystemApp.online_learning_management_system_dbDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new OnlineLearningManagementSystemApp.online_learning_management_system_dbDataSetTableAdapters.UsersTableAdapter();
            this.UserPrEditBtn = new Guna.UI2.WinForms.Guna2Button();
            this.UserPrUsernameLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.UserPrPasswordLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.UserPrEmailLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.UserMsgDialog = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.logoutBtn = new Guna.UI2.WinForms.Guna2Button();
            this.userProfileLink = new Guna.UI2.WinForms.Guna2Button();
            this.assesmentPageLink = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            usernameLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.online_learning_management_system_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            usernameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            usernameLabel.Location = new System.Drawing.Point(427, 217);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(158, 36);
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "Username:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            emailLabel.Location = new System.Drawing.Point(427, 263);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(96, 36);
            emailLabel.TabIndex = 5;
            emailLabel.Text = "Email:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            passwordLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            passwordLabel.Location = new System.Drawing.Point(427, 315);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(155, 36);
            passwordLabel.TabIndex = 7;
            passwordLabel.Text = "Password:";
            // 
            // online_learning_management_system_dbDataSet
            // 
            this.online_learning_management_system_dbDataSet.DataSetName = "online_learning_management_system_dbDataSet";
            this.online_learning_management_system_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.online_learning_management_system_dbDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // UserPrEditBtn
            // 
            this.UserPrEditBtn.AutoRoundedCorners = true;
            this.UserPrEditBtn.BorderRadius = 21;
            this.UserPrEditBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UserPrEditBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UserPrEditBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UserPrEditBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UserPrEditBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(146)))), ((int)(((byte)(230)))));
            this.UserPrEditBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UserPrEditBtn.ForeColor = System.Drawing.Color.White;
            this.UserPrEditBtn.Location = new System.Drawing.Point(443, 382);
            this.UserPrEditBtn.Name = "UserPrEditBtn";
            this.UserPrEditBtn.Size = new System.Drawing.Size(286, 45);
            this.UserPrEditBtn.TabIndex = 47;
            this.UserPrEditBtn.Text = "Edit";
            this.UserPrEditBtn.Click += new System.EventHandler(this.UserPrEditBtn_Click);
            // 
            // UserPrUsernameLabel
            // 
            this.UserPrUsernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.UserPrUsernameLabel.Font = new System.Drawing.Font("Monospac821 BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserPrUsernameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.UserPrUsernameLabel.Location = new System.Drawing.Point(600, 217);
            this.UserPrUsernameLabel.Name = "UserPrUsernameLabel";
            this.UserPrUsernameLabel.Size = new System.Drawing.Size(147, 38);
            this.UserPrUsernameLabel.TabIndex = 48;
            this.UserPrUsernameLabel.Text = "Username";
            // 
            // UserPrPasswordLabel
            // 
            this.UserPrPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.UserPrPasswordLabel.Font = new System.Drawing.Font("Monospac821 BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserPrPasswordLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.UserPrPasswordLabel.Location = new System.Drawing.Point(600, 315);
            this.UserPrPasswordLabel.Name = "UserPrPasswordLabel";
            this.UserPrPasswordLabel.Size = new System.Drawing.Size(93, 38);
            this.UserPrPasswordLabel.TabIndex = 49;
            this.UserPrPasswordLabel.Text = "*****";
            // 
            // UserPrEmailLabel
            // 
            this.UserPrEmailLabel.BackColor = System.Drawing.Color.Transparent;
            this.UserPrEmailLabel.Font = new System.Drawing.Font("Monospac821 BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserPrEmailLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.UserPrEmailLabel.Location = new System.Drawing.Point(600, 263);
            this.UserPrEmailLabel.Name = "UserPrEmailLabel";
            this.UserPrEmailLabel.Size = new System.Drawing.Size(93, 38);
            this.UserPrEmailLabel.TabIndex = 50;
            this.UserPrEmailLabel.Text = "Email";
            // 
            // UserMsgDialog
            // 
            this.UserMsgDialog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.UserMsgDialog.Caption = null;
            this.UserMsgDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            this.UserMsgDialog.Parent = this;
            this.UserMsgDialog.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.UserMsgDialog.Text = null;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(19)))), ((int)(((byte)(28)))));
            this.guna2Panel1.Controls.Add(this.logoutBtn);
            this.guna2Panel1.Controls.Add(this.userProfileLink);
            this.guna2Panel1.Controls.Add(this.assesmentPageLink);
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.Location = new System.Drawing.Point(1, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(267, 681);
            this.guna2Panel1.TabIndex = 51;
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
            this.userProfileLink.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.userProfileLink.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.userProfileLink.Enabled = false;
            this.userProfileLink.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.userProfileLink.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.userProfileLink.ForeColor = System.Drawing.Color.White;
            this.userProfileLink.Location = new System.Drawing.Point(3, 319);
            this.userProfileLink.Name = "userProfileLink";
            this.userProfileLink.Size = new System.Drawing.Size(267, 58);
            this.userProfileLink.TabIndex = 22;
            this.userProfileLink.Text = "Profile";
            // 
            // assesmentPageLink
            // 
            this.assesmentPageLink.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.assesmentPageLink.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.assesmentPageLink.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
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
            // UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1112, 683);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.UserPrEmailLabel);
            this.Controls.Add(this.UserPrPasswordLabel);
            this.Controls.Add(this.UserPrUsernameLabel);
            this.Controls.Add(this.UserPrEditBtn);
            this.Controls.Add(usernameLabel);
            this.Controls.Add(emailLabel);
            this.Controls.Add(passwordLabel);
            this.Name = "UserProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserProfile";
            this.Load += new System.EventHandler(this.UserProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.online_learning_management_system_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private online_learning_management_system_dbDataSet online_learning_management_system_dbDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private online_learning_management_system_dbDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private Guna.UI2.WinForms.Guna2Button UserPrEditBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel UserPrUsernameLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel UserPrPasswordLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel UserPrEmailLabel;
        private Guna.UI2.WinForms.Guna2MessageDialog UserMsgDialog;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button logoutBtn;
        private Guna.UI2.WinForms.Guna2Button userProfileLink;
        private Guna.UI2.WinForms.Guna2Button assesmentPageLink;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
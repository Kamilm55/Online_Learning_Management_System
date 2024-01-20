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
            usernameLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.online_learning_management_system_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new System.Drawing.Point(121, 143);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(73, 16);
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "Username:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(121, 171);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(44, 16);
            emailLabel.TabIndex = 5;
            emailLabel.Text = "Email:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(121, 199);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(70, 16);
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
            this.UserPrEditBtn.FillColor = System.Drawing.Color.Green;
            this.UserPrEditBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UserPrEditBtn.ForeColor = System.Drawing.Color.White;
            this.UserPrEditBtn.Location = new System.Drawing.Point(100, 282);
            this.UserPrEditBtn.Name = "UserPrEditBtn";
            this.UserPrEditBtn.Size = new System.Drawing.Size(244, 45);
            this.UserPrEditBtn.TabIndex = 47;
            this.UserPrEditBtn.Text = "Edit";
            this.UserPrEditBtn.Click += new System.EventHandler(this.UserPrEditBtn_Click);
            // 
            // UserPrUsernameLabel
            // 
            this.UserPrUsernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.UserPrUsernameLabel.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserPrUsernameLabel.Location = new System.Drawing.Point(278, 133);
            this.UserPrUsernameLabel.Name = "UserPrUsernameLabel";
            this.UserPrUsernameLabel.Size = new System.Drawing.Size(99, 26);
            this.UserPrUsernameLabel.TabIndex = 48;
            this.UserPrUsernameLabel.Text = "Username";
            // 
            // UserPrPasswordLabel
            // 
            this.UserPrPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.UserPrPasswordLabel.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserPrPasswordLabel.Location = new System.Drawing.Point(278, 212);
            this.UserPrPasswordLabel.Name = "UserPrPasswordLabel";
            this.UserPrPasswordLabel.Size = new System.Drawing.Size(63, 26);
            this.UserPrPasswordLabel.TabIndex = 49;
            this.UserPrPasswordLabel.Text = "*****";
            // 
            // UserPrEmailLabel
            // 
            this.UserPrEmailLabel.BackColor = System.Drawing.Color.Transparent;
            this.UserPrEmailLabel.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserPrEmailLabel.Location = new System.Drawing.Point(278, 171);
            this.UserPrEmailLabel.Name = "UserPrEmailLabel";
            this.UserPrEmailLabel.Size = new System.Drawing.Size(63, 26);
            this.UserPrEmailLabel.TabIndex = 50;
            this.UserPrEmailLabel.Text = "Email";
            // 
            // UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 668);
            this.Controls.Add(this.UserPrEmailLabel);
            this.Controls.Add(this.UserPrPasswordLabel);
            this.Controls.Add(this.UserPrUsernameLabel);
            this.Controls.Add(this.UserPrEditBtn);
            this.Controls.Add(usernameLabel);
            this.Controls.Add(emailLabel);
            this.Controls.Add(passwordLabel);
            this.Name = "UserProfile";
            this.Text = "UserProfile";
            this.Load += new System.EventHandler(this.UserProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.online_learning_management_system_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
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
    }
}
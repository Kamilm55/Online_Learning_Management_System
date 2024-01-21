namespace OnlineLearningManagementSystemApp
{
    partial class UserCrud
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
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label passwordLabel;
            this.UserCrUsernameSubmitBtn = new Guna.UI2.WinForms.Guna2Button();
            this.userCrEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.userCrPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.userCrUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.userCrMsgDialog = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.UserCrEmailSubmitBtn = new Guna.UI2.WinForms.Guna2Button();
            this.UserCrPasswordSubmitBtn = new Guna.UI2.WinForms.Guna2Button();
            usernameLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            usernameLabel.ForeColor = System.Drawing.Color.Snow;
            usernameLabel.Location = new System.Drawing.Point(213, 69);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(130, 29);
            usernameLabel.TabIndex = 9;
            usernameLabel.Text = "Username:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.ForeColor = System.Drawing.Color.Snow;
            emailLabel.Location = new System.Drawing.Point(213, 184);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(80, 29);
            emailLabel.TabIndex = 11;
            emailLabel.Text = "Email:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            passwordLabel.ForeColor = System.Drawing.Color.Snow;
            passwordLabel.Location = new System.Drawing.Point(213, 303);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(126, 29);
            passwordLabel.TabIndex = 13;
            passwordLabel.Text = "Password:";
            // 
            // UserCrUsernameSubmitBtn
            // 
            this.UserCrUsernameSubmitBtn.BorderRadius = 10;
            this.UserCrUsernameSubmitBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UserCrUsernameSubmitBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UserCrUsernameSubmitBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UserCrUsernameSubmitBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UserCrUsernameSubmitBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(193)))), ((int)(((byte)(211)))));
            this.UserCrUsernameSubmitBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UserCrUsernameSubmitBtn.ForeColor = System.Drawing.Color.White;
            this.UserCrUsernameSubmitBtn.Location = new System.Drawing.Point(522, 115);
            this.UserCrUsernameSubmitBtn.Name = "UserCrUsernameSubmitBtn";
            this.UserCrUsernameSubmitBtn.Size = new System.Drawing.Size(128, 53);
            this.UserCrUsernameSubmitBtn.TabIndex = 47;
            this.UserCrUsernameSubmitBtn.Text = "Edit";
            this.UserCrUsernameSubmitBtn.Click += new System.EventHandler(this.UserCrSubmitBtn_Click);
            // 
            // userCrEmail
            // 
            this.userCrEmail.BackColor = System.Drawing.Color.Transparent;
            this.userCrEmail.BorderColor = System.Drawing.Color.DarkGray;
            this.userCrEmail.BorderRadius = 6;
            this.userCrEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userCrEmail.DefaultText = "";
            this.userCrEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.userCrEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.userCrEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userCrEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userCrEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userCrEmail.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.userCrEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userCrEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userCrEmail.Location = new System.Drawing.Point(218, 227);
            this.userCrEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userCrEmail.Name = "userCrEmail";
            this.userCrEmail.PasswordChar = '\0';
            this.userCrEmail.PlaceholderText = "Enter your email";
            this.userCrEmail.SelectedText = "";
            this.userCrEmail.Size = new System.Drawing.Size(287, 53);
            this.userCrEmail.TabIndex = 48;
            // 
            // userCrPassword
            // 
            this.userCrPassword.BackColor = System.Drawing.Color.Transparent;
            this.userCrPassword.BorderColor = System.Drawing.Color.DarkGray;
            this.userCrPassword.BorderRadius = 6;
            this.userCrPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userCrPassword.DefaultText = "";
            this.userCrPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.userCrPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.userCrPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userCrPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userCrPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userCrPassword.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.userCrPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userCrPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userCrPassword.Location = new System.Drawing.Point(218, 352);
            this.userCrPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userCrPassword.Name = "userCrPassword";
            this.userCrPassword.PasswordChar = '●';
            this.userCrPassword.PlaceholderText = "Enter your password";
            this.userCrPassword.SelectedText = "";
            this.userCrPassword.Size = new System.Drawing.Size(287, 53);
            this.userCrPassword.TabIndex = 49;
            this.userCrPassword.UseSystemPasswordChar = true;
            // 
            // userCrUsername
            // 
            this.userCrUsername.BackColor = System.Drawing.Color.Transparent;
            this.userCrUsername.BorderColor = System.Drawing.Color.DarkGray;
            this.userCrUsername.BorderRadius = 6;
            this.userCrUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userCrUsername.DefaultText = "";
            this.userCrUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.userCrUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.userCrUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userCrUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userCrUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userCrUsername.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.userCrUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userCrUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userCrUsername.Location = new System.Drawing.Point(218, 115);
            this.userCrUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userCrUsername.Name = "userCrUsername";
            this.userCrUsername.PasswordChar = '\0';
            this.userCrUsername.PlaceholderText = "Enter your username";
            this.userCrUsername.SelectedText = "";
            this.userCrUsername.Size = new System.Drawing.Size(287, 53);
            this.userCrUsername.TabIndex = 50;
            // 
            // userCrMsgDialog
            // 
            this.userCrMsgDialog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.userCrMsgDialog.Caption = null;
            this.userCrMsgDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            this.userCrMsgDialog.Parent = this;
            this.userCrMsgDialog.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.userCrMsgDialog.Text = null;
            // 
            // UserCrEmailSubmitBtn
            // 
            this.UserCrEmailSubmitBtn.BorderRadius = 10;
            this.UserCrEmailSubmitBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UserCrEmailSubmitBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UserCrEmailSubmitBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UserCrEmailSubmitBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UserCrEmailSubmitBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(193)))), ((int)(((byte)(211)))));
            this.UserCrEmailSubmitBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UserCrEmailSubmitBtn.ForeColor = System.Drawing.Color.White;
            this.UserCrEmailSubmitBtn.Location = new System.Drawing.Point(522, 227);
            this.UserCrEmailSubmitBtn.Name = "UserCrEmailSubmitBtn";
            this.UserCrEmailSubmitBtn.Size = new System.Drawing.Size(128, 53);
            this.UserCrEmailSubmitBtn.TabIndex = 51;
            this.UserCrEmailSubmitBtn.Text = "Edit";
            this.UserCrEmailSubmitBtn.Click += new System.EventHandler(this.UserCrEmailSubmitBtn_Click);
            // 
            // UserCrPasswordSubmitBtn
            // 
            this.UserCrPasswordSubmitBtn.BorderRadius = 10;
            this.UserCrPasswordSubmitBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UserCrPasswordSubmitBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UserCrPasswordSubmitBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UserCrPasswordSubmitBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UserCrPasswordSubmitBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(193)))), ((int)(((byte)(211)))));
            this.UserCrPasswordSubmitBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UserCrPasswordSubmitBtn.ForeColor = System.Drawing.Color.White;
            this.UserCrPasswordSubmitBtn.Location = new System.Drawing.Point(522, 352);
            this.UserCrPasswordSubmitBtn.Name = "UserCrPasswordSubmitBtn";
            this.UserCrPasswordSubmitBtn.Size = new System.Drawing.Size(128, 53);
            this.UserCrPasswordSubmitBtn.TabIndex = 52;
            this.UserCrPasswordSubmitBtn.Text = "Edit";
            this.UserCrPasswordSubmitBtn.Click += new System.EventHandler(this.UserCrPasswordSubmitBtn_Click);
            // 
            // UserCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(97)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(761, 464);
            this.Controls.Add(this.UserCrPasswordSubmitBtn);
            this.Controls.Add(this.UserCrEmailSubmitBtn);
            this.Controls.Add(this.userCrUsername);
            this.Controls.Add(this.userCrPassword);
            this.Controls.Add(this.userCrEmail);
            this.Controls.Add(this.UserCrUsernameSubmitBtn);
            this.Controls.Add(usernameLabel);
            this.Controls.Add(emailLabel);
            this.Controls.Add(passwordLabel);
            this.Name = "UserCrud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UserCrud";
            this.Load += new System.EventHandler(this.UserCrud_Load);
            this.Leave += new System.EventHandler(this.UserCrud_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button UserCrUsernameSubmitBtn;
        private Guna.UI2.WinForms.Guna2TextBox userCrEmail;
        private Guna.UI2.WinForms.Guna2TextBox userCrPassword;
        private Guna.UI2.WinForms.Guna2TextBox userCrUsername;
        private Guna.UI2.WinForms.Guna2MessageDialog userCrMsgDialog;
        private Guna.UI2.WinForms.Guna2Button UserCrEmailSubmitBtn;
        private Guna.UI2.WinForms.Guna2Button UserCrPasswordSubmitBtn;
    }
}
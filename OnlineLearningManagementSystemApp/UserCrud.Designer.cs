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
            this.UserCrSubmitBtn = new Guna.UI2.WinForms.Guna2Button();
            this.userCrEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.userCrPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.userCrUsername = new Guna.UI2.WinForms.Guna2TextBox();
            usernameLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new System.Drawing.Point(324, 88);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(73, 16);
            usernameLabel.TabIndex = 9;
            usernameLabel.Text = "Username:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(327, 175);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(44, 16);
            emailLabel.TabIndex = 11;
            emailLabel.Text = "Email:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(327, 250);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(70, 16);
            passwordLabel.TabIndex = 13;
            passwordLabel.Text = "Password:";
            // 
            // UserCrSubmitBtn
            // 
            this.UserCrSubmitBtn.AutoRoundedCorners = true;
            this.UserCrSubmitBtn.BorderRadius = 21;
            this.UserCrSubmitBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UserCrSubmitBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UserCrSubmitBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UserCrSubmitBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UserCrSubmitBtn.FillColor = System.Drawing.Color.Green;
            this.UserCrSubmitBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UserCrSubmitBtn.ForeColor = System.Drawing.Color.White;
            this.UserCrSubmitBtn.Location = new System.Drawing.Point(373, 339);
            this.UserCrSubmitBtn.Name = "UserCrSubmitBtn";
            this.UserCrSubmitBtn.Size = new System.Drawing.Size(244, 45);
            this.UserCrSubmitBtn.TabIndex = 47;
            this.UserCrSubmitBtn.Text = "Submit";
            this.UserCrSubmitBtn.Click += new System.EventHandler(this.UserCrSubmitBtn_Click);
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
            this.userCrEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userCrEmail.Location = new System.Drawing.Point(426, 158);
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
            this.userCrPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userCrPassword.Location = new System.Drawing.Point(426, 234);
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
            this.userCrUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userCrUsername.Location = new System.Drawing.Point(426, 76);
            this.userCrUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userCrUsername.Name = "userCrUsername";
            this.userCrUsername.PasswordChar = '\0';
            this.userCrUsername.PlaceholderText = "Enter your username";
            this.userCrUsername.SelectedText = "";
            this.userCrUsername.Size = new System.Drawing.Size(287, 53);
            this.userCrUsername.TabIndex = 50;
            // 
            // UserCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 695);
            this.Controls.Add(this.userCrUsername);
            this.Controls.Add(this.userCrPassword);
            this.Controls.Add(this.userCrEmail);
            this.Controls.Add(this.UserCrSubmitBtn);
            this.Controls.Add(usernameLabel);
            this.Controls.Add(emailLabel);
            this.Controls.Add(passwordLabel);
            this.Name = "UserCrud";
            this.Text = "UserCrud";
            this.Load += new System.EventHandler(this.UserCrud_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button UserCrSubmitBtn;
        private Guna.UI2.WinForms.Guna2TextBox userCrEmail;
        private Guna.UI2.WinForms.Guna2TextBox userCrPassword;
        private Guna.UI2.WinForms.Guna2TextBox userCrUsername;
    }
}
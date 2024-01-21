using OnlineLearningManagementSystemApp.Models;
using OnlineLearningManagementSystemApp.Presenters;
using OnlineLearningManagementSystemApp.Utils;
using OnlineLearningManagementSystemApp.Views;
using System;

using System.Windows.Forms;

namespace OnlineLearningManagementSystemApp
{
    public partial class RegisterForm : Form, IRegisterView
    {
        public RegisterForm()
        {
            InitializeComponent();

            // Assuming you have an instance of RegisterPresenter in your class
            var presenter = new RegisterPresenter(this);

            // Subscribe to view events
            RegisterButtonClicked += presenter.OnRegisterButtonClicked;
        }

        public string Email { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }

        // Events to be handled by the presenter
        public event EventHandler RegisterButtonClicked;

        private void RegisterSubmitBtn_Click(object sender, EventArgs e)
        {
            Email = registerEmailTextBox.Text;
            Password = registerPasswordTextBox.Text;
            Username = registerUsernameTextBox.Text;

            // Notify the presenter that register button is clicked
            RegisterButtonClicked?.Invoke(this, EventArgs.Empty);

        }

        private void linkToLogin_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        //

        public void ShowInformation(string message, string caption = "Information")
        {
            GunaMessageDialogUtils.PrepareShowInformation(guna2MessageRegisterDialog, message, caption);
        }

        public void ShowWarning(string message, string caption = "Warning")
        {
            GunaMessageDialogUtils.PrepareShowWarning(guna2MessageRegisterDialog, message, caption);
        }

        public void ShowError(string message, string caption = "Error")
        {
            GunaMessageDialogUtils.PrepareShowError(guna2MessageRegisterDialog, message, caption);
        }

        public void ClearTextboxes()
        {
            registerEmailTextBox.Text = string.Empty;
            registerPasswordTextBox.Text = string.Empty;
            registerUsernameTextBox.Text = string.Empty;
        }
    }
}

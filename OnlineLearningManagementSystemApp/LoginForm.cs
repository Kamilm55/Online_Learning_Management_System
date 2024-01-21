using Guna.UI2.WinForms;
using OnlineLearningManagementSystemApp.Models;
using OnlineLearningManagementSystemApp.Presenters;
using OnlineLearningManagementSystemApp.Utils;
using OnlineLearningManagementSystemApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineLearningManagementSystemApp
{
    public partial class LoginForm : Form, ILoginView
    {
        public LoginForm()
        {
            InitializeComponent();
            // Assuming you have an instance of LoginRegisterPresenter in your class
            var presenter = new LoginPresenter(this);
            //
            guna2MessageDialogLogin.Style = MessageDialogStyle.Dark;

            // Subscribe to view events
            LoginButtonClicked += presenter.OnLoginButtonClicked;
        }
        public string Email { get; set; }
        public string Password { get; set; }

        // Events to be handled by the presenter
        public event EventHandler LoginButtonClicked;

        private void loginSubmitBtn_Click(object sender, EventArgs e)
        {
            Email = loginEmailTextBox1.Text;
            Password = loginPasswordTextBox.Text;
            // Notify the presenter that login button is clicked
            LoginButtonClicked?.Invoke(this, EventArgs.Empty);
        }

       
        private void linkToRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        public void Close() {
            this.Hide();
        }
        /////////////////////

        // Show information dialog
        public void ShowInformation(string message, string caption = "Information")
        {
            GunaMessageDialogUtils.PrepareShowInformation(guna2MessageDialogLogin, message, caption);   
        }

        // Show warning dialog
        public void ShowWarning(string message, string caption = "Warning")
        {
            GunaMessageDialogUtils.PrepareShowWarning(guna2MessageDialogLogin, message, caption);
        }

        // Show error dialog
        public void ShowError(string message, string caption = "Error")
        { 
            GunaMessageDialogUtils.PrepareShowError(guna2MessageDialogLogin, message, caption);
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void ClearTextboxes()
        {
            loginEmailTextBox1.Text = string.Empty;
            loginPasswordTextBox.Text = string.Empty;
        }
    }
}

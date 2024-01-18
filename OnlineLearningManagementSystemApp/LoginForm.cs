using OnlineLearningManagementSystemApp.Models;
using OnlineLearningManagementSystemApp.Presenters;
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
            var presenter = new LoginRegisterPresenter(this);

            // Subscribe to view events
            LoginButtonClicked += presenter.OnLoginButtonClicked;
        }
        public string Email { get; set; }
        public string Password { get; set; }

        // Events to be handled by the presenter
        public event EventHandler LoginButtonClicked;


        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void loginSubmitBtn_Click(object sender, EventArgs e)
        {
            Email = loginEmailTextBox.Text;
            Password = loginPasswordTextBox.Text;
            // Notify the presenter that login button is clicked
            LoginButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}

using OnlineLearningManagementSystemApp.Models;
using OnlineLearningManagementSystemApp.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLearningManagementSystemApp.Presenters
{
    public class LoginRegisterPresenter
    {
        private readonly ILoginView view;
        private readonly IUserRepository userRepository = new UserRepository();

        public LoginRegisterPresenter(ILoginView view, IUserRepository userRepository)
        {
            this.view = view;
            this.userRepository = userRepository;
        }

        public void OnLoginButtonClicked(object sender, EventArgs e)
        {
            // Implement login logic
            string email = view.Email;
            string password = view.Password;

            // Validate credentials, etc.
            Debug.WriteLine("email,pass : " + email + " " + password); 

            // Show a message to the user
            view.ShowMessage("Login clicked. Implement login logic here.");
        }

       
    }

}

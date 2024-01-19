using OnlineLearningManagementSystemApp.Business;
using OnlineLearningManagementSystemApp.Models;
using OnlineLearningManagementSystemApp.Utils;
using OnlineLearningManagementSystemApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLearningManagementSystemApp.Presenters
{
    public class RegisterPresenter
    {
        private readonly IRegisterView view;
        private readonly AuthUtils authUtils;
        private readonly IUserRepository userRepository;
        private readonly AuthBusiness authBusiness;

        public RegisterPresenter(IRegisterView view)
        {
            this.view = view; // injection
            this.userRepository = new UserRepository();
            authUtils = new AuthUtils();
            authBusiness = new AuthBusiness();
        }

        public void OnRegisterButtonClicked(object sender, EventArgs e)
        {
            // Implement login logic
            string email = view.Email;
            string password = view.Password;
            string username = view.Username;

            // Validate email and password using the utility method
            bool validationSuccessful = authUtils.ValidateCredentials(view, username,email, password);

            // If validation fails, return and display a warning message
            if (!validationSuccessful)
            {
                return;
            }
            // auth business register
            User user = new User();
            user.Email = email;
            user.Password = password;
            user.Username = username;

            // Attempt to add the user
            authBusiness.AddStudent(view, user);
           
        }

    }
}

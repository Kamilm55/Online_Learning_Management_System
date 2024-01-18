﻿using OnlineLearningManagementSystemApp.Business;
using OnlineLearningManagementSystemApp.Models;
using OnlineLearningManagementSystemApp.Utils;
using OnlineLearningManagementSystemApp.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLearningManagementSystemApp.Presenters
{
    public class LoginPresenter
    {
        private readonly ILoginView view;
        private readonly AuthUtils authUtils;
        private readonly IUserRepository userRepository;
        private readonly  AuthBusiness authBusiness;

        public LoginPresenter(ILoginView view)
        {
            this.view = view;
            this.userRepository = new UserRepository();
            authUtils = new AuthUtils();
            authBusiness = new AuthBusiness();
        }

        public void OnLoginButtonClicked(object sender, EventArgs e)
        {
            // Implement login logic
            string email = view.Email;
            string password = view.Password;

            // Validate email and password using the utility method
            bool validationSuccessful = authUtils.ValidateCredentials(view, email, password);

            // If validation fails, return and display a warning message
            if (!validationSuccessful)
            {
                return;
            }
            // auth business login method
            User user = authBusiness.AuthenticateUser(view,email,password);

            if (user != null)
            {
                // Show a message to the user for successful login
                view.ShowInformation("Login successful. Welcome to Online Learning Management System");
            }

            // implement role based auth
            
        }



    }

}

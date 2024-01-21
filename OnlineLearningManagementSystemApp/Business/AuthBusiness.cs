using Guna.UI2.WinForms;
using OnlineLearningManagementSystemApp.Models;
using OnlineLearningManagementSystemApp.Utils;
using OnlineLearningManagementSystemApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace OnlineLearningManagementSystemApp.Business
{
    internal class AuthBusiness
    {
        private IUserRepository userRepository;
        public AuthBusiness() 
        { 
            userRepository = new UserRepository();
        }
        public User AuthenticateUser(ILoginView view,string email, string password)
        {
            try
            {
                // Find the user by email
                User user = userRepository.GetByEmail(email);

                // Check if the user exists
                if (user == null)
                {
                    throw new AuthenticationException("Authentication failed. User not found.");
                }

                // Validate the password (you can customize this validation logic as needed)
                if (user.Password != password)
                {
                    throw new AuthenticationException("Authentication failed. Invalid password.");
                }

                return user; // Authentication successful, return the user object
            }
            catch (AuthenticationException authEx)
            {
                // Display authentication exception message in a MessageBox
                view.ShowError(authEx.Message);

                // Return null or handle the failure as appropriate for your application
                return null;
            }
            catch (Exception ex)
            {
                // Display a generic error message in a MessageBox for unexpected exceptions
                view.ShowError("An unexpected error occurred during authentication.", "Error");
                // Log or handle the unexpected exception as needed
                Console.WriteLine(ex.Message);

                // Return null or handle the failure as appropriate for your application
                return null;
            }
        }

        internal void AddStudent(IRegisterView view,User user)
        {
            try
            {
                user.Role = "Student";
                userRepository.Add(user);
                // If the registration is successful, show a message to the user
                view.ShowInformation("Registration is successful. You can sign in now!");
                // Clear the textboxes after registration
                view.ClearTextboxes();
            }
            catch (InvalidOperationException ex)
            {
                // Handle the case where the email or username is already in use
                view.ShowError(ex.Message);
            }
        }
    }
}

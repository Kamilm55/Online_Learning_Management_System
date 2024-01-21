using System.Text.RegularExpressions;
using OnlineLearningManagementSystemApp.Views;

namespace OnlineLearningManagementSystemApp.Utils
{
    public class AuthUtils
    {
        public bool ValidateCredentials(ILoginView view, string email, string password)
        {
            // Validate credentials
            bool isValidEmail = ValidateEmail(view, email);
            if (!isValidEmail) return false;
            bool isValidPassword = ValidatePassword(view, password);

            return isValidEmail && isValidPassword;
        }

        public bool ValidateCredentials(IRegisterView view , string username,  string email , string password)
        {
            // Validate registration data
            bool isValidEmail = ValidateEmail(view, email);
            if (!isValidEmail) return false;
            bool isValidPassword = ValidatePassword(view, password);
            if (!isValidPassword) return false;
            bool isValidUsername = ValidateUsername(view, username);

            return isValidUsername && isValidPassword && isValidEmail;
        }

        public bool ValidateUsername(IView view, string username)
        {
            // Validate username
            if (string.IsNullOrWhiteSpace(username))
            {
                // Show warning message if username is null or empty
                view.ShowWarning("Please enter a username.");
                return false; // Exit the method
            }

            // Additional username validation logic can be added here

            return true;
        }

        public bool ValidatePassword(IView view, string password)
        {
            // Validate password
            if (string.IsNullOrWhiteSpace(password) || password.Length < 6)
            {
                // Show warning message if password is null, empty, or too short
                view.ShowWarning("Password must be at least 6 characters long.");
                return false; // Exit the method
            }

            // Additional password validation logic can be added here

            return true;
        }

        public bool ValidateEmail(IView view, string email)
        {
            // Use a regular expression to validate the email format
            if (!IsValidEmail(email))
            {
                // Show warning message if the email format is invalid
                view.ShowWarning("Invalid email format. Please enter a valid email address.");
                return false; // Exit the method
            }

            return true;
        }

        // Regular expression for basic email validation
        private bool IsValidEmail(string email)
        {
            string pattern = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
            return Regex.IsMatch(email, pattern);
        }
    }
}

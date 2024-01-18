using System.Text.RegularExpressions;
using OnlineLearningManagementSystemApp.Views;

namespace OnlineLearningManagementSystemApp.Utils
{
    public class AuthUtils
    {
        public bool ValidateEmailAndPassword(ILoginView view, string email, string password)
        {
            // Validate credentials
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                // Show warning message if either email or password is null or empty
                view.ShowWarning("Please enter both email and password.");
                return false; // Exit the method, as there's no need to proceed with further validation
            }

            // Check if email and password meet minimum length requirements
            if (email.Length < 6 || password.Length < 6)
            {
                // Show warning message if either email or password is too short
                view.ShowWarning("Email and password must be at least 6 characters long.");
                return false; // Exit the method
            }

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

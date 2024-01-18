using Guna.UI2.WinForms;
using OnlineLearningManagementSystemApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace OnlineLearningManagementSystemApp.Utils
{
    public class AuthUtils
    {
        private GunaMessageDialogUtils messageDialog ;

        public AuthUtils()
        {
            this.messageDialog = new GunaMessageDialogUtils();
        }

        public bool ValidateEmailAndPassword(ILoginView view,string email, string password)
        {
            // Validate credentials
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {

                // Show warning message if either email or password is null or empty
                messageDialog.ShowWarning("Please enter both email and password.");
              //  view.ShowMessage("Please enter both email and password.");
                return false; // Exit the method, as there's no need to proceed with further validation
            }
            // Check if email and password meet minimum length requirements
            if (email.Length < 6 || password.Length < 6)
            {
                // Show warning message if either email or password is too short
                messageDialog.ShowWarning("Email and password must be at least 6 characters long.");
               // view.ShowMessage("Email and password must be at least 6 characters long.");
                return false; // Exit the method
            }
            return true;
        }
    }
}

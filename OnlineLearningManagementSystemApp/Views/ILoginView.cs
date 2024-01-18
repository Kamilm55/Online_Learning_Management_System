using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLearningManagementSystemApp.Views
{
    public interface ILoginView
    {
        string Email { get; set; }
        string Password { get; set; }
        void ShowMessage(string message);
        void ShowInformation(string message, string caption = "Information");
        void ShowWarning(string message, string caption = "Warning");
        void ShowError(string message, string caption = "Error");
       // Guna2MessageDialog ShowConfirmation(string message, string caption = "Confirmation");
        //bool IsLoggedIn { get; set; }
    }
}

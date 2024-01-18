using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLearningManagementSystemApp.Views
{
    public interface IAuthView
    {
        string Email { get; set; }
        string Password { get; set; }
        void ShowInformation(string message, string caption = "Information");
        void ShowWarning(string message, string caption = "Warning");
        void ShowError(string message, string caption = "Error");
        void ClearTextboxes();
    }
}

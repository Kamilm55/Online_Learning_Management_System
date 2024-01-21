using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLearningManagementSystemApp.Views
{
    public interface ILoginView : IAuthView
    {
        void ShowMessage(string message);
        void Close();
       // Guna2MessageDialog ShowConfirmation(string message, string caption = "Confirmation");
        //bool IsLoggedIn { get; set; }
    }
}

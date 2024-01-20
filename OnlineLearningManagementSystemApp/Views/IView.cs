using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLearningManagementSystemApp.Views
{
    public interface IView
    {
        void ShowInformation(string message, string caption = "Information");
        void ShowWarning(string message, string caption = "Warning");
        void ShowError(string message, string caption = "Error");
    }
}

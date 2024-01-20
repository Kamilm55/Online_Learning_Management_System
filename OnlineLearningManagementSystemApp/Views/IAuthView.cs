using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLearningManagementSystemApp.Views
{
    public interface IAuthView : IView
    {
        string Email { get; set; }
        string Password { get; set; }
        void ClearTextboxes();
    }
}

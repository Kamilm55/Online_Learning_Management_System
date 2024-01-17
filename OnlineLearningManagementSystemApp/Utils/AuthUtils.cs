using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace OnlineLearningManagementSystemApp.Utils
{
    internal class AuthUtils
    {
        public static void PopulateLoginPayload(string email, string password ,string emailInput , string passwordInput)
        {
            emailInput = email;
            passwordInput = password;
        }
    }
}

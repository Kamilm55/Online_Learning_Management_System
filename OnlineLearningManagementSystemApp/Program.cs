using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineLearningManagementSystemApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
             Application.Run(new LoginForm());
            //register
           //  Application.Run(new StudentMainPage(10007));
            // Application.Run(new StudentAssesmentPage(10007));
            //Application.Run(new UserProfile(10007));
            //userCrud

            //Application.Run(new TeacherMainPage(20007));
            //course add
            //course edit
            //logout
        }
    }
}

using System;
using System.Windows.Forms;

namespace OnlineLearningManagementSystemApp.Utils
{
    public static class NavigationUtils
    {
        public static void NavigateToStudentAssessmentPage(Form currentForm, long userId)
        {
            StudentAssesmentPage studentAssesmentPage = new StudentAssesmentPage(userId);
            studentAssesmentPage.Show();
            currentForm.Hide();
        }

        public static void NavigateToStudentMainPage(Form currentForm, long userId)
        {
            StudentMainPage studentMainPage = new StudentMainPage(userId);
            studentMainPage.Show();
            currentForm.Hide();
        }
        public static void NavigateToTeacherMainPage(Form currentForm, long userId)
        {
            TeacherMainPage teacherMainPage = new TeacherMainPage(userId);
            teacherMainPage.Show();
            currentForm.Hide();
        }

        public static void NavigateToUserProfile(Form currentForm, long userId)
        {
            UserProfile userProfilePage = new UserProfile(userId);
            userProfilePage.Show();
            currentForm.Hide();
        }

        public static void Logout(Form currentForm)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            currentForm.Hide();
        }
    }
}

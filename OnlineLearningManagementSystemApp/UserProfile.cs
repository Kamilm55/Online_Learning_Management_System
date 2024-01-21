using OnlineLearningManagementSystemApp.Models;
using OnlineLearningManagementSystemApp.Utils;
using OnlineLearningManagementSystemApp.Views;
using System.Windows.Forms;
using System;

namespace OnlineLearningManagementSystemApp
{
    public partial class UserProfile : Form, IView
    {
        private readonly long userId;
        private readonly IUserRepository userRepository;

        public UserProfile(long userId)
        {
            InitializeComponent();
            this.userId = userId;
            userRepository = new UserRepository();
        }

        private void UserProfile_Load(object sender, EventArgs e)
        {
            LoadUserData();
        }

        private void LoadUserData()
        {
            this.usersTableAdapter.Fill(this.online_learning_management_system_dbDataSet.Users);

            User user = userRepository.GetById(userId);
            if (user.Role.Equals("Teacher"))
                assesmentPageLink.Enabled = false;

            UserPrUsernameLabel.Text = user.Username;
            UserPrEmailLabel.Text = user.Email;
            UserPrPasswordLabel.Text = GetEncryptedPassword(user.Password);
        }

        private string GetEncryptedPassword(string password)
        {
            return new string('*', password.Length);
        }

        private void UserPrEditBtn_Click(object sender, EventArgs e)
        {
            OpenUserCrudForm();
        }

        private void OpenUserCrudForm()
        {
            this.Visible = false;

            using (UserCrud userCrudForm = new UserCrud(userId))
            {
                userCrudForm.FormClosed += UserCrudForm_FormClosed;
                userCrudForm.ShowDialog();
            }
        }

        private void UserCrudForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            User editedUser = ((UserCrud)sender).EditedUser;

            UpdateUserProfile(editedUser);

            this.Visible = true;
        }

        private void UpdateUserProfile(User editedUser)
        {
            UserPrUsernameLabel.Text = editedUser.Username;
            UserPrEmailLabel.Text = editedUser.Email;
            UserPrPasswordLabel.Text = GetEncryptedPassword(editedUser.Password);
        }

        public void ShowInformation(string message, string caption = "Information")
        {
            GunaMessageDialogUtils.PrepareShowInformation(UserMsgDialog, message, caption);
        }

        public void ShowWarning(string message, string caption = "Warning")
        {
            GunaMessageDialogUtils.PrepareShowWarning(UserMsgDialog, message, caption);
        }

        public void ShowError(string message, string caption = "Error")
        {
            GunaMessageDialogUtils.PrepareShowError(UserMsgDialog, message, caption);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            User user = userRepository.GetById(userId);

            if (user.Role.Equals("Teacher"))
                NavigationUtils.NavigateToTeacherMainPage(this,userId);
            else
                NavigationUtils.NavigateToStudentMainPage(this, userId);
        }

        private void assesmentPageLink_Click(object sender, EventArgs e)
        {
            NavigationUtils.NavigateToStudentAssessmentPage(this, userId);
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            NavigationUtils.Logout(this);
        }
    }
}

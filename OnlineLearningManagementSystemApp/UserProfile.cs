using OnlineLearningManagementSystemApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineLearningManagementSystemApp
{
    public partial class UserProfile : Form
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
            // TODO: This line of code loads data into the 'online_learning_management_system_dbDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.online_learning_management_system_dbDataSet.Users);


           User user = userRepository.GetById(this.userId);

            UserPrUsernameLabel.Text = user.Username;
            UserPrEmailLabel.Text = user.Email;

            string pass = user.Password;
            string encyrptedPass = "";

            for (int i = 0; i < pass.Length; i++)
            {
                encyrptedPass += "*";
            }
            UserPrPasswordLabel .Text = encyrptedPass;
        }

        private void UserPrEditBtn_Click(object sender, EventArgs e)
        {
            // Check if the current form is visible
            if (this.Visible)
            {
                // Hide the current form before showing the dialog
                this.Visible = false;

                // Show the dialog
                using (UserCrud userCrudForm = new UserCrud(userId))
                {
                    // Subscribe to the FormClosed event of the dialog
                    userCrudForm.FormClosed += UserCrudForm_FormClosed;

                    userCrudForm.ShowDialog();

                    // Retrieve the edited user from the UserCrudForm after it's closed
                    User editedUser = userCrudForm.EditedUser;
                }
            }
        }

        private void UserCrudForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // This method is called when the dialog is closed

            // Retrieve the edited user from the UserCrudForm
            User editedUser = ((UserCrud)sender).EditedUser;

            

            //Debug.WriteLine(editedUser.Username + " " + user.Email);
            UserPrUsernameLabel.Text = editedUser.Username;
            UserPrEmailLabel.Text = editedUser.Email;

            string pass = editedUser.Password;
            string encyrptedPass = "";

            for (int i = 0; i < pass.Length; i++)
            {
                encyrptedPass += "*";
            }
            UserPrPasswordLabel.Text = encyrptedPass;

            // Show the current form again after the dialog is closed
            this.Visible = true;
        }

    }
}

using OnlineLearningManagementSystemApp.Models;
using OnlineLearningManagementSystemApp.Utils;
using OnlineLearningManagementSystemApp.Views;
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
    public partial class UserCrud : Form ,IView
    {
        private readonly long userId;
        private readonly IUserRepository userRepository;
        // Define a property to expose the User object
        public User EditedUser { get; private set; }


        public UserCrud(long userId)
        {
            InitializeComponent();
            this.userId = userId;
            userRepository = new UserRepository();
        }

        private void UserCrud_Load(object sender, EventArgs e)
        {
            User user = userRepository.GetById(this.userId);

            userCrUsername.Text = user.Username;
            userCrEmail.Text = user.Email;
        }

        private void UserCrSubmitBtn_Click(object sender, EventArgs e)
        {
            //edit user by id
            try
            {
                userRepository.UpdateByUsername(userCrUsername.Text, userId);
                ShowInformation("Successfully updated user details");
                EditedUser = userRepository.GetById(this.userId);
            }
            catch(Exception ex) 
            {
                ShowError(ex.Message);
            }
            
        }

        private void UserCrEmailSubmitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                userRepository.UpdateByEmail(userCrEmail.Text, userId);
                ShowInformation("Successfully updated user details");
                EditedUser = userRepository.GetById(this.userId);
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
           
           
        }
        private void UserCrPasswordSubmitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                userRepository.UpdateByPassword(userCrPassword.Text, userId);
                ShowInformation("Successfully updated user details");
                EditedUser = userRepository.GetById(this.userId);

            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }

        }

       /* private void ClearTextBoxes()
        {
            userCrUsername.Text = "";
            userCrEmail.Text = "";
            userCrPassword.Text = "";
        }*/

        public void ShowInformation(string message, string caption = "Information")
        {
            GunaMessageDialogUtils.PrepareShowInformation(userCrMsgDialog, message, caption);
        }

        public void ShowWarning(string message, string caption = "Warning")
        {
            GunaMessageDialogUtils.PrepareShowWarning(userCrMsgDialog, message, caption);
        }

        public void ShowError(string message, string caption = "Error")
        {
            GunaMessageDialogUtils.PrepareShowError(userCrMsgDialog, message, caption);
        }

        private void UserCrud_Leave(object sender, EventArgs e)
        {
            //
        }
    }
}

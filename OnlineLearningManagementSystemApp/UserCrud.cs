using OnlineLearningManagementSystemApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineLearningManagementSystemApp
{
    public partial class UserCrud : Form
    {
        private readonly long userId;
        private readonly IUserRepository userRepository;

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


        }
    }
}

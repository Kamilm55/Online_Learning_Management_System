using OnlineLearningManagementSystemApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OnlineLearningManagementSystemApp
{
    public partial class Form1 : Form
    {
        private UserRepository userRepository ;
        private String userName;
        private String password;

        public Form1()
        {
            InitializeComponent();
            userRepository = new UserRepository();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            User user = new User(); // Create a new instance of your entity class

            // Assign values from UI controls to the entity properties

            user.Username = "Samir";
            user.Email = "samir@admin";
            user.Password = "kamilAdmin";
            user.Role = "Student";





            try
            {
                //  userRepository.Add(user);
                userRepository.UpdateByEmail("kamil@admin",6);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }

            

           // MessageBox.Show("Data added successfully.");
        }


        private void LoginBtn_Click(object sender, EventArgs e)
        {
            userName = textBox1.Text;
            password = textBox2.Text;

          //  login(userName, password); // inside try-catch make login user

        }
    }
}

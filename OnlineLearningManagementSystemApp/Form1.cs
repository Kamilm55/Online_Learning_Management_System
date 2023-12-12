using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
        private readonly dbEntities dbEntities ; 

        public Form1()
        {
            InitializeComponent();
            dbEntities = new dbEntities(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            User user = new User(); // Create a new instance of your entity class

            // Assign values from UI controls to the entity properties

            user.Username = "Kamil";
            user.Email = "Kamil@admin";
            user.Password = "kamilAdmin";
            user.Role = "Admin";


            // Set other properties as needed

            dbEntities.Users.Add(user); // Add the new entity to the context

            dbEntities.SaveChanges(); // Save changes to commit to the database

            MessageBox.Show("Data added successfully.");
        }
    }
}

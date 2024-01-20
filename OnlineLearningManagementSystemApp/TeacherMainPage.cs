using OnlineLearningManagementSystemApp.Models;
using OnlineLearningManagementSystemApp.Models.Assesment;
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
    public partial class TeacherMainPage : Form
    {
        private readonly IUserRepository userRepository;
        private readonly ICourseRepository courseRepository;
        private readonly long teacherId;

        public TeacherMainPage(long userId)
        {
            InitializeComponent();
            teacherId = userId;
            userRepository = new UserRepository();
            courseRepository = new CourseRepository();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void TeacherMainPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'online_learning_management_system_dbDataSet.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.online_learning_management_system_dbDataSet.Course);
            // TODO: This line of code loads data into the 'online_learning_management_system_dbDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.online_learning_management_system_dbDataSet.Users);
            teacherDataComboBox.SelectedIndex = 0;
        }


        private void teacherDataComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedLabel = teacherDataComboBox.SelectedItem.ToString();

            List<User> users;

            switch (selectedLabel)
            {
                case "My Students":
                    users = userRepository.GetStudentsByInstructorId(teacherId);
                   break;

               
                default:
                    // Handle the default case if needed
                    throw new ArgumentException("Invalid label provided.");
            }
        
            usersBindingSource.DataSource = users;
        }
    }
}

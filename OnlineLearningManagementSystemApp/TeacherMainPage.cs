using OnlineLearningManagementSystemApp.ModelDetails;
using OnlineLearningManagementSystemApp.Models;
using OnlineLearningManagementSystemApp.Models.Assesment;
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

            // My Courses
            courseBindingSource.DataSource = courseRepository.GetCoursesByInstructorId(teacherId);


            List<UserDetails> userDetails = userRepository.GetStudentsWithDetailsByInstructorId(teacherId);
            foreach (var item in userDetails)
            {
                Debug.WriteLine(item.Username);
                Debug.WriteLine(item.CourseTitle);
                Debug.WriteLine(item.EnrollmentDate);
            }
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

        private void studentSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            string filterText = studentSearchTextBox.Text.Trim().ToLower();

           List<User> users = userRepository.GetStudentsByInstructorId(teacherId);

            if (string.IsNullOrWhiteSpace(filterText))
            {
                // If the filter text is empty, show all rows
                usersBindingSource.DataSource = users;
            }
            else
            {
                // Filter users based on the entered text
                var filteredUsers = users.Where(user =>
                    user.UserID.ToString().Contains(filterText) ||
                    user.Username.ToLower().Contains(filterText) ||
                    user.Email.ToLower().Contains(filterText)
                ).ToList();

                // Update the binding source with the filtered users
                usersBindingSource.DataSource = filteredUsers;
            }
        }

        private void LeaveStudentFromCourseButton_Click(object sender, EventArgs e)
        {
           /* if (long.TryParse(LeaveStudentFromCourseButton.Text, out long userId))
            {
                // userId is now the parsed long value

                string courseTitle = GetSelectedCourseTitle(); // Implement this method to get the selected course title

                if (!string.IsNullOrEmpty(courseTitle))
                {
                    try
                    {
                        // Find CourseID by Title
                        long courseId = GetCourseIdByTitle(courseTitle);

                        if (courseId != 0)
                        {
                            // Remove enrollment from the database (or data source)
                            RemoveEnrollmentFromDatabase(userId, courseId);

                            // Update local list or data source
                            UpdateDataSourceAfterLeave(courseId, userId);

                            MessageBox.Show("Successfully left the course.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show($"Course with title '{courseTitle}' not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid user ID. Please enter a valid numeric user ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/

        }

        // Method to find CourseID by Title
        private long GetCourseIdByTitle(string courseTitle)
        {
            // Implement the logic to find the CourseID based on the given title
            // This might involve querying your database or data source
            CourseRepository courseRepository = new CourseRepository(); // You need to create the CourseRepository class
            Course course = courseRepository.GetByTitle(courseTitle);

            return course != null ? course.CourseID : 0;
        }
       

    }
}

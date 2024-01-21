﻿using OnlineLearningManagementSystemApp;
using OnlineLearningManagementSystemApp.Models;
using OnlineLearningManagementSystemApp.Models.Assesment;
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
    public partial class TeacherMainPage : Form , IView
    {
        private readonly IUserRepository userRepository;
        private readonly ICourseRepository courseRepository;
        private readonly IEnrollmentRepository enrollmentRepository;
        private readonly long teacherId;

        public TeacherMainPage(long userId)
        {
            InitializeComponent();
            teacherId = userId;
            userRepository = new UserRepository();
            courseRepository = new CourseRepository();
            enrollmentRepository = new EnrollmentRepository();
        }

        private void TeacherMainPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'online_learning_management_system_dbDataSet.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.online_learning_management_system_dbDataSet.Course);
            teacherDataComboBox.SelectedIndex = 0;

            // My Courses
            courseBindingSource.DataSource = courseRepository.GetCoursesByInstructorId(teacherId);

            List<UserDetails> userDetails = userRepository.GetStudentsWithDetailsByInstructorId(teacherId);
           /* foreach (var item in userDetails)
            {
                Debug.WriteLine(item.Username);
                Debug.WriteLine(item.CourseTitle);
                Debug.WriteLine(item.EnrollmentID);

            }*/
            userDetailsBindingSource.DataSource = userDetails;

            Debug.WriteLine(usersBindingSource.DataSource);
            // Load the EnrollmentID values as the default items in the ComboBox
            LoadEnrollmentIds(userDetails);
        }

        private void LoadEnrollmentIds(List<UserDetails> userDetails)
        {
            // Assuming GetEnrollmentIds is a method in your repository that returns a list of EnrollmentIDs
            List<object> enrollmentIds = new List<object>();

            foreach (var user in userDetails)
            {
                enrollmentIds.Add(user.EnrollmentID);
            }

            // Clear existing items and add the new items
            comboBoxEnrollmentId.Items.Clear();
            comboBoxEnrollmentId.Items.AddRange(enrollmentIds.ToArray()); // No need to convert to an array

            // Set the default selected item (assuming the first item is the default)
            if (comboBoxEnrollmentId.Items.Count > 0)
            {
                comboBoxEnrollmentId.SelectedIndex = 0;
            }
        }

        private void teacherDataComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedLabel = teacherDataComboBox.SelectedItem.ToString();

            List<UserDetails> users;

            switch (selectedLabel)
            {
                case "My Students":
                    users = userRepository.GetStudentsWithDetailsByInstructorId(teacherId);
                   break;

               
                default:
                    // Handle the default case if needed
                    throw new ArgumentException("Invalid label provided.");
            }

            userDetailsBindingSource.DataSource = users;
        }

        private void studentSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            string filterText = studentSearchTextBox.Text.Trim().ToLower();

            List<UserDetails> userDetails = userRepository.GetStudentsWithDetailsByInstructorId(teacherId);

            if (string.IsNullOrWhiteSpace(filterText))
            {
                // If the filter text is empty, show all rows
                userDetailsBindingSource.DataSource = userDetails;
            }
            else
            {
                // Filter users based on the entered text
                var filteredUsers = userDetails.Where(user =>
                    user.UserID.ToString().Contains(filterText) ||
                    user.Username.ToLower().Contains(filterText) ||
                    user.Email.ToLower().Contains(filterText) ||
                    user.CourseTitle.ToLower().Contains(filterText) || // Added filter for CourseTitle
                    user.EnrollmentDate.ToString("yyyy-MM-dd").Contains(filterText) // Added filter for EnrollmentDate
                ).ToList();

                // Update the binding source with the filtered users
                userDetailsBindingSource.DataSource = filteredUsers;
            }
        }

        private void LeaveStudentFromCourseButton_Click(object sender, EventArgs e)
        {
            // Get the selected enrollment ID from the ComboBox
            if (comboBoxEnrollmentId.SelectedItem != null && long.TryParse(comboBoxEnrollmentId.SelectedItem.ToString(), out long enrollmentId))
            {
                try
                {
                    // You need to implement these methods based on your data access layer
                    enrollmentRepository.Delete(enrollmentId); // Remove enrollment from the database

                    List<UserDetails> userDetails = userRepository.GetStudentsWithDetailsByInstructorId(teacherId);


                    userDetailsBindingSource.DataSource = userDetails;
                    //UpdateDataSourceAfterLeave(enrollmentId); // Update local list or data source

                    // Use your custom ShowInformation method for success
                    ShowInformation("Successfully left the course.");
                }
                catch (Exception ex)
                {
                    // Use your custom ShowError method for errors
                    ShowError($"Error: {ex.Message}");
                }
            }
            else
            {
                // Use your custom ShowError method for invalid enrollment ID
                ShowError("Invalid enrollment ID. Please select a valid enrollment ID.");
            }
        }

        //


        private void MyCoursesSearchTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddCourseBtn_Click(object sender, EventArgs e)
        {

        }

        private void EditCourseButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteCourseButton_Click(object sender, EventArgs e)
        {
            long.TryParse(deleteCourseTextBox.Text, out long courseId);

            //
            //butun enrolmentleri sil bununla elaqeli sonra delete ede bilersen 
            courseRepository.Delete(courseId);

            //update course
            courseBindingSource.DataSource = courseRepository.GetByInstructorId(teacherId);
        }
        //

        public void ShowInformation(string message, string caption = "Information")
        {
            GunaMessageDialogUtils.PrepareShowInformation(TeacherMainMessageDialog, message, caption);
        }

        public void ShowWarning(string message, string caption = "Warning")
        {
            GunaMessageDialogUtils.PrepareShowWarning(TeacherMainMessageDialog, message, caption);

        }

        public void ShowError(string message, string caption = "Error")
        {
            GunaMessageDialogUtils.PrepareShowError(TeacherMainMessageDialog, message, caption);

        }

       
    }
}

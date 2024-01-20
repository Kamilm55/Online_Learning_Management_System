using OnlineLearningManagementSystemApp.Business;
using OnlineLearningManagementSystemApp.Models;
using OnlineLearningManagementSystemApp.Views;
using System;
using System.CodeDom;
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
    public partial class StudentMainPage : Form 
    {
        private IStudentBusinessService studentBusinessService;
        //
        long exStudentId = 6;

        public StudentMainPage()
        {
            InitializeComponent();
            studentBusinessService = new StudentBusinessService();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'online_learning_management_system_dbDataSet.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.online_learning_management_system_dbDataSet.Course);

        }

        private void studentDataComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected string from the ComboBox
            string selectedTableType = studentDataComboBox.SelectedItem.ToString();

           
            List<Course> enrolledCourses = studentBusinessService.GetEnrolledCoursesForUser(6);
            List<Course> allCourses = studentBusinessService.GetAllCourses();
            List<Assessment> assessmentofEnrolledCourses = studentBusinessService.GetAssessmentsForEnrolledCourses(6);

            switch (selectedTableType)
            {
                case "All Courses":
                    courseBindingSource.DataSource = allCourses;
                   // courseTableAdapter.Fill(online_learning_management_system_dbDataSet.Course);
                    break;

                case "Enrolled Courses":
                    courseBindingSource.DataSource = enrolledCourses;
                    break;

              /*  case "Assessment of Enrolled Courses":
                    courseBindingSource.DataMember = "Assessment"; // Replace with the actual name of the list or table
                    courseBindingSource.DataSource = assessmentofEnrolledCourses;
                    break;
*/
                default:
                    // Handle default case if necessary
                    break;
            }

            
        }
       
        private void studentSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            string filterText = studentSearchTextBox.Text.Trim();

            // Check if the filter text is empty
            if (string.IsNullOrWhiteSpace(filterText))
            {
                // Clear the filter to show all rows
                courseBindingSource.RemoveFilter();
            }
            else
            {
                // Apply a filter based on the entered text
                // You can customize this filter based on your specific requirements
                string filterExpression = $"Title LIKE '%{filterText}%' OR Description LIKE '%{filterText}%' OR Convert(CourseID, 'System.String') LIKE '%{filterText}%' OR Convert(InstructorID, 'System.String') LIKE '%{filterText}%'";
                courseBindingSource.Filter = filterExpression;
            }
        }

        private void studentEnrollCourseButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Attempt to parse the text in the TextBox to a long
                if (long.TryParse(studentEnrollCourseTextBox.Text, out long courseId))
                {
                    // Use the studentId as needed, e.g., enroll the student in a course
                    studentBusinessService.EnrollCourse(exStudentId, courseId);
                }
                else
                {
                    // Parsing failed, handle the case where the input is not a valid long
                    throw new FormatException("Invalid student ID. Please enter a valid numeric value.");
                }
            }
            catch (FormatException ex)
            {
                // Handle FormatException (invalid numeric input)
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdateEnrolledCourses(exStudentId);
        }

        private void UpdateEnrolledCourses(long userId)
        {
            List<Course> enrolledCourses = studentBusinessService.GetEnrolledCoursesForUser(userId);

            // update data grid view (courseBindingSource)
            courseBindingSource.DataSource = enrolledCourses;
        }

        private void studentUnenrollCourseButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Attempt to parse the text in the TextBox to a long
                if (long.TryParse(studentUnenrollCourseTextBox.Text, out long courseId))
                {
                    // Use the studentId as needed, e.g., unenroll the student from a course
                    studentBusinessService.UnenrollCourse(exStudentId, courseId);
                }
                else
                {
                    // Parsing failed, handle the case where the input is not a valid long
                    throw new FormatException("Invalid course ID. Please enter a valid numeric value.");
                }
            }
            catch (FormatException ex)
            {
                // Handle FormatException (invalid numeric input)
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            UpdateEnrolledCourses(exStudentId);
        }


        //public void ClearTextBoxValue()
    }
}

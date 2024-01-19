using OnlineLearningManagementSystemApp.Business;
using OnlineLearningManagementSystemApp.Models;
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

            Debug.WriteLine(selectedTableType);

            Debug.WriteLine(studentBusinessService.GetEnrolledCoursesForUser(6));

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

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }
    }
}

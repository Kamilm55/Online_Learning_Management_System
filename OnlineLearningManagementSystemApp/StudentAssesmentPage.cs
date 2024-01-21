// StudentAssesmentPage
using OnlineLearningManagementSystemApp.Business;
using OnlineLearningManagementSystemApp.Models;
using OnlineLearningManagementSystemApp.Models.Assesment;
using OnlineLearningManagementSystemApp.Presenters;
using OnlineLearningManagementSystemApp.Utils;
using OnlineLearningManagementSystemApp.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace OnlineLearningManagementSystemApp
{
    public partial class StudentAssesmentPage : Form, IStudentAssessmentView
    {
        private readonly IAssessmentRepository assessmentRepository;
        private readonly long exStudentId ;

        public StudentAssesmentPage( long userId)
        {
            InitializeComponent();
            assessmentRepository = new AssessmentRepository();
            exStudentId = userId ;
        }

        private void StudentAssesmentPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'online_learning_management_system_dbDataSet.Assessment' table. You can move, or remove it, as needed.
            this.assessmentTableAdapter.Fill(this.online_learning_management_system_dbDataSet.Assessment);

            studentDataComboBox.SelectedIndex = 0; // Set the default selection
        }

        private void studentDataComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
          List<Assessment> assessments =  GetAssessmentsForSelectedCourses();

            BindAssessments(assessments);
        }
        private void StAssTExtBox_TextChanged(object sender, EventArgs e)
        {
            string filterText = StAssTExtBox.Text.Trim().ToLower();

            List<Assessment> assessments = GetAssessmentsForSelectedCourses();

            if (string.IsNullOrWhiteSpace(filterText))
            {
                assessmentBindingSource.DataSource = assessments;
            }
            else
            {
                var filteredAssessments = FilterAssessments(assessments, filterText);
                assessmentBindingSource.DataSource = filteredAssessments;
            }
        }

        private List<Assessment> GetAssessmentsForSelectedCourses()
        {
            string selectedLabel = studentDataComboBox.SelectedItem.ToString();

            switch (selectedLabel)
            {
                case "All Assessments":
                    return assessmentRepository.GetAssessmentsForEnrolledCourses(exStudentId);

                case "Graded Assessments":
                    return assessmentRepository.GetGradedAssessmentsForEnrolledCourses(exStudentId);

                case "Non-graded Assessments":
                    return assessmentRepository.GetNonGradedAssessmentsForEnrolledCourses(exStudentId);

                default:
                    // Handle the default case if needed
                    throw new ArgumentException("Invalid label provided.");
            }
        }


        private List<Assessment> FilterAssessments(List<Assessment> assessments, string filterText)
        {
            return assessments.Where(assessment =>
                assessment.Title.ToLower().Contains(filterText) ||
                assessment.AssessmentID.ToString().Contains(filterText) ||
                assessment.CourseID.ToString().Contains(filterText) ||
                assessment.DueDate.ToString("yyyy-MM-dd").Contains(filterText)
            ).ToList();
        }


        public void BindAssessments(List<Assessment> assessments)
        {
            assessmentBindingSource.DataSource = assessments;
        }
        //

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            NavigationUtils.NavigateToStudentMainPage(this, exStudentId);
        }

        private void userProfileLink_Click(object sender, EventArgs e)
        {
            NavigationUtils.NavigateToUserProfile(this,exStudentId);
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            NavigationUtils.Logout(this);
        }
    }
}

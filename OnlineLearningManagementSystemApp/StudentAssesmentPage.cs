// StudentAssesmentPage
using OnlineLearningManagementSystemApp.Models;
using OnlineLearningManagementSystemApp.Models.Assesment;
using OnlineLearningManagementSystemApp.Presenters;
using OnlineLearningManagementSystemApp.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace OnlineLearningManagementSystemApp
{
    public partial class StudentAssesmentPage : Form, IStudentAssessmentView
    {
        private readonly StudentAssessmentPresenter presenter;
        private readonly IAssessmentRepository assessmentRepository;
        //
        private readonly long exStudentId = 6;

        public StudentAssesmentPage()
        {
            InitializeComponent();
            assessmentRepository = new AssessmentRepository();
            presenter = new StudentAssessmentPresenter(this);
        }

        private void StudentAssesmentPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'online_learning_management_system_dbDataSet.Assessment' table. You can move, or remove it, as needed.
            this.assessmentTableAdapter.Fill(this.online_learning_management_system_dbDataSet.Assessment);
            // Assuming you have a combo box for the assessment type
          //  studentDataComboBox.Items.AddRange(new string[] { "All Assessments", "Non-graded Assessments" });
            studentDataComboBox.SelectedIndex = 0; // Set the default selection
        }

        private void studentDataComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedLabel = studentDataComboBox.SelectedItem.ToString();

            List<Assessment> assessments;

            switch (selectedLabel)
            {
                case "All Assessments":
                    assessments = assessmentRepository.GetAssessmentsForEnrolledCourses(exStudentId);
                    break;

                case "Graded Assessments":
                    assessments = assessmentRepository.GetGradedAssessmentsForEnrolledCourses(exStudentId);
                    break;

                case "Non-graded Assessments":
                    assessments = assessmentRepository.GetNonGradedAssessmentsForEnrolledCourses(exStudentId);
                    break;

                default:
                    // Handle the default case if needed
                    throw new ArgumentException("Invalid label provided.");
            }

           
            BindAssessments(assessments);
            //  presenter.LoadAssessments(exStudentId, selectedLabel); // Assuming 6 is the user ID
        }
        private void StAssTExtBox_TextChanged(object sender, EventArgs e)
        {
                string filterText = StAssTExtBox.Text.Trim();

                // Check if the filter text is empty
                if (string.IsNullOrWhiteSpace(filterText))
                {
                    // Clear the filter to show all rows
                    assessmentBindingSource.RemoveFilter();
                }
                else
                {
                    // Apply a filter based on the entered text
                    // Customize this filter based on your specific requirements
                    Debug.WriteLine(filterText);
                    string filterExpression = $"Title LIKE '%{filterText}%' OR Convert(AssessmentID, 'System.String') LIKE '%{filterText}%' OR Convert(CourseID, 'System.String') LIKE '%{filterText}%' OR Convert(DueDate, 'System.String') LIKE '%{filterText}%'";

                assessmentBindingSource.Filter = filterExpression;
                Debug.WriteLine(filterExpression);
                }
            
           
        }


        private void StAssSubmitBtn_Click(object sender, EventArgs e)
        {
            // Handle submit button click event if needed

        }

        public void BindAssessments(List<Assessment> assessments)
        {
            assessmentBindingSource.DataSource = assessments;
        }
    }
}

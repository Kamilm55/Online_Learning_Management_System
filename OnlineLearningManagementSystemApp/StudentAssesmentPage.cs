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
            Debug.WriteLine(selectedLabel);

            List<Assessment> assessments;

            switch (selectedLabel)
            {
                case "All Assessments":
                    assessments = assessmentRepository.GetAssessmentsForEnrolledCourses(exStudentId);
                    break;

                /* case "Graded Assessments":
                     assessments = assessmentRepository.GetAssessmentsForEnrolledCourses(userId)
                         .Where(a => a.Grade != "NOT_GRADED")
                         .ToList();
                     break;*/

                case "Non-graded Assessments":
                    assessments = assessmentRepository.GetNonGradedAssessmentsForEnrolledCourses(exStudentId);
                    break;

                default:
                    // Handle the default case if needed
                    throw new ArgumentException("Invalid label provided.");
            }

            // to update assesments
            foreach (var item in assessments)
            {
                Debug.WriteLine(item.AssessmentID);
                Debug.WriteLine(item.Assessment_User);
                Debug.WriteLine(item.Course);
            }
            BindAssessments(assessments);
            //  presenter.LoadAssessments(exStudentId, selectedLabel); // Assuming 6 is the user ID
        }

        private void StAssTExtBox_TextChanged(object sender, EventArgs e)
        {
            // Handle text changed event if needed
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

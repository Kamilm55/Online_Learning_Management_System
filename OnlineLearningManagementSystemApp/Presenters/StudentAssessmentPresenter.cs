using OnlineLearningManagementSystemApp.Models;
using OnlineLearningManagementSystemApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLearningManagementSystemApp.Presenters
{
    public class StudentAssessmentPresenter
    {
        private readonly IStudentAssessmentView view;
        private readonly IAssessmentRepository assessmentRepository;

        public StudentAssessmentPresenter(IStudentAssessmentView view)
        {
            this.view = view;
            //this.model = model;
        }

        public void LoadAssessments(long userId, string label)
        {

            List<Assessment> assessments;

            switch (label)
            {
                case "All Assessments":
                    assessments = assessmentRepository.GetAssessmentsForEnrolledCourses(userId);
                    break;

               /* case "Graded Assessments":
                    assessments = assessmentRepository.GetAssessmentsForEnrolledCourses(userId)
                        .Where(a => a.Grade != "NOT_GRADED")
                        .ToList();
                    break;*/

                case "Non-graded Assessments":
                    assessments = assessmentRepository.GetNonGradedAssessmentsForEnrolledCourses(userId);                       
                    break;

                default:
                    // Handle the default case if needed
                    throw new ArgumentException("Invalid label provided.");
            }

            view.BindAssessments(assessments);
        }

    }
}

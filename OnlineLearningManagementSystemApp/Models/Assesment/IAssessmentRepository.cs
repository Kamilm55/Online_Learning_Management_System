using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLearningManagementSystemApp.Models
{
    internal interface IAssessmentRepository
    {
        Assessment GetById(long assessmentId);
        List<Assessment> GetByCourseId(long courseId);
        List<Assessment_User> GetByUserId(long userId);
        List<Assessment_User> GetAssessmentsForUserInCourse(long userId, long courseId);
        List<Assessment> GetAll();
        void AddAssessment(Assessment assessment);
        void AddUserToAssessment(long userId, long assessmentId);
        void RemoveUserFromAssessment(long userId, long assessmentId);
        void UpdateAssessmentDueDate(DateTime newDueDate, long assessmentId);
        void UpdateUserGrade(string newGrade, long userId, long assessmentId);
        List<Assessment> GetAssessmentsForEnrolledCourses(long userId);
        List<Assessment> GetNonGradedAssessmentsForEnrolledCourses(long userId);
        List<Assessment> GetGradedAssessmentsForEnrolledCourses(long userId);
    }
}

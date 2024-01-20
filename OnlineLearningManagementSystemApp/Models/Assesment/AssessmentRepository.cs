using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLearningManagementSystemApp.Models.Assesment
{
    internal class AssessmentRepository : IAssessmentRepository
    {
        private readonly dbEntities dbEntities;

        public AssessmentRepository()
        {
            dbEntities = new dbEntities();
        }

        public Assessment GetById(long assessmentId)
        {
            return dbEntities.Assessments.FirstOrDefault(assessment => assessment.AssessmentID == assessmentId);
        }

        public List<Assessment> GetByCourseId(long courseId)
        {
            return dbEntities.Assessments.Where(assessment => assessment.CourseID == courseId).ToList();
        }

        public List<Assessment_User> GetByUserId(long userId)
        {
            return dbEntities.Assessment_User.Where(au => au.UserID == userId).ToList();
        }

        public List<Assessment_User> GetAssessmentsForUserInCourse(long userId, long courseId)
        {
            return dbEntities.Assessment_User
                .Where(au => au.UserID == userId && au.Assessment.CourseID == courseId)
                .ToList();
        }

        public List<Assessment> GetAll()
        {
            return dbEntities.Assessments.ToList();
        }

        public void AddAssessment(Assessment assessment)
        {
            dbEntities.Assessments.Add(assessment);
            dbEntities.SaveChanges();
        }

        public void AddUserToAssessment(long userId, long assessmentId)
        {
            var assessmentUser = new Assessment_User
            {
                UserID = userId,
                AssessmentID = assessmentId,
                Grade = "NOT_GRADED"
            };

            dbEntities.Assessment_User.Add(assessmentUser);
            dbEntities.SaveChanges();
        }

        public void RemoveUserFromAssessment(long userId, long assessmentId)
        {
            Assessment_User assessmentUser = dbEntities.Assessment_User
                .FirstOrDefault(au => au.UserID == userId && au.AssessmentID == assessmentId);

            if (assessmentUser != null)
            {
                dbEntities.Assessment_User.Remove(assessmentUser);
                dbEntities.SaveChanges();
            }
            else
            {
                throw new InvalidOperationException("User not found in the specified assessment.");
            }
        }

        public void UpdateAssessmentDueDate(DateTime newDueDate, long assessmentId)
        {
            Assessment assessment = GetById(assessmentId);

            if (assessment != null)
            {
                assessment.DueDate = newDueDate;
                dbEntities.SaveChanges();
            }
            else
            {
                throw new InvalidOperationException("Assessment not found.");
            }
        }

        public void UpdateUserGrade(string newGrade, long userId, long assessmentId)
        {
            Assessment_User assessmentUser = dbEntities.Assessment_User
                .FirstOrDefault(au => au.UserID == userId && au.AssessmentID == assessmentId);

            if (assessmentUser != null)
            {
                assessmentUser.Grade = newGrade;
                dbEntities.SaveChanges();
            }
            else
            {
                throw new InvalidOperationException("User not found in the specified assessment.");
            }
        }

        /*  public List<Assessment> GetAssessmentsForEnrolledCourses(long userId)
          {
              var assessments = (from enrollment in dbEntities.Enrollments
                                 join course in dbEntities.Courses on enrollment.CourseID equals course.CourseID
                                 join assessment in dbEntities.Assessments on course.CourseID equals assessment.CourseID
                                 where enrollment.StudentID == userId
                                 select assessment).ToList();

              return assessments;
          }*/
        public List<Assessment> GetAssessmentsForEnrolledCourses(long userId)
        {
            var assessments = dbEntities.Assessment_User
                .Where(au => au.UserID == userId/* && au.Grade == "NOT_GRADED"*/)
                .Select(au => au.Assessment)
                .Distinct()
                .ToList();

            return assessments;
        }

        public List<Assessment> GetNonGradedAssessmentsForEnrolledCourses(long userId)
        {
            var nonGradedAssessments = dbEntities.Assessment_User
                .Where(au => au.UserID == userId && au.Grade == "NOT_GRADED")
                .Select(au => au.Assessment)
                .Distinct()
                .ToList();

            return nonGradedAssessments;
        }

        public List<Assessment> GetGradedAssessmentsForEnrolledCourses(long userId)
        {
            var gradedAssessments = dbEntities.Assessment_User
                .Where(au => au.UserID == userId && au.Grade != "NOT_GRADED")
                .Select(au => au.Assessment)
                .Distinct()
                .ToList();

            return gradedAssessments;
        }

    }
}

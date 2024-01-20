using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLearningManagementSystemApp.Models
{
    internal class EnrollmentRepository : IEnrollmentRepository
    {
        private readonly dbEntities dbEntities;

        public EnrollmentRepository()
        {
            dbEntities = new dbEntities();
        }

        public Enrollment GetById(long enrollmentId)
        {
            return dbEntities.Enrollments.FirstOrDefault(enrollment => enrollment.EnrollmentID == enrollmentId);
        }

        public List<Enrollment> GetByStudentId(long studentId)
        {
            return dbEntities.Enrollments.Where(enrollment => enrollment.StudentID == studentId).ToList();
        }

        public List<Enrollment> GetByCourseId(long courseId)
        {
            return dbEntities.Enrollments.Where(enrollment => enrollment.CourseID == courseId).ToList();
        }

        public List<Enrollment> GetAll()
        {
            return dbEntities.Enrollments.ToList();
        }

        public void Add(Enrollment enrollment)
        {
            dbEntities.Enrollments.Add(enrollment);
            dbEntities.SaveChanges();
        }

        public void Delete(long enrollmentId)
        {
            Enrollment enrollment = GetById(enrollmentId);
            if (enrollment != null)
            {
                dbEntities.Enrollments.Remove(enrollment);
                dbEntities.SaveChanges();
            }
            else
            {
                throw new InvalidOperationException("Enrollment not found.");
            }
        }
        public void Delete(long userId, long courseId)
        {
            // Assuming you have a method to get enrollment by user and course IDs
            Enrollment enrollment = GetByUserIdAndCourseId(userId, courseId);

            if (enrollment != null)
            {
                dbEntities.Enrollments.Remove(enrollment);
                dbEntities.SaveChanges();
            }
            else
            {
                throw new InvalidOperationException("Enrollment not found.");
            }
        }

        // Helper method to get enrollment by user and course IDs
        private Enrollment GetByUserIdAndCourseId(long userId, long courseId)
        {
            return dbEntities.Enrollments.FirstOrDefault(enrollment => enrollment.StudentID == userId && enrollment.CourseID == courseId);
        }

        public void UpdateEnrollmentDate(DateTime newEnrollmentDate, long enrollmentId)
        {
            Enrollment enrollment = GetById(enrollmentId);
            if (enrollment != null)
            {
                enrollment.EnrollmentDate = newEnrollmentDate;
                dbEntities.SaveChanges();
            }
            else
            {
                throw new InvalidOperationException("Enrollment not found.");
            }
        }
    }
}

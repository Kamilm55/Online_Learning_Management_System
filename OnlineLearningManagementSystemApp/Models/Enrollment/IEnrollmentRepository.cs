using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLearningManagementSystemApp.Models
{
    internal interface IEnrollmentRepository
    {
        Enrollment GetById(long enrollmentId);
        List<Enrollment> GetByStudentId(long studentId);
        List<Enrollment> GetByCourseId(long courseId);
        List<Enrollment> GetAll();
        void Add(Enrollment enrollment);
        void Delete(long enrollmentId);
        void Delete(long userId, long courseId);
        void UpdateEnrollmentDate(DateTime newEnrollmentDate, long enrollmentId);
    }
}

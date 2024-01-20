using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLearningManagementSystemApp.Business
{
    public interface IStudentBusinessService
    {
        List<Course> GetEnrolledCoursesForUser(long userId);
        List<Course> GetAllCourses();
        void EnrollCourse(long studentId , long CourseID);
        void UnenrollCourse(long studentId, long courseId);

        List<Assessment> GetAssessmentsForEnrolledCourses(long userId);

    }
}

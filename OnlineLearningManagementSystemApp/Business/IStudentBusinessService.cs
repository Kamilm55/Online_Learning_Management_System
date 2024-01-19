using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLearningManagementSystemApp.Business
{
    internal interface IStudentBusinessService
    {
        List<Course> GetEnrolledCoursesForUser(long userId);
        List<Course> GetAllCourses();
        List<Assessment> GetAssessmentsForEnrolledCourses(long userId);

    }
}

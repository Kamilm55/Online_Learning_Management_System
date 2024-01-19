using OnlineLearningManagementSystemApp.Models;
using OnlineLearningManagementSystemApp.Models.Assesment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLearningManagementSystemApp.Business
{
    public class StudentBusinessService : IStudentBusinessService
    {
        private readonly IUserRepository userRepository;
        private readonly IEnrollmentRepository enrollmentRepository;
        private readonly ICourseRepository courseRepository;
        private readonly IAssessmentRepository assessmentRepository;
        private readonly IAssessmentUserRepository assessmentUserRepository;

        public StudentBusinessService()
        {
            userRepository = new UserRepository();
            enrollmentRepository = new EnrollmentRepository();
            courseRepository = new CourseRepository();
            assessmentRepository = new AssessmentRepository();
            assessmentUserRepository = new AssessmentUserRepository();
        }

        public List<Assessment> GetAssessmentsForEnrolledCourses(long userId)
        {
            return assessmentRepository.GetAssessmentsForEnrolledCourses(userId);
        }

        public List<Course> GetEnrolledCoursesForUser(long userId)
        {
            return courseRepository.GetEnrolledCoursesForUser(userId);
        }

        List<Course> IStudentBusinessService.GetAllCourses()
        {
            return courseRepository.GetAll();
        }
    }
}

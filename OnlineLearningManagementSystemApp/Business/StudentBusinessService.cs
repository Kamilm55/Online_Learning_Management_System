using OnlineLearningManagementSystemApp.Models;
using OnlineLearningManagementSystemApp.Models.Assesment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public void EnrollCourse(long studentId, long courseId)
        {
            try
            {
                // Check if the course with the given ID exists
                Course course = courseRepository.GetById(courseId);

                if (course != null)
                {
                    // Check if the student is already enrolled in the specified course
                    List<Enrollment> existingEnrollments = enrollmentRepository.GetByStudentId(studentId);
                    if (existingEnrollments.Any(e => e.CourseID == courseId))
                    {
                        // The student is already enrolled in the course
                        throw new InvalidOperationException("Student is already enrolled in the specified course.");
                    }

                    // Create a new Enrollment
                    Enrollment newEnrollment = new Enrollment
                    {
                        StudentID = studentId,
                        CourseID = courseId,
                        EnrollmentDate = DateTime.Now
                        // You can modify this based on your requirements
                    };

                    // Add the new enrollment
                    enrollmentRepository.Add(newEnrollment);

                    // Show successful operation messagebox or perform other actions
                    MessageBox.Show("Enrollment successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // The specified course doesn't exist
                    MessageBox.Show("Invalid course ID. Please enter a valid course ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (InvalidOperationException ex)
            {
                // Handle the specific exception for already enrolled students
                MessageBox.Show($"Error: {ex.Message}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UnenrollCourse(long studentId, long courseId)
        {
            try
            {
                // Check if the student is enrolled in the specified course
                List<Enrollment> existingEnrollments = enrollmentRepository.GetByStudentId(studentId);
                Enrollment enrollmentToRemove = existingEnrollments.FirstOrDefault(e => e.CourseID == courseId);

                if (enrollmentToRemove != null)
                {
                    // Remove the enrollment
                    enrollmentRepository.Delete(studentId,courseId);

                    // Show successful operation messagebox or perform other actions
                    MessageBox.Show("Unenrollment successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    // The student is not enrolled in the specified course
                    MessageBox.Show("Student is not enrolled in the specified course.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        List<Course> IStudentBusinessService.GetAllCourses()
        {
            return courseRepository.GetAll();
        }
    }
}

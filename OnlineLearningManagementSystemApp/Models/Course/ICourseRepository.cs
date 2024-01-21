using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLearningManagementSystemApp.Models
{
    public interface ICourseRepository
    {
        Course GetById(long courseId);
        Course GetByTitle(string title);
        Course GetByInstructorId(long instructorId);
        List<Course> GetAll();
        void Add(Course course);
        void Delete(long courseId);
        void UpdateTitle(string newTitle, long courseId);
        void UpdateDescription(string newDescription, long courseId);
        void UpdateInstructorId(long newInstructorId, long courseId);
        List<Course> GetEnrolledCoursesForUser(long userId);
        List<Course> GetCoursesByInstructorId(long instructorId);
        List<long> GetCourseIdsByInstructorId(long instructorId);
    }
}

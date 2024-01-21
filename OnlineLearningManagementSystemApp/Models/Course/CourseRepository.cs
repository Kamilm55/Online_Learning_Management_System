using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLearningManagementSystemApp.Models
{
    internal class CourseRepository : ICourseRepository
    {
        private readonly dbEntities dbEntities;

        public CourseRepository()
        {
            dbEntities = new dbEntities();
        }

        public Course GetById(long courseId)
        {
            return dbEntities.Courses.FirstOrDefault(course => course.CourseID == courseId);
        }

        public Course GetByTitle(string title)//it must be unique
        {
            return dbEntities.Courses.FirstOrDefault(course => course.Title == title);
        }

        public Course GetByInstructorId(long instructorId)
        {
            return dbEntities.Courses.FirstOrDefault(course => course.InstructorID == instructorId);
        }

        public List<Course> GetAll()
        {
            return dbEntities.Courses.ToList();
        }

        public void Add(Course course)
        {
            dbEntities.Courses.Add(course);
            dbEntities.SaveChanges();
        }

        public void Delete(long courseId)
        {
            Course course = GetById(courseId);
            if (course != null)
            {
                dbEntities.Courses.Remove(course);
                dbEntities.SaveChanges();
            }
            else
            {
                throw new InvalidOperationException("Course not found.");
            }
        }

        public void UpdateTitle(string newTitle, long courseId)
        {
            Course course = GetById(courseId);
            if (course != null)
            {
                course.Title = newTitle;
                dbEntities.SaveChanges();
            }
            else
            {
                throw new InvalidOperationException("Course not found.");
            }
        }

        public void UpdateDescription(string newDescription, long courseId)
        {
            Course course = GetById(courseId);
            if (course != null)
            {
                course.Description = newDescription;
                dbEntities.SaveChanges();
            }
            else
            {
                throw new InvalidOperationException("Course not found.");
            }
        }

        public void UpdateInstructorId(long newInstructorId, long courseId)
        {
            Course course = GetById(courseId);
            if (course != null)
            {
                course.InstructorID = newInstructorId;
                dbEntities.SaveChanges();
            }
            else
            {
                throw new InvalidOperationException("Course not found.");
            }
        }

        public List<Course> GetEnrolledCoursesForUser(long userId)
        {
            var courses = (from enrollment in dbEntities.Enrollments
                           join course in dbEntities.Courses on enrollment.CourseID equals course.CourseID
                           where enrollment.StudentID == userId
                           select course).ToList();

            return courses;
        }


        public List<Course> GetCoursesByInstructorId(long instructorId)
        {
            var courses = dbEntities.Courses
                                   .Where(course => course.InstructorID == instructorId)
                                   .ToList();

            return courses;
        }

        public List<long> GetCourseIdsByInstructorId(long instructorId)
        {
            // Assuming GetCoursesByInstructorId returns a list of Course objects
            var courses = GetCoursesByInstructorId(instructorId);

            // Extract course IDs from the list of Course objects
            List<long> courseIds = courses.Select(course => course.CourseID).ToList();

            return courseIds;
        }
    }
}

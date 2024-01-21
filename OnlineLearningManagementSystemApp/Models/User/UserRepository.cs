using OnlineLearningManagementSystemApp;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineLearningManagementSystemApp.Models
{
    public class UserRepository : IUserRepository
    {
        private readonly dbEntities dbEntities ;
        public UserRepository() 
        {
            dbEntities = new dbEntities(); 
        }

        public User GetById(long id)
        {
            return dbEntities.Users.FirstOrDefault(user => user.UserID.Equals(id));
        }
        public User GetByUserName(string userName)
        { 
            return dbEntities.Users.FirstOrDefault(user => user.Username.Equals(userName));
        }
        public User GetByEmail(string email)
        { 
            return dbEntities.Users.FirstOrDefault(user => user.Email.Equals(email));
        }

        public bool Add(User user) 
        {
            if (GetByEmail(user.Email) != null)
            {
                throw new InvalidOperationException("This email is in-use , please change your email");
            }
            else if(GetByUserName(user.Username) != null)
            {
                throw new InvalidOperationException("This username is in-use , please change your username");
            }
            dbEntities.Users.Add(user); // Add the new entity to the context

            dbEntities.SaveChanges(); // Save changes to commit to the database
            return true;
        }

        public void Delete(long userId)
        {

            if (GetById(userId) != null)
            {
                dbEntities.Users.Remove(GetById(userId));
            }
            else 
            {
                throw new InvalidOperationException("There is no user with this id");
            }
           
        }

        public List<User> GetAll()
        {
            return dbEntities.Users.ToList();
        }

        public void UpdateByEmail(string newEmail,long userId)
        {
            User user = GetById(userId);

            if (GetByEmail(newEmail) != null)
            {
                throw new InvalidOperationException("This email is in-use , please change your email");
            }
            user.Email = newEmail;
           dbEntities.SaveChanges();
        }

        public void UpdateByUsername(string newUsername, long userId)
        {
            User user = GetById(userId);
            if (GetByUserName(newUsername) != null)
            {
                throw new InvalidOperationException("This username is in-use , please change your username");
            }
            user.Username = newUsername;
            dbEntities.SaveChanges();
        }

    
        public void UpdateByRole(string newRole, long userId)
        {
            User user = GetById(userId);
            if (user != null)
            {
               
                if (newRole == "Student" || newRole == "Instructor" || newRole == "Admin")
                {
                    user.Role = newRole;
                    dbEntities.SaveChanges();
                }
                else
                {
                    throw new InvalidOperationException("Invalid role. Role must be 'Student', 'Instructor', or 'Admin'.");
                }
            }
            else
            {
                throw new InvalidOperationException("User not found.");
            }
        }

        public void UpdateByPassword(string newPassword, long userId)
        {
            User user = GetById(userId);
            if (user != null)
            {
                // Hash password then add to db
                // Validate the new password (you can customize this validation logic as needed)
                user.Password = newPassword;
                dbEntities.SaveChanges();
            }
            else
            {
                throw new InvalidOperationException("User not found.");
            }
        }

        public void UpdateByPhoto(string newPhoto, long userId)
        {
            // Placeholder implementation for updating the user's photo
            // You may want to implement actual logic for handling user photos
            throw new NotImplementedException();
        }

        public void Update(User updatedUser)
        {
            User user = GetById(updatedUser.UserID);
            if (user != null)
            {
                user.Username = updatedUser.Username;
                user.Email = updatedUser.Email;
                user.Password = updatedUser.Password;
                user.Role = updatedUser.Role;
            // user photo

                dbEntities.SaveChanges();
            }
            else
            {
                throw new InvalidOperationException("User not found.");
            }
        }

        public List<User> GetStudentsByInstructorId(long instructorId)
        {
            var students = dbEntities.Users
                .Join(dbEntities.Enrollments,
                      user => user.UserID,
                      enrollment => enrollment.StudentID,
                      (user, enrollment) => new { user, enrollment })
                .Join(dbEntities.Courses,
                      combined => combined.enrollment.CourseID,
                      course => course.CourseID,
                      (combined, course) => new { combined.user, combined.enrollment, course })
                .Where(result => result.course.InstructorID == instructorId)
                .Select(result => result.user)
                //.Distinct()
                .ToList();

            return students;
        }



        public List<UserDetails> GetStudentsWithDetailsByInstructorId(long instructorId)
        {
            var students = dbEntities.Users
                .Join(dbEntities.Enrollments,
                      user => user.UserID,
                      enrollment => enrollment.StudentID,
                      (user, enrollment) => new { user, enrollment })
                .Join(dbEntities.Courses,
                      combined => combined.enrollment.CourseID,
                      course => course.CourseID,
                      (combined, course) => new { combined.user, combined.enrollment, course })
                .Where(result => result.course.InstructorID == instructorId)
                .Select(result => new UserDetails
                {
                    UserID = result.user.UserID,
                    Username = result.user.Username,
                    Email = result.user.Email,
                    EnrollmentID = result.enrollment.EnrollmentID, // Include EnrollmentID
                    EnrollmentDate = result.enrollment.EnrollmentDate,
                    CourseTitle = result.course.Title
                })
                .ToList();

            return students;
        }

    }
}

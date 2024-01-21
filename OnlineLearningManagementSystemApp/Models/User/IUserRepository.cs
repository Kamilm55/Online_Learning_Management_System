using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLearningManagementSystemApp
    {
        public interface IUserRepository
        {
            User GetById(long id);
            User GetByUserName(string userName);
            User GetByEmail(string email);
            bool Add(User user);
            void Delete(long userId);
           // void Update(User user);
            List<User> GetAll();
            void UpdateByUsername(string newUsername, long userId);
            void UpdateByRole(string newRole, long userId);
            void UpdateByEmail(string newEmail,long userId);
            void UpdateByPassword(string newPassword, long userId);
            void UpdateByPhoto(string newPhoto, long userId);
            List<User> GetStudentsByInstructorId(long instructorId);
           List<UserDetails> GetStudentsWithDetailsByInstructorId(long instructorId);
    }
    }

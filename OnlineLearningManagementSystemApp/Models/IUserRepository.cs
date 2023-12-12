using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLearningManagementSystemApp.Models
{
    internal interface IUserRepository
    {
        User GetById(long id);
        User GetByUserName(string userName);
        User GetByEmail(string email);
        void Add(User user);
        void Delete(long userId);
       // void Update(User user);
        List<User> GetAll();
        void UpdateByUsername(string newUsername, User user);
        void UpdateByRole(string newRole, User user);
        void UpdateByEmail(string newEmail, User user);
        void UpdateByPassword(string newPassword, User user);
        void UpdateByPhoto(string newPhoto, User user);
    }
}

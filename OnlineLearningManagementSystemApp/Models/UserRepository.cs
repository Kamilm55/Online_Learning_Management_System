using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace OnlineLearningManagementSystemApp.Models
{
    internal class UserRepository : IUserRepository
    {
        private readonly dbEntities dbEntities ;
        public UserRepository() 
        {
            dbEntities = new dbEntities(); 
        }

        public User GetById(long id)
        {
            return dbEntities.Users.FirstOrDefault(user => user.UserID== id);
        }
        public User GetByUserName(string userName)
        { 
            return dbEntities.Users.FirstOrDefault(user => user.Username == userName);
        }
        public User GetByEmail(string email)
        {
            return dbEntities.Users.FirstOrDefault(user => user.Email == email);
        }

        public void Add(User user) 
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

        public void UpdateByEmail(string newEmail , User user)
        {
            if (GetByEmail(newEmail) != null)
            {
                throw new InvalidOperationException("This email is in-use , please change your email");
            }
            user.Email = newEmail;
           dbEntities.SaveChanges();
        }

        public void UpdateByUsername(string newUsername, User user)
        {
            if (GetByUserName(newUsername) != null)
            {
                throw new InvalidOperationException("This username is in-use , please change your email");
            }
            user.Email = newUsername;
            dbEntities.SaveChanges();
        }

        public void UpdateByRole(string newRole, User user)
        {
            throw new NotImplementedException();
        }

        public void UpdateByPassword(string newPassword, User user)
        {
            throw new NotImplementedException();
        }

        public void UpdateByPhoto(string newPhoto, User user)
        {
            throw new NotImplementedException();
        }
        //
        public void Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}

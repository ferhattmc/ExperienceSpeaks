using System.Collections.Generic;
using ExperienceSpeaks.Models;

namespace ExperienceSpeaks.Data
{
    public class MockExperienceSpeaksRepo : IExperienceSpeaksRepo
    {
        public void CreateUser(User user)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteUser(User user)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<User> GetAllUsers()
        {
            var users = new List<User>
            {
                new User { Id = 0, Name = "Ferhat", Surname = "Tamcı" },
                new User { Id = 1, Name = "Canbike", Surname = "Tamcı" },
                new User { Id = 2, Name = "Hebele", Surname = "Tamcı" }
            };
            return users;
        }

        public User GetUserById(int id)
        {
            return new User { Id = 0, Name = "Ferhat", Surname = "Tamcı" };
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateUser(User user)
        {
            throw new System.NotImplementedException();
        }
    }
}
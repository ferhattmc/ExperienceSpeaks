using System.Collections.Generic;
using ExperienceSpeaks.Models;

namespace ExperienceSpeaks.Data
{
    public interface IExperienceSpeaksRepo
    {
        bool SaveChanges();
        IEnumerable<User> GetAllUsers();
        User GetUserById(int id);

        void CreateUser(User user);

        void UpdateUser(User user);

        void DeleteUser(User user);
    }
}
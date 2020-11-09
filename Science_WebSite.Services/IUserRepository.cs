using System;
using System.Collections.Generic;
using System.Text;
using Science_WebSite.Models;
using System.Threading.Tasks;

namespace Science_WebSite.Services
{
    public interface IUserRepository
    {
        public IEnumerable<User> GetAllUsers();
        public void AddUser(User user);
        public User GetUser(string email, string password);
        public User GetUserByID(int id);

        public bool IsMember(string email, string password);
    }
}

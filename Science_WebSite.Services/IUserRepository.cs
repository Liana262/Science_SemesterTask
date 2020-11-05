using System;
using System.Collections.Generic;
using System.Text;
using Science_WebSite.Models;
using System.Threading.Tasks;

namespace Science_WebSite.Services
{
    public interface IUserRepository
    {
        //IEnumerable<User> GetAllUsers();
        ////IEnumerable<Article> GetAllArticles();

        //User GetUser(int id);
        Task AddUser(User user);
        Task<User> GetUser(string email, string password);
    }
}

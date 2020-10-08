using System;
using System.Collections.Generic;
using System.Text;
using Science_WebSite.Models;

namespace Science_WebSite.Services
{
    public interface IRepository
    {
        IEnumerable<User> GetAllUsers();
    }
}

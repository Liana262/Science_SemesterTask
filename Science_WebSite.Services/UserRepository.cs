using Science_WebSite.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Science_WebSite.Services
{
    public class UserRepository : IRepository
    {
        private List<User> _userList;
        public UserRepository()
        {
            _userList = new List<User>()
            {
                new User()
                {
                   ID = 0, Name ="lena", LastName="kataeva", Email="lenkataeva@gmail.com", Login="leno4ka", Password="postgressql" 
                },
                new User()
                {
                   ID = 1, Name ="adilia", LastName="ebobo", Email="ebobolia@gmail.com", Login="ebkaka", Password="molly"
                },
                new User()
                {
                   ID = 2, Name ="Ropa", LastName="Olegovich", Email="Ropapa@gmail.com", Login="RopaRopa", Password="finikiEtoVkusno"
                },
                new User()
                {
                   ID = 3, Name ="Idi", LastName="Nahuy", Email="Vonyaesh@gmail.com", Login="Auf", Password="Blyat"
                }
            };

        }
        IEnumerable<User> IRepository.GetAllUsers()
        {
            return _userList;
        }
    }
}

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
        private List<Article> _articleList;
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

            _articleList = new List<Article>()
            {
                new Article()
                {
                    ID = 0, Title = "Планеты", Description= "Почему Уран вращается на боку?",  PhotoPath=""
                },
                new Article()
                {
                    ID = 1, Title = "Звезды", Description= "Что мы знаем о квазарах?",  PhotoPath=""
                },
                new Article()
                {
                    ID = 2, Title = "Астероиды", Description= "Состав астероидного вещества",  PhotoPath=""
                },
                new Article()
                {
                    ID = 3, Title = "Вселенная", Description= "Было ли начало у Вселенной?",  PhotoPath=""
                },
                new Article()
                {
                   // ID = 4, Title = "Черные дыры", Description= "Что такое черная дыра?",  PhotoPath=""
                }
            };
        }
        IEnumerable<User> IRepository.GetAllUsers()
        {
            return _userList;
        }

        IEnumerable<Article> IRepository.GetAllArticles()
        {
            return _articleList;
        }

        public Article GetArticle(int id)
        {
            return _articleList.FirstOrDefault(x => x.ID == id);
        }
    }
}

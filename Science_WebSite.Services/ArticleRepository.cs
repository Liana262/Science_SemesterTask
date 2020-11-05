using Science_WebSite.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Science_WebSite.Services
{
    public class ArticleRepository : IArticleRepository
    {
        
        private List<Article> _articleList;
        public ArticleRepository()
        {
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
                    ID = 4, Title = "Черные дыры", Description= "Что такое черная дыра?",  PhotoPath=""
                }
            };
        }

        IEnumerable<Article> IArticleRepository.GetAllArticles()
        {
            return _articleList;
        }

        public Article GetArticle(int id)
        {
            return _articleList.FirstOrDefault(x => x.ID == id);
        }
    }
}

using Science_WebSite.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;
using Dapper;
using System.Linq;
using Science_WebSite.Models;

namespace Science_WebSite.Services
{
    public class ArticleRepository : IArticleRepository
    {
        private string connectionString = "User ID=postgres; Password=postgres; Server=127.0.0.1; Port=5433; Database=Science_db";

        //private List<Article> _articleList;
        //public ArticleRepository()
        //{
        //    _articleList = new List<Article>()
        //    {
        //        new Article()
        //        {
        //            ID = 0, Title = "Планеты", Description= "Почему Уран вращается на боку?",  PhotoPath=""
        //        },
        //        new Article()
        //        {
        //            ID = 1, Title = "Звезды", Description= "Что мы знаем о квазарах?",  PhotoPath=""
        //        },
        //        new Article()
        //        {
        //            ID = 2, Title = "Астероиды", Description= "Состав астероидного вещества",  PhotoPath=""
        //        },
        //        new Article()
        //        {
        //            ID = 3, Title = "Вселенная", Description= "Было ли начало у Вселенной?",  PhotoPath=""
        //        },
        //        new Article()
        //        {
        //            ID = 4, Title = "Черные дыры", Description= "Что такое черная дыра?",  PhotoPath=""
        //        }
        //    };
        //}

        //IEnumerable<Article> IArticleRepository.GetAllArticles()
        //{
        //    return _articleList;
        //}

        public void Insert()
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                NpgsqlCommand command_1 = new NpgsqlCommand("INSERT INTO Article( title, description, photoPath) VALUES('Планеты','Почему Уран вращается на боку?' , '~/upload/portfolio/newsingle1.jpg'), " +
                    "('Звезды','Квазары и что мы о них знаем' , '~/upload/portfolio/newsingle2.jpg')," +
                    "('Астероиды','Состав астероидного вещества' , '~/upload/portfolio/newsingle3.jpg')," +
                    "('Вселенная','Было ли начало у вселенной' , '~/upload/portfolio/newsingle4.jpg')," +
                    "('Черные дыры','Что такое черная дыра?' , '~/upload/portfolio/newsingle5.jpg')", connection);
                var command_2 = new NpgsqlCommand("Delete from Article", connection);
                command_1.ExecuteNonQuery();
            }
        }
        public Article GetArticle(string title)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand($"SELECT id, title, description, photoPath FROM Article WHERE title = '{title}'", connection);
                var article = connection.QueryFirstOrDefault<Article>(
                    command.CommandText, new { Title = title}) ?? new Article();
                return article;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Science_WebSite.Models;

namespace Science_WebSite.Services
{
    public interface IArticleRepository
    {
        public void Insert();
        Article GetArticle(string title);
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Science_WebSite.Models;
using Science_WebSite;

namespace Science_WebSite.Services
{
    public interface IMessageRepository
    {
        public void AddMessage(string message, int userId, int articleId);
    }
}

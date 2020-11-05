using System;
using System.Collections.Generic;
using System.Text;

namespace Science_WebSite.Models
{
    public class Message
    {
        public int Id { get; set; }

        public string TextMessage { get; set; }

        public int UserId { get; set; }
    }
}

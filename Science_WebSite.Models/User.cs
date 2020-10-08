using System;
using System.Collections.Generic;
using System.Text;

namespace Science_WebSite.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}

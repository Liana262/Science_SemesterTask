using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Science_WebSite.Models;
using Science_WebSite.Services;

namespace Science_WebSite.Pages.User
{
    public class PrivateAccModel : PageModel
    {
        private readonly IUserRepository _repository;
        public Models.User user { get; set; }
        public PrivateAccModel(IUserRepository repository)
        {
            _repository = repository;
        }
        public void OnGet()
        {
            //string key = HttpContext.Request.Cookies["key"];
            //int id = int.Parse(key);
            //user = _repository.GetUserByID(id);
        }
    }
}

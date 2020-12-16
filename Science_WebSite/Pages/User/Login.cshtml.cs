using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Science_WebSite.Models;
using Science_WebSite.Services;
using Microsoft.AspNetCore.Http;

namespace Science_WebSite.Pages
{
    public class LoginModel : PageModel
    {
        public string Message { get; set; }
        private readonly IUserRepository _repository;
        public IEnumerable<Models.User> Users { get; set; }
        public LoginModel(IUserRepository repository)
        {
            _repository = repository;
        }
        public void OnGet()
        {
            Message = "Вход";
        }

        public IActionResult OnPost()
        { 
            string email = HttpContext.Request.Form["email"];
            string password = HttpContext.Request.Form["password"];
            var isMember = _repository.IsMember(email, password) ;
            // _repository.IsMember(user);
            if (isMember) 
            {
                var user = _repository.GetUser(email, password);
                string key = user.ID.ToString();
                
                HttpContext.Session.SetString("user_id", key);
                SetCookie(key);
                return RedirectToPage("/User/PrivateAcc");
            }
            //Message = "Неверный адрес электронной почты или пароль!";
            return RedirectToPage("/User/Login");
                  
        }
        private void SetCookie(string key)
        {
            HttpContext.Response.Cookies.Append("key", key);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Science_WebSite.Models;
using Science_WebSite.Services;
using Microsoft.AspNetCore.Http;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;

namespace Science_WebSite.Pages
{
    public class RegistrationModel : PageModel
    {
        public string Message {get; set;}
        private readonly IUserRepository _repository;
        public Models.User user { get; set; }
        public IEnumerable<Models.User> Users { get; set; }
        public RegistrationModel(IUserRepository repository)
        {
            _repository = repository;
        }

        
        public void OnGet()
        {
            Message = "¬ведите данные дл€ регистрации";
        }

        public IActionResult OnPost()
        {
            //var regexName = new Regex(patterName);
            //var regexEmail = new Regex(patterEmail);
           // Users = _repository.GetAllUsers();
            string name = HttpContext.Request.Form["name"];
            string email = HttpContext.Request.Form["email"];
            string password = HttpContext.Request.Form["password"];

            _repository.AddUser(new Models.User() { Name = name, Email = email, Password = password });
            var user = _repository.GetUser(email, password);
            string key = user.ID.ToString();
            HttpContext.Session.SetString("user_id", key);
            SetCookie(key);

            if(ModelState.IsValid)
                return RedirectToPage("/User/PrivateAcc");
            else
                return RedirectToPage("/User/Registration");
        }

         private void SetCookie(string key)
         {
            HttpContext.Response.Cookies.Append("key", key);
         }
    }
}

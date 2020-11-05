using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Science_WebSite.Models;
using Science_WebSite.Services;

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
            //Users = _repository.GetAllUsers();
            Message = "Вход";
        }

        public void OnPost(string login, string password) //работает не так как надо
        {
            //Users = _repository.GetAllUsers();
            if (login == null || password == null)
            {
                Message = "Введите данные!";
            }
            else
            {
                bool flag = true;
                foreach (Models.User user in Users)
                {
                    if (user.Login == login && user.Password == password)
                    {
                        flag = false;
                        SuccessLogIn();
                    }
                }
                if (flag)
                {
                    Message = "Пользователь не найден!";
                }
            }
        }

        public IActionResult SuccessLogIn() // я хз че с этим делать 
        {
            return RedirectToPage("/PrivateAcc");
        }
    }
}

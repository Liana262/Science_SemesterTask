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
    public class RegistrationModel : PageModel
    {
        public string Message {get; set;}
        private readonly IUserRepository _repository;
        public IEnumerable<Models.User> Users { get; set; }
        public RegistrationModel(IUserRepository repository)
        {
            _repository = repository;
        }
        public void OnGet()
        {
           // Users = _repository.GetAllUsers();
            Message = "Войдите в личный кабинет";
        }

        public void OnPost(string email, string password)
        {
           // Users = _repository.GetAllUsers();
            if (email == null || password == null)
            {
                Message = "Введите данные!";
            }
            else
            {
                bool okey = true;
                bool okey_email = true;
                foreach(Models.User user in Users)
                {
                    if(user.Email == email && user.Password == password) 
                    {
                        Message = $"Welcome {user.Name}!";
                        okey = false;
                    }
                    else
                    {
                        if (user.Email == email && user.Password != password)
                        {
                            Message = "Неверный пароль!";
                            okey_email = false;
                        }
                    }    
                }
                if (!okey) 
                {
                    Message = "Пользователь не найден!";
                }
            }
        }
    }
}

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
    public class MockRegistrationModel : PageModel
    {
        public string Message { get; set; }
        private readonly IUserRepository _repository;
        public IEnumerable<Models.User> Users { get; set; }
        
        public MockRegistrationModel(IUserRepository repository)
        {
            _repository = repository;
        }
        public void OnGet()
        {
            // Users = _repository.GetAllUsers();
            //_repository.AddUser(new Models.User() { ID = 0, Name = "Slivka", LastName = "Slivochnaya", Login = "MyLogin", Password = "MyPassword", Email = "Slivka@Gmail.com" });
            //_repository.AddUser(new Models.User() { ID = 1, Name = "Mersi", LastName = "RobertProsty", Login = "login", Password = "parol", Email = "LiLPomp@Gmail.com" });
           // await _repository.GetUser("login", "parol");
            Message = $"Введите данные для регистрации";
        }

        public void OnPost(string name, string email, string password)
        {
            _repository.AddUser(new Models.User() { Name = name, Email = email, Password = password});
            var user_ = _repository.GetUser(email, password);
            Message = $"Пользователь {user_.ID} успешно зарегистрирован!";
            // Users = _repository.GetAllUsers();
            //if (email == null)
            //{
            //    Message = "Передан некорректный емаил. Повторите ввод";
            //}
            //else
            //{
            //    bool flag = true;
            //    foreach (var user in Users)
            //    {
            //        if (user.Email == email)
            //        {
            //            Message = $"welcome {user.Name}";
            //            flag = false;
            //        }
            //    }
            //    if (flag)
            //    {
            //        Message = "failed";
            //    }

        }
    }
}



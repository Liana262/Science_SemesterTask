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
    public class EditModel : PageModel
    {
        private readonly IUserRepository _repository;
        public EditModel(IUserRepository repository)
        {
            _repository = repository;
        }
        // public IEnumerable<Article> articles { get; set; }
        public Models.User user { get; private set; }
        public IActionResult OnGet(int id)
        {
           // user = _repository.GetUser(id); //если не будет юзера то пипетс надо реализовать метод нормально 

            //обработка исключения пустой модели
            if (user == null)
                return RedirectToPage("/NotFound");

            return Page();
        }
    }
}

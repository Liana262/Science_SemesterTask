using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Science_WebSite.Models;
using Science_WebSite.Services;

namespace Science_WebSite.Pages.BD_Pages
{
    public class Article_DetailsModel : PageModel
    {
        private readonly IRepository _repository;
        public Article_DetailsModel(IRepository repository)
        {
            _repository = repository;
        }
       // public IEnumerable<Article> articles { get; set; }
        public Article article { get; private set; }
        public IActionResult OnGet(int id)
        {
            article = _repository.GetArticle(id);

            //��������� ���������� ������ ������
            if (article == null)
                return RedirectToPage("/NotFound");

            return Page();
        }
    }
}
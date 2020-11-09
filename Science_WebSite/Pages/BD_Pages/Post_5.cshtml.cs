using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Science_WebSite.Services;
using Science_WebSite.Models;

namespace Science_WebSite.Pages.BD_Pages
{
    public class Post_5Model : PageModel
    {
        private readonly IArticleRepository _repository;
        public Article article { get; private set; }
        public Post_5Model(IArticleRepository repository)
        {
            _repository = repository;
        }
        public void OnGet()
        {
        }
    }
}

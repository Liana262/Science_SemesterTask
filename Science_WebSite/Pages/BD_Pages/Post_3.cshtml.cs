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
    public class Post_3Model : PageModel
    {
        private readonly IArticleRepository _repository;
        public Article article { get; private set; }
        public Post_3Model(IArticleRepository repository)
        {
            _repository = repository;
        }
        public void OnGet()
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Novi.Models;
using Novi.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Novi.Controllers
{
    public class ArticleController : Controller // Controllors respond with an action (returns a View) on incoming requests
    {
        // get access to the repositories (data controlled via the repositories)
        private readonly IArticleRepository _articleRepository; 
        private readonly ICategoryRepository _categoryRepository;

        // Constructor
        public ArticleController(IArticleRepository articleRepository, ICategoryRepository categoryRepository)
        {
            // get access to the model classes
            _articleRepository = articleRepository;
            _categoryRepository = categoryRepository;
        }

        // GET: /<controller>/
        public IActionResult List()
        {
            //ViewBag.CurrentCategory = "Modern Art";

            //return View(_articleRepository.AllArticles);
            ArticlesListViewModel articlesListViewModel = new ArticlesListViewModel();
            articlesListViewModel.Articles = _articleRepository.AllArticles;

            articlesListViewModel.CurrentCategory = "Modern Art";
            return View(articlesListViewModel);
        }
    }
}

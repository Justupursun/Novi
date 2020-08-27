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
    public class ArticleController : Controller
    {
        private readonly IArticleRepository _articleRepository;
        private readonly ICategoryRepository _categoryRepository;

        // Constructor to build-in the 2 repositories-data into the system via starticleup (services.AddScoped<IArticleRepository, MockArticleRepository>();)
        public ArticleController(IArticleRepository articleRepository, ICategoryRepository categoryRepository)
        {
            _articleRepository = articleRepository;
            _categoryRepository = categoryRepository;
        }

        // GET: /<controller>/
        //public IActionResult List()
        //{
        //    //ViewBag.CurrentCategory = "Cheese cakes";

        //    //return View(_articleRepository.AllArticles);
        //    ArticlesListViewModel articlesListViewModel = new ArticlesListViewModel();
        //    articlesListViewModel.Articles = _articleRepository.AllArticles;

        //    articlesListViewModel.CurrentCategory = "Cheese cakes";
        //    return View(articlesListViewModel);
        //}
        // Controllers handle incomming requests with an action

        public ViewResult List(string category)
        {
            IEnumerable<Article> articles;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                articles = _articleRepository.AllArticles.OrderBy(p => p.ArticleId);
                currentCategory = "All articles";
            }
            else
            {
                articles = _articleRepository.AllArticles.Where(p => p.Category.CategoryName == category)
                    .OrderBy(p => p.ArticleId);
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }

            return View(new ArticlesListViewModel
            {
                Articles = articles,
                CurrentCategory = currentCategory
            });
        }


        public IActionResult Details(int id)
        // ViewBag: The most basic way to show data on the dynamic cshtml-file
        //ViewBag.CurrentCategory = "surrealistic";
        {
            var article = _articleRepository.GetArticleById(id);
            if (article == null)
                return NotFound(); // send back a 404 not found

            return View(article); // View: build-in methode from asp.net core to view a .cshtml-file
        }
    }
}
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
    public class HomeController : Controller
    {
        private readonly IArticleRepository _articleRepository;

        public HomeController(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                ArticlesOfTheMonth = _articleRepository.ArticlesOfTheMonth
            };

            return View(homeViewModel);
        }
    }
}
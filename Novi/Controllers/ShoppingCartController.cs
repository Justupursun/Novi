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
    public class ShoppingCartController : Controller
    {
        private readonly IArticleRepository _articleRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IArticleRepository articleRepository, ShoppingCart shoppingCart)
        {
            _articleRepository = articleRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        //[HttpPost]
        public RedirectToActionResult AddToShoppingCart(int articleId)
        {
            var selectedArticle = _articleRepository.AllArticles.FirstOrDefault(p => p.ArticleId == articleId);

            if (selectedArticle != null)
            {
                _shoppingCart.AddToCart(selectedArticle);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int articleId)
        {
            var selectedArticle = _articleRepository.AllArticles.FirstOrDefault(p => p.ArticleId == articleId);

            if (selectedArticle != null)
            {
                _shoppingCart.RemoveFromCart(selectedArticle);
            }
            return RedirectToAction("Index");
        }
    }
}

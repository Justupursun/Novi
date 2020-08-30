using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Novi.Models
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly ShoppingCart _shoppingCart;

        public OrderRepository(AppDbContext appDbContext, ShoppingCart shoppingCart)
        {
            _appDbContext = appDbContext;
            _shoppingCart = shoppingCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;
           
            _appDbContext.Orders.Add(order);
           
            var shoppingCartItems = _shoppingCart.ShoppingCartItems;
           
            order.OrderTotal = _shoppingCart.GetShoppingCartTotal();

            order.OrderDetails = new List<OrderDetail>();
            //adding the order with its details

            foreach (var shoppingCartItem in shoppingCartItems)
            {
                var orderDetail = new OrderDetail
                {
//                    Amount = shoppingCartItem.Amount,
                    ArticleId = shoppingCartItem.Article.ArticleId,
                    Price = shoppingCartItem.Article.Price,
                    OrderId = order.OrderId,
                    HireFrom = shoppingCartItem.Article.HireFrom,
                    HireTill = shoppingCartItem.Article.HireTill
                };

                order.OrderDetails.Add(orderDetail);
            }

            _appDbContext.SaveChanges();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Novi.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public Article Article { get; set; }
//        public int Amount { get; set; } // Kan maar 1 exemplaar uitgeleend worden
//		public string StartDate { get; set; }
//		public string EndDate { get; set; }
        public string ShoppingCartId { get; set; }
    }
}

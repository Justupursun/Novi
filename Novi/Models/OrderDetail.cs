using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Novi.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int ArticleId { get; set; }
        //public int Amount { get; set; }
        public decimal Price { get; set; }
        public Article Article { get; set; }
        public Order Order { get; set; }
        public string HireFrom { get; set; }
        public string HireTill { get; set; }
        // public string periodBegin { get; set; }
        // public string periodEnd { get; set; }

    }
}

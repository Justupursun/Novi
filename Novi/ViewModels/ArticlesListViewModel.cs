using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Novi.Models;

namespace Novi.ViewModels
{
    public class ArticlesListViewModel
    {
        public IEnumerable<Article> Articles { get; set; }
        public string CurrentCategory { get; set; }
    }
}

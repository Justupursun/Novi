using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Novi.Models;

namespace Novi.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Article> ArticlesOfTheMonth { get; set; }
    }
}

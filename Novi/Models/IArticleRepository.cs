using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Novi.Models
{
    public interface IArticleRepository
    {
        IEnumerable<Article> AllArticles { get; }
        IEnumerable<Article> ArticlesOfTheMonth { get; }
        Article GetArticleById(int articleId);
    }
}

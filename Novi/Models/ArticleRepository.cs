using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Novi.Models
{
    public class ArticleRepository: IArticleRepository
    {
        private readonly AppDbContext _appDbContext;

        public ArticleRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Article> AllArticles
        {
            get
            {
                return _appDbContext.Articles.Include(c => c.Category);
            }
        }

        public IEnumerable<Article> ArticlesOfTheMonth
        {
            get
            {
                return _appDbContext.Articles.Include(c => c.Category).Where(p => p.IsArticleOfTheMonth);
            }
        }

        public IEnumerable<Article> ArticleOfTheMonth => throw new NotImplementedException();

        public Article GetArticleById(int articleId)
        {
            return _appDbContext.Articles.FirstOrDefault(p => p.ArticleId == articleId);
        }
    }
}

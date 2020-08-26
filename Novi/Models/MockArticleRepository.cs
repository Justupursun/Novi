using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Novi.Models
{
    public class MockArticleRepository: IArticleRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Article> AllArticles =>
            new List<Article>
            {
                new Article {ArticleId = 1, Name="De Staalmeesters", Price=15.95M, Description="Lorem Ipsum", Category = _categoryRepository.AllCategories.ToList()[0],ImageUrl="https://commons.wikimedia.org/wiki/File:Rembrandt_-_De_Staalmeesters_-_The_Syndics_of_the_Clothmaker%27s_Guild.jpg", Hireable=true, IsArticleOfTheMonth=false, ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/strawberryarticlesmall.jpg"},
                new Article {ArticleId = 2, Name="van Gogh", Price=18.95M, Description="Lorem Ipsum", Category = _categoryRepository.AllCategories.ToList()[0],ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbarticle.jpg", Hireable=true, IsArticleOfTheMonth=true, ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbarticlesmall.jpg"},
                new Article {ArticleId = 3, Name="Jan Steen", Price=12.95M, Description="Lorem Ipsum", Category = _categoryRepository.AllCategories.ToList()[2],ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinarticle.jpg", Hireable=true, IsArticleOfTheMonth=true, ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinarticlesmall.jpg"},
             };

        public IEnumerable<Article> ArticlesOfTheMonth { get; }

        public Article GetArticleById(int articleId)
        {
            return AllArticles.FirstOrDefault(p => p.ArticleId == articleId);
        }
    }
}

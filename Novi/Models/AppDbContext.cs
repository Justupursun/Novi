using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Novi.Models
{
    public class AppDbContext : DbContext
    {
        //constructor
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Abstract pie" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Surrealistic pie" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Other pie" });

            //seed pies

            modelBuilder.Entity<Article>().HasData(new Article
            {
                ArticleId = 1,
                Name = "Apple Article",
                Price = 12.95M,
                Description = "Our famous apple pies!",
                CategoryId = 1,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
                Hireable = true,
                IsArticleOfTheMonth = true,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg",
                HireFrom = "Olla",
                HireTill = "Arrivaderci"
            }) ; 

            modelBuilder.Entity<Article>().HasData(new Article
            {
                ArticleId = 2,
                Name = "Blueberry Cheese Cake",
                Price = 18.95M,
                Description = "You'll love it!",
                CategoryId = 2,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecake.jpg",
                Hireable = true,
                IsArticleOfTheMonth = false,
                ImageThumbnailUrl =
                    "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecakesmall.jpg",
                HireFrom = "Hallo",
                HireTill = "Dag"
            });

            modelBuilder.Entity<Article>().HasData(new Article
            {
                ArticleId = 3,
                Name = "Cheese Cake",
                Price = 18.95M,
                Description = "Plain cheese cake. Plain pleasure.",
                CategoryId = 2,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg",
                Hireable = true,
                IsArticleOfTheMonth = false,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg",
                HireFrom = "Hallo",
                HireTill = "Dag"
            });

            modelBuilder.Entity<Article>().HasData(new Article
            {
                ArticleId = 4,
                Name = "Cherry Article",
                Price = 15.95M,
                Description = "A summer classic!",
                CategoryId = 1,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypie.jpg",
                Hireable = true,
                IsArticleOfTheMonth = false,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypiesmall.jpg",
                HireFrom = "Hallo",
                HireTill = "Dag"
            });

            modelBuilder.Entity<Article>().HasData(new Article
            {
                ArticleId = 5,
                Name = "Christmas Apple Article",
                Price = 13.95M,
                Description = "Happy holidays with this pie!",
                CategoryId = 3,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepie.jpg",
                Hireable = true,
                IsArticleOfTheMonth = false,
                ImageThumbnailUrl =
                    "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepiesmall.jpg",
                HireFrom = "Hallo",
                HireTill = "Dag"
            });

            modelBuilder.Entity<Article>().HasData(new Article
            {
                ArticleId = 6,
                Name = "Cranberry Article",
                Price = 17.95M,
                Description = "A Christmas favorite",
                CategoryId = 3,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypie.jpg",
                Hireable = true,
                IsArticleOfTheMonth = false,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypiesmall.jpg",
                HireFrom = "Hallo",
                HireTill = "Dag"
            });

            modelBuilder.Entity<Article>().HasData(new Article
            {
                ArticleId = 7,
                Name = "Peach Article",
                Price = 15.95M,
                Description = "Sweet as peach",
                CategoryId = 1,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpie.jpg",
                Hireable = false,
                IsArticleOfTheMonth = false,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpiesmall.jpg",
                HireFrom = "Hallo",
                HireTill = "Dag"
            });

            modelBuilder.Entity<Article>().HasData(new Article
            {
                ArticleId = 8,
                Name = "Pumpkin Article",
                Price = 12.95M,
                Description = "Our Halloween favorite",
                CategoryId = 3,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpie.jpg",
                Hireable = true,
                IsArticleOfTheMonth = true,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpiesmall.jpg",
                HireFrom = "Hallo",
                HireTill = "Dag"
            });


            modelBuilder.Entity<Article>().HasData(new Article
            {
                ArticleId = 9,
                Name = "Rhubarb Article",
                Price = 15.95M,
                Description = "My God, so sweet!",
                CategoryId = 1,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpie.jpg",
                Hireable = true,
                IsArticleOfTheMonth = true,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpiesmall.jpg",
                HireFrom = "Hallo",
                HireTill = "Dag"
            });

            modelBuilder.Entity<Article>().HasData(new Article
            {
                ArticleId = 10,
                Name = "Strawberry Article",
                Price = 15.95M,
                Description = "Our delicious strawberry pie!",
                CategoryId = 1,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg",
                Hireable = true,
                IsArticleOfTheMonth = false,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg",
                HireFrom = "Hallo",
                HireTill = "Dag"
            });

            modelBuilder.Entity<Article>().HasData(new Article
            {
                ArticleId = 11,
                Name = "Strawberry Cheese Cake",
                Price = 18.95M,
                Description = "You'll love it!",
                CategoryId = 2,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecake.jpg",
                Hireable = false,
                IsArticleOfTheMonth = false,
                ImageThumbnailUrl =
                    "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecakesmall.jpg",
                HireFrom = "Hallo",
                HireTill = "Dag"
            });
        }
    }
}
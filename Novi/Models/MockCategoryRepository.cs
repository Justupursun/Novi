using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Novi.Models
{
    public class MockCategoryRepository: ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Modern art", Description="Modern art is made by modern students"},
                new Category{CategoryId=2, CategoryName="Abstract art", Description="Abstract art made by abstract students"},
                new Category{CategoryId=3, CategoryName="Other art", Description="Art that can not be categorized"}
            };
    }
}

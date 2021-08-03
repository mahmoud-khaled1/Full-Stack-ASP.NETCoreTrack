using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1,CategoryName="Fruit Pies",Description="All-Fruit Pies"},
                new Category{CategoryId=2,CategoryName="Cheese Cake",Description="Cheese All the Way"},
                new Category{CategoryId=3,CategoryName="seasonal Pies",Description="Get in the Mood for a seasonal Pie"}
            };
    }
}

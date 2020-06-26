using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;

namespace MoviappUygulaması.Models
{
    public class CategoryRepository
    {
        private static List<Category> _category = null;

        static CategoryRepository()
        {
            _category = new List<Category>()
            {
                new Category()
                {
                    ID = 1,
                    Name = "Category 1"

                },
                new Category()
                {
                    ID = 2,
                    Name = "Category 2"

                },
                new Category()
                {
                    ID = 3,
                    Name = "Category 3"

                },
                new Category()
                {
                    ID = 4,
                    Name = "Category 4"

                },
                new Category()
                {
                    ID = 5,
                    Name = "Category 4"

                },
            };
        }
        
        

        public static List<Category> Categories
        {
            get { return _category; }
        }

        public static void AddCategory(Category category)
        {
            _category.Add(category);
        }

        public static Category GetById(int id)
        {
            return _category.FirstOrDefault(i => i.ID == id);
        }
    }
}
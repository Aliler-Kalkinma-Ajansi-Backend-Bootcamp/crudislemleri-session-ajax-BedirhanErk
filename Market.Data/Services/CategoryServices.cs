using Market.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Market.Data.Services
{
    public class CategoryServices
    {
        public List<Category> GetAll()
        {
            List<Category> categories = new List<Category>();
            using (var data = new MarketDbContext())
            {
                categories = data.Categories.ToList();
            }
            return categories;
        }

        public Category GetById(int id)
        {
            Category categories = new Category();
            using (var data = new MarketDbContext())
            {
                categories = data.Categories.FirstOrDefault(x => x.Id == id);
            }
            return categories;
        }

        public Category DeleteCategory(int id)
        {
            Category categories = new Category();
            using (var data = new MarketDbContext())
            {
                categories = data.Categories.FirstOrDefault(x => x.Id == id);
                data.Categories.Remove(categories);
                data.SaveChanges();
            }
            return categories;
        }

        public Category AddCategory(Category categories)
        {
            using (var data = new MarketDbContext())
            {
                data.Categories.Add(categories);
                data.SaveChanges();
            }
            return categories;
        }


        public Category UpdateCategory(Category categories)
        {

            using (var data = new MarketDbContext())
            {
                data.Entry(categories).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                data.SaveChanges();
                return categories;
            }
        }
    }
}


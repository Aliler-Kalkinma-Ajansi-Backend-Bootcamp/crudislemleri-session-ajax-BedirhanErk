using Market.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Market.Data.Services
{
    public class ProductServices
    {
        public List<Models.Product> GetAll()
        {
            List<Models.Product> products = new List<Models.Product>();
            using (var data = new Models.MarketDbContext())
            {
                products = data.Products.ToList();
            }
            return products;
        }
        public Models.Product GetById(int id)
        {
            Models.Product products = new Models.Product();
            using (var data = new Models.MarketDbContext())
            {
                products = data.Products.FirstOrDefault(x => x.Id == id);
            }
            return products;
        }
        public Models.Product DeleteProduct(int id)
        {
            Models.Product products = new Models.Product();
            using (var data = new Models.MarketDbContext())
            {
                products = data.Products.FirstOrDefault(x => x.Id == id);
                data.Products.Remove(products);
                data.SaveChanges();
            }
            return products;
        }

        public Product  AddProduct(Product product)
        {
            using (var data = new Models.MarketDbContext())
            {
                data.Products.Add(product);
                data.SaveChanges();
            }
            return product;
        }


        public Product UpdateProduct(Product product)
        {
            
            using (var data = new MarketDbContext())
            {
                data.Entry(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                data.SaveChanges();
            }
            return product;
        }

    }
}

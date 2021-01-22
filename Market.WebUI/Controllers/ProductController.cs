using Market.Data.Models;
using Market.WebUI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Market.WebUI.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List()
        {
            Data.Services.ProductServices productServices = new Data.Services.ProductServices();
            var result = productServices.GetAll();
            return View(result);
        }
        public IActionResult Create()
        {
            return View(new Product());
        }

        [HttpPost]
        public IActionResult Create(ProductModel model)
        {
            Data.Services.ProductServices productServices = new Data.Services.ProductServices();

            var entity = new Product()
            {
                Name = model.Name,
                Price = model.Price,
                Descriprion = model.Descriprion,
                Image = model.Image
            };

            productServices.AddProduct(entity);

            return RedirectToAction("List");
        }

        public IActionResult Delete(int id)
        {
            Data.Services.ProductServices productServices = new Data.Services.ProductServices();
            productServices.DeleteProduct(id);
            return RedirectToAction("List");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            Data.Services.ProductServices productServices = new Data.Services.ProductServices();
            var entity = productServices.GetById(id);
            return View(entity);
        }
        [HttpPost]
        public IActionResult Update(Product model)
        {
            Data.Services.ProductServices productServices = new Data.Services.ProductServices();
            var entity = productServices.GetById(model.Id);

            if (entity == null)
            {
                return NotFound();
            }

            entity.Name = model.Name;
            entity.Price = model.Price;
            entity.Descriprion = model.Descriprion;
            entity.Image = model.Image;

            productServices.UpdateProduct(entity);

            return RedirectToAction("List");
        }

    }
}

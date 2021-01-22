using Market.Data.Models;
using Market.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Market.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List()
        {
            Data.Services.CategoryServices categoryServices = new Data.Services.CategoryServices();
            var result = categoryServices.GetAll();
            return View(result);
        }
        public IActionResult Create()
        {
            return View(new Category());
        }
        [HttpPost]
        public JsonResult Create(Category data)
        {
            Data.Services.CategoryServices categoryServices = new Data.Services.CategoryServices();
            var result = categoryServices.AddCategory(data);
            if (result == null)
            {
                return Json("An error occurred while adding the category.");
            }
            return Json("The category has been successfully added.");
        }

        public IActionResult Delete(int id)
        {
            Data.Services.CategoryServices categoryServices = new Data.Services.CategoryServices();
            categoryServices.DeleteCategory(id);
            return RedirectToAction("List");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            Data.Services.CategoryServices categoryServices = new Data.Services.CategoryServices();
            var entity = categoryServices.GetById(id);
            return View(entity);
        }
        [HttpPost]
        public IActionResult Update(Category model)
        {
            Data.Services.CategoryServices categoryServices = new Data.Services.CategoryServices();
            var entity = categoryServices.GetById(model.Id);

            if (entity == null)
            {
                return NotFound();
            }

            entity.Name = model.Name;

            categoryServices.UpdateCategory(entity);

            return RedirectToAction("List");
        }

    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Online_Shop.Data.Models;
using Online_Shop.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace Online_Shop.Controllers
{
    public class FoodController : Controller
    {
        FoodRepository ct = new FoodRepository();
        Context c = new Context();
        public IActionResult Index(int page=1)
        {
           
            return View(ct.TList("Category").ToPagedList(page,3));
        }

        [HttpGet]
        public IActionResult FoodAdd()
        {
            List<SelectListItem> values = (from x in c.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text=x.CategoryName,
                                               Value = x.CategoryId.ToString()
                                           }).ToList();

            ViewBag.v1 = values;

            return View();
        }
        [HttpPost]
        public IActionResult FoodAdd(AddProduct p)
        {
            Food f = new Food();
            if (p.ImageUrl != null)
            {
                var extensions = Path.GetExtension(p.ImageUrl.FileName);
                var newImageName = Guid.NewGuid() + extensions;
                var location = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/images/",newImageName);
                var stream = new FileStream(location, FileMode.Create);
                p.ImageUrl.CopyTo(stream);
                f.ImageUrl = newImageName;

            }
            f.Name = p.ProductName;
            f.Price = p.Price;
            f.Stock = p.Stock;
            f.CategoryId = p.CategoryId;
            f.Description = p.Description;

            ct.TAdd(f);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteFood(int id)
        {
           
            ct.TDelete(new Food { FoodId=id });
            return RedirectToAction("Index");
        }

        public IActionResult FoodGet(int id)
        {

            var x = ct.TGet(id);
            List<SelectListItem> values = (from y in c.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = y.CategoryName,
                                               Value = y.CategoryId.ToString()
                                           }).ToList();
            ViewBag.v1 = values;
            Food f = new Food()
            {
                Name = x.Name,
                Description = x.Description,
                FoodId = x.FoodId,
                Stock = x.Stock,
                Price = x.Price,
                ImageUrl = x.ImageUrl,
                Category = x.Category,

            };
            return View(f);

        }
        [HttpPost]
        public IActionResult UpdateFood(Food  p)
        {
            var x = ct.TGet(p.FoodId);
            x.Name = p.Name;
            x.Stock = p.Stock;
            x.Price = p.Price;
            x.Description = p.Description;
            x.ImageUrl = p.ImageUrl;
            x.CategoryId = p.CategoryId;

            ct.TUpdate(x);
            return RedirectToAction("Index");


            
        }
    }
}

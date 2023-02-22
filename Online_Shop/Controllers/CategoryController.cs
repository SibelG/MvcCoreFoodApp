using Microsoft.AspNetCore.Mvc;
using Online_Shop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Online_Shop.Data.Models;
using Microsoft.AspNetCore.Authorization;

namespace Online_Shop.Controllers
{
    public class CategoryController : Controller
    {
        CategoryRepository ct = new CategoryRepository();

        [Authorize]
        public IActionResult Index(string p)
        {
            if (!string.IsNullOrEmpty(p)){
                return View(ct.List(x => x.CategoryName == p));
            }
            return View(ct.TList());
        }

        [HttpGet]
        public IActionResult CategoryAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CategoryAdd(Category p)
        {
            if (!ModelState.IsValid)
            {
                return View("CategoryAdd");
            }
            ct.TAdd(p);
            return RedirectToAction("Index");
        }

        public IActionResult CategoryGet(int id)
        {
            var x = ct.TGet(id);
            Category ctg = new Category()
            {
                CategoryName = x.CategoryName,
                CategoryDescription = x.CategoryDescription,
                CategoryId = x.CategoryId
            };

            return View(ctg);
        }

        [HttpPost]
        public IActionResult CategoryUpdate(Category p)
        {
            var x = ct.TGet(p.CategoryId);
            x.CategoryName = p.CategoryName;
            x.CategoryName = p.CategoryDescription;
            x.Status = p.Status;
            ct.TUpdate(x);
            return RedirectToAction("Index");

        }

        public IActionResult CategoryDelete(int id)
        {
            var x = ct.TGet(id);
            x.Status = false;
            ct.TUpdate(x);
            return RedirectToAction("Index");
        }
    }
}

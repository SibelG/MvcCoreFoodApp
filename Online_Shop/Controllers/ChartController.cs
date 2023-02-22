using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Online_Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Shop.Controllers
{
    [AllowAnonymous]
    public class ChartController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ChartIndex()
        {
            return View();
        }

        public IActionResult ChartDynamicIndex()
        {
            return View();
        }

        public IActionResult VisualizeProductResult() 
        {
            return Json(ProList());

        }
        public List<Chart> ProList()
        {
            List<Chart> cs = new List<Chart>();
            cs.Add(new Chart()
            {
                propName = "Computer",
                Stock=150

            });
            cs.Add(new Chart()
            {
                propName = "Lcd",
                Stock = 100

            });

            return cs;

        }
        public IActionResult VisualizeProductResult2()
        {
            return Json(FoodList());

        }
        public List<ChartDynamic> FoodList()
        {
            List<ChartDynamic> cs2 = new List<ChartDynamic>();
            using (var c = new Context())
            {
                cs2 = c.Foods.Select(x => new ChartDynamic
                {
                    FoodName=x.Name,
                    Stock=x.Stock

                }).ToList();
            }
            return cs2;
        }

        public IActionResult Statistics()
        {
            Context c = new Context();
            var deger1 = c.Foods.Count();
            ViewBag.d1 = deger1;
            var deger2 = c.Categories.Count();
            ViewBag.d2 = deger2;
            var deger3 = c.Foods.Where(x =>x.CategoryId == 1).Count();
            ViewBag.d3 = deger3;
            var deger4 = c.Foods.Where(x => x.CategoryId == 2).Count();
            ViewBag.d4 = deger4;
            var deger5 = c.Foods.Sum(x=>x.Stock);
            ViewBag.d5 = deger5;
            var deger6 = c.Foods.Where(x => x.CategoryId == 3).Count();
            ViewBag.d6 = deger6;
            var deger7 = c.Foods.OrderByDescending(x => x.Stock).Select(y => y.Name).FirstOrDefault();
            ViewBag.d7 = deger7;
            var deger8 = c.Foods.OrderBy(x => x.Stock).Select(y => y.Name).FirstOrDefault();
            ViewBag.d8 = deger8;
            var deger9 = c.Foods.Average(x => x.Price).ToString("0.00");
            ViewBag.d9 = deger9;
            var deger10 = c.Categories.Where(x => x.CategoryName == "Fruit").Select(y => y.CategoryId).FirstOrDefault();
            var deger10p = c.Foods.Where(y => y.CategoryId == deger10).Sum(x => x.Stock);
            ViewBag.d10 = deger10p;
            var deger11 = c.Categories.Where(x => x.CategoryName == "Vegatables").Select(y => y.CategoryId).FirstOrDefault();
            var deger11p = c.Foods.Where(y => y.CategoryId == deger11).Sum(x => x.Stock);
            ViewBag.d11 = deger11p;
            var deger12 = c.Foods.OrderByDescending(x => x.Price).Select(y => y.Name).FirstOrDefault();
            ViewBag.d12 = deger12;
            return View();
        }

    }
}

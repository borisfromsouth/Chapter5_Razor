using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Razor_pages.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Razor_pages.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            //Product myProduct = new Product
            //{
            //    ProductID = 1,
            //    Name = "Kayak",
            //    Description = "A boat for one person",
            //    Category = "Watersports",
            //    Price = 275M
            //};
            //ViewBag.StockLevel = 2;
            //return View(myProduct);

            Product[] array =
            {
                new Product {Name = "Kayak", Price = 275M },
                new Product {Name = "LifeJacket", Price = 48.95M },
                new Product {Name = "Soccer Ball", Price = 19.50M },
                new Product {Name = "Corner Flag", Price = 34.95M }
            };
            return View(array);
        }
    }
}

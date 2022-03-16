using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyFirstWebApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Product> products = new List<Product>();
            Product prod1 = new Product();
            prod1.Id = 1;
            prod1.Name = "Dress";
            prod1.Price = 30;
            prod1.Unit = "a123";
            products.Add(prod1);
            Product prod2 = new Product();
            prod2.Id = 2;
            prod2.Name = "Hat";
            prod2.Price = 15;
            prod2.Unit = "b234";
            products.Add(prod2);
            Product prod3 = new Product();
            prod3.Id = 3;
            prod3.Name = "Jacket";
            prod3.Price = 50;
            prod3.Unit = "c567";
            products.Add(prod3);
            return View(products);
        }

        public IActionResult Sales()
        {

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

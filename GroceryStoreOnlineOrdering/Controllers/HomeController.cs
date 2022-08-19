using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
//using GroceryStoreOnlineOrdering.Models;
using GroceryStoreOnlineOrdering.Data;
using GroceryStore.Models;

namespace GroceryStoreOnlineOrdering.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            if (_db.Categories == null)
            {
                return NotFound();
            }
            var obj = _db.Categories.ToList();

            return View(obj);
            //_db.Categories.Find(3)
        }

        public IActionResult Shop()
        {
            return View();
        }
        public IActionResult ShopDetail()
        {
            return View();
        }
        public IActionResult Checkout()
        {
            return View();
        }
        public IActionResult ShoppingChart()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult EatingThing()
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
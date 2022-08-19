using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroceryStore.Models;
//using GroceryStoreOnlineOrdering.Models;
using Microsoft.AspNetCore.Mvc;

namespace GroceryStoreOnlineOrdering.Controllers
{
    public class UserController : Controller
    {
        [HttpPost]
        public IActionResult Login(User users)
        {
            if (ModelState.IsValid)
            {

                //return View("ShowLogin", users);
                return RedirectToAction("ShowLogin");

                
            }
            else
            {
                return View();

                //return View(users);
            }
        }
        [HttpGet]
        [ActionName("Login")]
        public IActionResult LoginGet()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateUser(User user)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Login");
            }
            else
            {
                return View();
            }
        }
        public IActionResult CreateUser()
        {
            return View();
        }

        public IActionResult ShowLogin()
        {
            return View();
        }

    }
}

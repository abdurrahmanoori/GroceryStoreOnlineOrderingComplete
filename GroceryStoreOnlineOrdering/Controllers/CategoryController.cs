using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroceryStoreOnlineOrdering.Data;
using GroceryStoreOnlineOrdering.Models;
using Microsoft.AspNetCore.Mvc;

namespace GroceryStoreOnlineOrdering.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            if (_db.Categories.Count() > 0)
            {
                IEnumerable<Category> categories = _db.Categories.ToList();
                return View(categories);
            }

            return NotFound();
        }
        //GET Create
        public IActionResult Create()
        {
            return View();
        }
        // POST Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                _db.Add(category);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        //GET Edit
        public IActionResult Edit(int? id)
        {
            var obj = _db.Categories.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        //POST Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Update(category);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        //GET Delete
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Categories.Find(id);
            return View(obj);
        }

        //POST Delete
        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeletePost(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Category category = _db.Categories.Find(id);
            _db.Categories.Remove(category);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }




    }
}

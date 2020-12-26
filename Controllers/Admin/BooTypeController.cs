using System;
using System.Linq;
using System.Collections.Generic;
using LibManage.Data;
using LibManage.Models;
using Microsoft.AspNetCore.Mvc;
using LibManage.Services;
using Microsoft.EntityFrameworkCore;

namespace LibManage.Controllers
{
    [Route("/admin/book/booktype")]
    public class ProductCategoryController : Controller
    {

        private readonly ApplicationDbContext db;

        public ProductCategoryController(ApplicationDbContext db)
        {

            this.db = db;
        }

        [HttpGet]
        public IActionResult Index()
        {

            var Categories = db.BookTypes.OrderBy(item => item.Id).ToList();

            return View("/Views/Admin/book/BookType.cshtml", Categories);
        }

        [HttpGet("search")]

        public IActionResult Search(string query)
        {
            
            query = "%" + query + "%";
            
            var Categories = db.BookTypes
                               .Where(item => EF.Functions.ILike(item.Name, query)
                                              || EF.Functions.ILike(item.Description, query)
                                      )
                               .OrderBy(item => item.Id).ToList();

            return View("/Views/Admin/book/BookType.cshtml", Categories);
        }


        //=== add category

        [HttpPost]
        public IActionResult Create([FromForm] BookType model)
        {

            if (ModelState.IsValid)
            {
                var found = db.BookTypes.Any(item => item.Name == model.Name);

                // check category found

                if (found)
                {
                    ModelState.AddModelError("Found Book type", "Book type name is found");
                }

                // add category

                db.BookTypes.Add(model);
                db.SaveChanges();

                // alert success to view
                TempData["message"] = "Create Book type success";
            }

            return RedirectToAction("Index");

        }

        //=== edit category

        [HttpPost("update/{id}")]
        public IActionResult Update(int id, [FromForm] BookType model)
        {

            if (ModelState.IsValid)
            {
                var found = db.BookTypes.Find(id);

                // check category found

                if (found == null)
                {
                    ModelState.AddModelError("Found Book type", "Book type not found");
                }

                // add category

                found.Name = model.Name;
                found.Description = model.Description;

                db.SaveChanges();

                // alert success to view
                TempData["message"] = "Update Book type success";
            }

            return RedirectToAction("Index");

        }

        //=== delete category

        [HttpPost("delete/{id}")]

        public IActionResult Delete(int id)
        {

            var found = db.BookTypes.Find(id);

            // check category found

            if (found == null)
            {
                ModelState.AddModelError("Found Book type", "Book type not found");
            }

            db.BookTypes.Remove(found);
            db.SaveChanges();

            TempData["message"] = "Delete Book type success";

            return RedirectToAction("Index");
        }



    }
}
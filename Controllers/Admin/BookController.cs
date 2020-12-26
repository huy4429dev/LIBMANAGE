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
    [Route("/admin/book")]
    public class BookController : Controller
    {

        private readonly ApplicationDbContext db;

        public BookController(ApplicationDbContext db)
        {

            this.db = db;
        }

        [HttpGet]
        public IActionResult Index()
        {

            var Books = db.Books.OrderBy(item => item.Id).ToList();

            ViewData["BookTypes"] = db.BookTypes.ToList();
            ViewData["Authors"] = db.Authors.ToList();
            ViewData["Publishers"] = db.Publishers.ToList();

            return View("/Views/Admin/book/Index.cshtml", Books);
        }

        [HttpGet("search")]

        public IActionResult Search(string query)
        {

            query = "%" + query + "%";

            var Books = db.Books
                               //    .Where(item => EF.Functions.ILike(item.Name, query)
                               //                   || EF.Functions.ILike(item.Description, query)
                               //           )
                               .OrderBy(item => item.Id).ToList();

            return View("/Views/Admin/Book/Category.cshtml", Books);
        }


        //=== add category

        [HttpPost]
        public IActionResult Create([FromForm] Book model)
        {

            if (ModelState.IsValid)
            {
                
                db.Books.Add(model);
                model.Rate = 5;
                model.CreatedTime = DateTime.Now;
                model.UpdatedTime = DateTime.Now;
                db.SaveChanges();

                // alert success to view
                TempData["message"] = "Create book success";
            }

            return RedirectToAction("Index");

        }

        //=== edit category

        [HttpPost("update/{id}")]
        public IActionResult Update(int id, [FromForm] Book model)
        {

            if (ModelState.IsValid)
            {
                var found = db.Books.Find(id);

                // check category found

                if (found == null)
                {
                    ModelState.AddModelError("Found Cateogry", "Category not found");
                }

                // add category

                // found.Name = model.Name;
                // found.Description = model.Description;

                db.SaveChanges();

                // alert success to view
                TempData["message"] = "Update category success";
            }

            return RedirectToAction("Index");

        }

        //=== delete category

        [HttpPost("delete/{id}")]

        public IActionResult Delete(int id)
        {

            var found = db.Books.Find(id);

            // check category found

            if (found == null)
            {
                ModelState.AddModelError("Found Cateogry", "Category not found");
            }

            db.Books.Remove(found);
            db.SaveChanges();

            TempData["message"] = "Delete category success";

            return RedirectToAction("Index");
        }



    }
}
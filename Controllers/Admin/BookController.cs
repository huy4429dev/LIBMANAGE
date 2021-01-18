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
        public IActionResult Index(int page = 1, int pageSize = 25)
        {

            var Books = db.Books
                          .OrderByDescending(item => item.Id)
                          .Skip((page - 1) * pageSize)
                          .Take(pageSize)
                          .ToList();

            ViewData["BookTypes"] = db.BookTypes.ToList();
            ViewData["Authors"] = db.Authors.ToList();
            ViewData["Publishers"] = db.Publishers.ToList();
            ViewBag.TotalPage = db.Books.Count() / pageSize == 0 ? db.Books.Count() / pageSize : db.Books.Count() / pageSize + 1;
            ViewBag.CurentPage = page;

            return View("/Views/Admin/book/Index.cshtml", Books);
        }

        [HttpGet("search")]

        public IActionResult Search(string query, int page = 1, int pageSize = 25)
        {

            query = "%" + query + "%";

            var Books = db.Books
                                  .Where(item => EF.Functions.ILike(item.Title, query)
                                                 || EF.Functions.ILike(item.Description, query)
                                         )
                                   .Select(item => new Book
                                   {
                                       Title = item.Title,
                                       CreatedTime = item.CreatedTime,
                                       UpdatedTime = item.UpdatedTime,
                                       Description = item.Description,
                                       PDFfile = item.PDFfile,
                                       YearPublished = item.YearPublished,
                                       Id = item.Id,
                                       Image = item.Image,
                                       Authors = item.Authors,
                                       BookTypes = item.BookTypes,
                                       Publishers = item.Publishers
                                   })
                                  .OrderByDescending(item => item.Id)
                                  .Skip((page - 1) * pageSize)
                                  .Take(pageSize)
                                  .ToList();

            ViewData["BookTypes"] = db.BookTypes.ToList();
            ViewData["Authors"] = db.Authors.ToList();
            ViewData["Publishers"] = db.Publishers.ToList();
            ViewBag.TotalPage = db.Books.Count() / pageSize == 0 ? db.Books.Count() / pageSize : db.Books.Count() / pageSize + 1;
            ViewBag.CurentPage = page;

            return View("/Views/Admin/book/Index.cshtml", Books);
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
                TempData["message"] = "Thêm mới sách thành công";
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
                TempData["message"] = "Cập nhật sách thành công";
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

            TempData["message"] = "Xóa sản phẩm thành công";

            return RedirectToAction("Index");
        }



    }
}
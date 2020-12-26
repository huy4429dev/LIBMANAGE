using Microsoft.AspNetCore.Mvc;
using System.Linq;
using LibManage.Data;
using LibManage.Models;
using Microsoft.EntityFrameworkCore;
using System;
using LibManage.ViewModels;

namespace LibManage.Controllers
{
    [Route("/product")]
    public class ProductController : Controller
    {
        private ApplicationDbContext db;
        public ProductController(ApplicationDbContext db)
        {
            this.db = db;
        }

        [HttpGet("{id}")]
        public IActionResult Index(int id)
        {
            var Product = db.Books
                            .Where(item => item.Id == id)
                            .Select(item => new Book
                            {
                                Id = item.Id,
                                Title = item.Title,
                                Image = item.Image,
                                Rate = item.Rate,
                                Authors = item.Authors,
                                Publisher = item.Publisher,
                                BookTpye = item.BookTpye,
                                Description = item.Description,
                                BookTypes = item.BookTypes,
                                CreatedTime = item.CreatedTime
                            })
                            .First();

            ViewBag.Product = Product;

            ViewBag.RelatedProducts = db.Books
                                 .Where(b => b.BookTpye == Product.BookTpye)
                                 .Select(item => new Book
                                 {
                                     Id = item.Id,
                                     Title = item.Title,
                                     Image = item.Image,
                                     Rate = item.Rate,
                                     Authors = item.Authors,
                                     Description = item.Description,
                                     CreatedTime = item.CreatedTime
                                 })
                                 .OrderByDescending(b => b.CreatedTime)
                                 .Take(3);


            ViewBag.Categories = db.BookTypes
                                          .Select(item => new CategoryViewModel
                                          {
                                              Id = item.Id,
                                              Name = item.Name,
                                              CountProduct = item.Books.Count()
                                          }).ToList();

            ViewBag.Authors = db.Authors
                               .Select(item => new CategoryViewModel
                               {
                                   Id = item.Id,
                                   Name = item.Name,
                                   CountProduct = item.Books.Count()
                               }).ToList();

            ViewBag.Tags = db.Tags
                               .Select(item => new Tag
                               {
                                   Id = item.Id,
                                   Name = item.Name
                               }).ToList();


            return View("/Views/Product/Index.cshtml");
        }

    }
}
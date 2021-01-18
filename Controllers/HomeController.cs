using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using LibManage.Data;
using LibManage.Models;
using LibManage.ViewModels;
using System.Collections.Generic;

namespace LibManage.Controllers
{

    [Route("/")]
    public class HomeController : Controller
    {

        private ApplicationDbContext db;
        public HomeController(ApplicationDbContext db)
        {
            this.db = db;
        }

        [HttpGet]
        public IActionResult Index(int page = 1, int pageSize = 12)
        {

            var data = db.Books.GroupBy(item => new
            {
                item.CreatedTime.Date,
                item.CreatedTime.Hour
            })
            .Select(g => new
            {
                g.Key,
                total = g.Count()
            }).ToList();


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
                               })
                               .OrderByDescending(a => a.CountProduct)
                               .Skip(0)
                               .Take(10)
                               .ToList();

            ViewBag.Tags = db.Tags
                               .Select(item => new Tag
                               {
                                   Id = item.Id,
                                   Name = item.Name
                               }).ToList();


            ViewBag.Products = db.Books
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
                                 .Skip((page - 1) * pageSize)
                                 .Take(pageSize);

            ViewBag.TotalProduct = db.Books.Count();

            ViewBag.CurentPage = page;
            ViewBag.TotalPage = ViewBag.TotalProduct % pageSize != 0 ? ViewBag.TotalProduct / pageSize + 1 : ViewBag.TotalProduct / pageSize;

            return View("/Views/Home/Index.cshtml");
        }


        [HttpGet("product/view/search")]
        public IActionResult ViewSearch(int page = 1, int pageSize = 12, string filter = null, string search = null)
        {

            var data = db.Books.GroupBy(item => new
            {
                item.CreatedTime.Date,
                item.CreatedTime.Hour
            })
            .Select(g => new
            {
                g.Key,
                total = g.Count()
            }).ToList();


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



            var Products = new List<Book>();
            int TotalProduct = 0;
            int TotalPage = 0;

            if(search != null){

                search = $"%{search}%";
                Products = db.Books
                               .Where(item => 
                                                EF.Functions.ILike(item.Title,search) 
                                                || EF.Functions.ILike(item.Authors.Name, search)
                                                || item.BookTags.Any(t => t.Tag.Name.Contains(search))
                                      )
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
                               .OrderBy(item => item.CreatedTime)
                               .Skip((page - 1) * pageSize)
                               .Take(pageSize)
                               .ToList();
            }

            if (filter == "new")
            {
                Products = db.Books
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
                               .OrderBy(item => item.CreatedTime)
                               .Skip((page - 1) * pageSize)
                               .Take(pageSize)
                               .ToList();

                TotalProduct = db.Books.Count();
                TotalPage = TotalProduct % pageSize != 0 ? TotalProduct / pageSize + 1 : TotalProduct / pageSize;
            }

            if (filter == "hot")
            {
                Products = db.Books
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
                               .OrderBy(item => item.Rate)
                               .Skip((page - 1) * pageSize)
                               .Take(pageSize)
                               .ToList();

                TotalProduct = db.Books.Count();
                TotalPage = TotalProduct % pageSize != 0 ? TotalProduct / pageSize + 1 : TotalProduct / pageSize;
            }

            if (filter == "order")
            {
                Products = db.Books
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
                               .OrderBy(item => item.CreatedTime)
                               .Skip((page - 1) * pageSize)
                               .Take(pageSize)
                               .ToList();

                TotalProduct = db.Books.Count();
                TotalPage = TotalProduct % pageSize != 0 ? TotalProduct / pageSize + 1 : TotalProduct / pageSize;
            }



            ViewBag.Products = Products;
            ViewBag.TotalProduct = TotalProduct;
            ViewBag.CurentPage = page;
            ViewBag.TotalPage = TotalPage;
            ViewBag.Search = search.Replace("%","");

            return View("/Views/Home/Index.cshtml");
        }


        [HttpGet("product/search")]
        public IActionResult Search(int page = 1, int pageSize = 9, string filter = null)
        {
            var Products = new List<Book>();
            int TotalProduct = 0;
            int TotalPage = 0;
            if (filter == "new")
            {
                Products = db.Books
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
                               .OrderBy(item => item.CreatedTime)
                               .Skip((page - 1) * pageSize)
                               .Take(pageSize)
                               .ToList();

                TotalProduct = db.Books.Count();
                TotalPage = TotalProduct % pageSize != 0 ? TotalProduct / pageSize + 1 : TotalProduct / pageSize;
            }

            if (filter == "hot")
            {
                Products = db.Books
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
                               .OrderBy(item => item.Rate)
                               .Skip((page - 1) * pageSize)
                               .Take(pageSize)
                               .ToList();

                TotalProduct = db.Books.Count();
                TotalPage = TotalProduct % pageSize != 0 ? TotalProduct / pageSize + 1 : TotalProduct / pageSize;
            }

            if (filter == "order")
            {
                Products = db.Books
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
                               .OrderBy(item => item.CreatedTime)
                               .Skip((page - 1) * pageSize)
                                .Take(pageSize)
                               .ToList();

                TotalProduct = db.Books.Count();
                TotalPage = TotalProduct % pageSize != 0 ? TotalProduct / pageSize + 1 : TotalProduct / pageSize;
            }

            return Ok(new
            {
                products = Products,
                totalProduct = TotalProduct,
                totalPage = TotalPage
            });
        }

    }
}
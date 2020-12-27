using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using LibManage.Data;
using LibManage.Models;
using LibManage.ViewModels;
using System.Collections.Generic;

namespace LibManage.Controllers
{
    public class NewController : Controller
    {

        private ApplicationDbContext db;
        public NewController(ApplicationDbContext db)
        {
            this.db = db;
        }

        [HttpGet]
        public IActionResult Index()
        {

            var Posts = db.Posts
                           .Select(item => new Post
                           {
                               Id = item.Id,
                               Title = item.Title,
                               Description = item.Description,
                               Thumbnail = item.Thumbnail,
                               Content = item.Content,
                               User = item.User,
                               CreatedAt = item.CreatedAt,
                               UpdatedAt = item.UpdatedAt,
                           })
                            .ToList();

                      ViewBag.HotPosts = db.Posts
                           .Select(item => new Post
                           {
                               Id = item.Id,
                               Title = item.Title,
                               Description = item.Description,
                               Thumbnail = item.Thumbnail,
                               Content = item.Content,
                               User = item.User,
                               CreatedAt = item.CreatedAt,
                               UpdatedAt = item.UpdatedAt,
                               ViewCount = item.ViewCount
                           })
                           .OrderByDescending(item => item.ViewCount)
                           .Take(5)
                           .ToList();

            return View("/Views/New/Index.cshtml", Posts);
        }

        [HttpGet("new/search")]
        public IActionResult Search(string q)
        {

            q = $"%{q}%";
            var Posts = db.Posts
                           .Where(item =>
                                EF.Functions.ILike(item.Title, q) ||
                                EF.Functions.ILike(item.User.FullName, q)
                           )
                           .Select(item => new Post
                           {
                               Id = item.Id,
                               Title = item.Title,
                               Description = item.Description,
                               Thumbnail = item.Thumbnail,
                               Content = item.Content,
                               User = item.User,
                               CreatedAt = item.CreatedAt,
                               UpdatedAt = item.UpdatedAt,
                           })
                            .ToList();


            ViewBag.HotPosts = db.Posts
                           .Select(item => new Post
                           {
                               Id = item.Id,
                               Title = item.Title,
                               Description = item.Description,
                               Thumbnail = item.Thumbnail,
                               Content = item.Content,
                               User = item.User,
                               CreatedAt = item.CreatedAt,
                               UpdatedAt = item.UpdatedAt,
                               ViewCount = item.ViewCount
                           })
                           .OrderByDescending(item => item.ViewCount)
                           .Take(5)
                           .ToList();

            return View("/Views/New/Index.cshtml", Posts);
        }


        [HttpGet("new/{id}")]
        public IActionResult Detail(int id)
        {
            var found = db.Posts.Find(id); 
            found.ViewCount ++ ;
            db.SaveChanges();
            var Post = db.Posts
                          .Where(item => item.Id == id)
                           .Select(item => new Post
                           {
                               Id = item.Id,
                               Title = item.Title,
                               Description = item.Description,
                               Thumbnail = item.Thumbnail,
                               Content = item.Content,
                               User = item.User,
                               CreatedAt = item.CreatedAt,
                               UpdatedAt = item.UpdatedAt,
                           })
                            .FirstOrDefault();

            ViewBag.HotPosts = db.Posts
                           .Select(item => new Post
                           {
                               Id = item.Id,
                               Title = item.Title,
                               Description = item.Description,
                               Thumbnail = item.Thumbnail,
                               Content = item.Content,
                               User = item.User,
                               CreatedAt = item.CreatedAt,
                               UpdatedAt = item.UpdatedAt,
                               ViewCount = item.ViewCount
                           })
                           .OrderByDescending(item => item.ViewCount)
                           .Take(5)
                           .ToList();

            return View("/Views/New/Detail.cshtml", Post);
        }


    }
}
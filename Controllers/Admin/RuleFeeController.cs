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
    [Route("/admin/rule/fee")]
    public class RuleFeeController : Controller
    {

        private readonly ApplicationDbContext db;

        public RuleFeeController(ApplicationDbContext db)
        {

            this.db = db;
        }

        [HttpGet]
        public IActionResult Index()
        {
             

            var Categories = db.Authors.OrderBy(item => item.Id).ToList();

            return View("/Views/Admin/book/Author.cshtml", Categories);
        }

        [HttpGet("search")]

        public IActionResult Search(string query)
        {
            
            query = "%" + query + "%";
            
            var Categories = db.Authors
                               .Where(item => EF.Functions.ILike(item.Name, query)
                                              || EF.Functions.ILike(item.Description, query)
                                      )
                               .OrderBy(item => item.Id).ToList();

            return View("/Views/Admin/book/Author.cshtml", Categories);
        }


        //=== add Author

        [HttpPost]
        public IActionResult Create([FromForm] Author model)
        {

            if (ModelState.IsValid)
            {
                // var found = db.Authors.Any(item => item.Name == model.Name);

                // check Author found

                // if (found)
                // {
                //     ModelState.AddModelError("Found Author", "Author name is found");
                // }

                // add Author

                db.Authors.Add(model);
                db.SaveChanges();

                // alert success to view
                TempData["message"] = "Create Author success";
            }

            return RedirectToAction("Index");

        }

        //=== edit Author

        [HttpPost("update/{id}")]
        public IActionResult Update(int id, [FromForm] Author model)
        {

            if (ModelState.IsValid)
            {
                var found = db.Authors.Find(id);

                // check Author found

                if (found == null)
                {
                    ModelState.AddModelError("Found Author", "Author not found");
                }

                // add Author

                found.Name = model.Name;
                found.Description = model.Description;

                db.SaveChanges();

                // alert success to view
                TempData["message"] = "Update Author success";
            }

            return RedirectToAction("Index");

        }

        //=== delete Author

        [HttpPost("delete/{id}")]

        public IActionResult Delete(int id)
        {

            var found = db.Authors.Find(id);

            // check Author found

            if (found == null)
            {
                ModelState.AddModelError("Found Author", "Author not found");
            }

            db.Authors.Remove(found);
            db.SaveChanges();

            TempData["message"] = "Delete Author success";

            return RedirectToAction("Index");
        }



    }
}
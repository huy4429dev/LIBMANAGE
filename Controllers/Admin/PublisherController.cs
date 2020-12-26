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
    [Route("/admin/book/publisher")]
    public class PublisherController : Controller 
    {

        private readonly ApplicationDbContext db;

        public PublisherController(ApplicationDbContext db)
        {

            this.db = db;
        }

        [HttpGet]
        public IActionResult Index()
        {
             

            var Publishers = db.Publishers.OrderBy(item => item.Id).ToList();

            return View("/Views/admin/book/Publisher.cshtml", Publishers);
        }

        [HttpGet("search")]

        public IActionResult Search(string query)
        {
            
            query = "%" + query + "%";
            
            var Publishers = db.Publishers
                               .Where(item => EF.Functions.ILike(item.Name, query)
                                              || EF.Functions.ILike(item.Description, query)
                                      )
                               .OrderBy(item => item.Id).ToList();

            return View("/Views/admin/book/Publisher.cshtml", Publishers);
        }


        //=== add Publisher

        [HttpPost]
        public IActionResult Create([FromForm] Publisher model)
        {

            if (ModelState.IsValid)
            {
                // var found = db.Publishers.Any(item => item.Name == model.Name);

                // check Publisher found

                // if (found)
                // {
                //     ModelState.AddModelError("Found Publisher", "Publisher name is found");
                // }

                // add Publisher

                db.Publishers.Add(model);
                db.SaveChanges();

                // alert success to view
                TempData["message"] = "Create Publisher success";
            }

            return RedirectToAction("Index");

        }

        //=== edit Publisher

        [HttpPost("update/{id}")]
        public IActionResult Update(int id, [FromForm] Publisher model)
        {

            if (ModelState.IsValid)
            {
                var found = db.Publishers.Find(id);

                // check Publisher found

                if (found == null)
                {
                    ModelState.AddModelError("Found Publisher", "Publisher not found");
                }

                // add Publisher

                found.Name = model.Name;
                found.Description = model.Description;

                db.SaveChanges();

                // alert success to view
                TempData["message"] = "Update Publisher success";
            }

            return RedirectToAction("Index");

        }

        //=== delete Publisher

        [HttpPost("delete/{id}")]

        public IActionResult Delete(int id)
        {

            var found = db.Publishers.Find(id);

            // check Publisher found

            if (found == null)
            {
                ModelState.AddModelError("Found Publisher", "Publisher not found");
            }

            db.Publishers.Remove(found);
            db.SaveChanges();

            TempData["message"] = "Delete Publisher success";

            return RedirectToAction("Index");
        }



    }
}
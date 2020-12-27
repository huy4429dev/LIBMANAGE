using System;
using System.Linq;
using System.Collections.Generic;
using LibManage.Data;
using LibManage.Models;
using Microsoft.AspNetCore.Mvc;
using LibManage.Services;

namespace LibManage.Controllers
{

    [Route("/test")]
    public class TestController : Controller
    {

        private ApplicationDbContext db;
        public TestController(ApplicationDbContext db)
        {
            this.db = db;
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.products = db.Tests.ToList();
            
            return View("/Views/Test/Index.cshtml");
        }

        [HttpGet("{id}")]
        public IActionResult GetOne(int id)
        {
            return View("/Views/Test/Index.cshtml");
        }

    }
}
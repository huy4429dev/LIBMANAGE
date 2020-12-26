using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using LibManage.Models;
using LibManage.Data;
using LibManage.Extension;
using LibManage.ViewModels;
using Microsoft.AspNetCore.Mvc;
namespace LibManage.Admin.Controllers
{

    [Route("/admin/report")]
    public class ReportController : Controller {

        private ApplicationDbContext db; 
        public ReportController (ApplicationDbContext db){
            this.db = db;
        }   

        [HttpGet("order")]
        public IActionResult OrderReport () {
            return View("/Views/Admin/Report/OrderReport.cshtml");
        }

        [HttpGet("book")]
        public IActionResult BookReport () {
            return Ok("report book");
        }

        [HttpGet("customer")]
        public IActionResult CustomerReport () {
            return View("/Views/Admin/Report/CustomerReport.cshtml");
        }

        [HttpGet("employee")]
        public IActionResult EmployeeReport () {
            return View("/Views/Admin/Report/EmployeeReport.cshtml");
        }

    }
}
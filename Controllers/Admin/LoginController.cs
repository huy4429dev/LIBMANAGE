using System;
using System.Linq;
using System.Collections.Generic;
using LibManage.Data;
using LibManage.Models;
using Microsoft.AspNetCore.Mvc;
using LibManage.Services;
using LibManage.ViewModels;
using LibManage.Extension;
using Microsoft.AspNetCore.Http;

namespace LibManage.Controllers
{
    public class LoginController : Controller
    {
        private readonly ApplicationDbContext db;

        public LoginController(ApplicationDbContext db)
        {

            // create a function

            this.db = db;
        }


        [HttpGet("admin/login")]
        public IActionResult Index()
        {


            var user = HttpContext.Session.Get<User>("user");

            if (user != null)
            {
                return RedirectToAction("Index", "DashBoard");
            }

            return View("/Views/Admin/Login/Index.cshtml");

        }


        [HttpPost("admin/login")]
        public IActionResult Login([FromForm] LoginViewModel model)
        {

            if (ModelState.IsValid)
            {
                string UserName = model.UserName;
                string Password = AesOperation.EncryptString("mot cai key khong thang nao biet", model.Password);
                // string Password = model.Password;

                var found = db.Users
                            .FirstOrDefault(item =>
                                                          item.Username == UserName &&
                                                          item.Password == Password && 
                                                          item.UserRoles.Any(u => u.Role.Name == "Admin" || u.Role.Name == "Librarian" )
                                                    )
                            ;

                if (found != null)
                {
                    HttpContext.Session.Set<User>("user", new User
                    {
                        Username = found.Username,
                        Id = found.Id,
                        UserRoles = found.UserRoles,
                        Email  = found.Email,
                        FullName = found.FullName
                        
                    });

                    return RedirectToAction("Index", "DashBoard");
                }

                // Check user name and password 
                ModelState.AddModelError(string.Empty, "Username or Password incorrect");

            }

            return View("/Views/Admin/Login/Index.cshtml");

        }


        [HttpGet("admin/logout")]
        public IActionResult LogOut(){

            HttpContext.Session.Clear();

            return RedirectToAction("Index", "Login");
        }

    }
}
using System;
using System.Linq;
using System.Collections.Generic;
using LibManage.Data;
using LibManage.Models;
using Microsoft.AspNetCore.Mvc;
using LibManage.Services;


namespace LibManage.Controllers
{
    public class AdminController : Controller
    {

        private readonly ApplicationDbContext db;

        public AdminController(ApplicationDbContext db)
        {

            this.db = db;  // create object dbcontext to manipulation db  
        }


        [HttpGet("admin/make-admin")]
        public IActionResult CreateAdmin()
        {

            string key = "mot cai key khong thang nao biet";

            var roleAdmin = new Role
            {
                Name = "Admin"
            };

            db.Roles.Add(roleAdmin);

            var roleLibrarian = new Role
            {
                Name = "Librarian"
            };

            db.Roles.Add(roleLibrarian);

            var roleCustomer = new Role
            {
                Name = "Customer"
            };


            db.Roles.Add(roleCustomer);

            db.SaveChanges();


            var admin = new User
            {
                Username = "admin",
                Email = "admin@gmail.com",
                Status = true,
                Password = AesOperation.EncryptString(key, "123456"),
                CreatTime = DateTime.Now,
                UserRoles = new List<UserRole> {
                    new UserRole {
                        Role = roleAdmin
                    }
                },
            };

            db.Users.Add(admin);

            var customer = new User
            {
                Username = "customer",
                Email = "customer@gmail.com",
                Status = true,
                Password = AesOperation.EncryptString(key, "123456"),
                CreatTime = DateTime.Now,
                UserRoles = new List<UserRole> {
                    new UserRole {
                        Role = roleCustomer
                    }
                },
            };

            db.Users.Add(customer);

            var librarian = new User
            {
                Username = "librarian",
                Email = "librarian@gmail.com",
                Status = true,
                Password = AesOperation.EncryptString(key, "123456"),
                CreatTime = DateTime.Now,
                UserRoles = new List<UserRole> {
                    new UserRole {
                        Role = roleLibrarian
                    }
                },
            };

            db.Users.Add(librarian);
            db.SaveChanges();

            return Ok("admin created !");
        }



    }
}
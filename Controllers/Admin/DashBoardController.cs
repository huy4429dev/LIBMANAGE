using System;
using System.Linq;
using System.Collections.Generic;
using LibManage.Data;
using LibManage.Models;
using Microsoft.AspNetCore.Mvc;
using LibManage.Services;
using LibManage.Extension;
using Microsoft.EntityFrameworkCore;
using LibManage.ViewModels;

namespace LibManage.Controllers
{
    public class DashBoardController : Controller
    {

        private readonly ApplicationDbContext db;

        public DashBoardController(ApplicationDbContext db)
        {

            // create a function

            this.db = db;  // create object dbcontext to manipulation db 
        }


        [HttpGet("admin/test")]
        public IActionResult Test ()
        {
            return Ok("TEST --------- 1");
        }


        [HttpGet("admin/dashboard")]
        public IActionResult Index()
        {

            // check login 

            var user = HttpContext.Session.Get<User>("user"); // lấy thông tin user dang đăng nhập 

            if (user == null)
            {
                return RedirectToAction("Index", "Login"); // chưa đăng nhập về trang đăng nhập
            }
            ViewData["User"] = new User
            {
                Username = user.Username
            };

            // thong ke trong thang hien tai 

            const int DATE_GAN_TRA = 4;

            var Now = DateTime.Now;
            var PerMonth = Now.Month;
            var PerYear = Now.Year;
            var Date = new DateTime(PerYear, PerMonth, 1);
            var ADD_NOW_DATE_GAN_TRA = Now.AddDays(DATE_GAN_TRA);

            var FirstDayOfWeek = Now.StartOfWeek(DayOfWeek.Monday);
            var LastDayOfWeek = Now.StartOfWeek(DayOfWeek.Sunday);

            //  COUNT CURRENT MONTH 

            ViewBag.TotalNewCustomer = db.Users
                                        .Where(u => u.CreatTime > Date &&
                                                    u.UserRoles.Any(r => r.Role.Name == "Customer")
                                              )
                                        .Count();

            ViewBag.TotalBook_Muon = db.Orders
                                       .Where(o => o.CreatedTime > Date)
                                       .Sum(o => o.OrderDetails.Sum(d => d.Quantity));


            ViewBag.TotalBook_Phai_Tra = db.Orders
                                       .Where(o => o.CreatedTime > Date
                                                 && o.TimeEnd < ADD_NOW_DATE_GAN_TRA
                                                 && o.Status == OrderStatus.Pendding
                                                 )
                                       .Sum(o => o.OrderDetails.Sum(d => d.Quantity));

            ViewBag.TotalBook_Qua_Han = db.Orders
                                       .Where(o => o.CreatedTime > Date
                                                 && o.TimeEnd < Now
                                                 && o.Status == OrderStatus.Pendding
                                                 )
                                       .Sum(o => o.OrderDetails.Sum(d => d.Quantity));


            // SO LIEU BIEU DO 

            var TotalNewCustomerPerWeek = db.Users
                                        .Where(u => u.CreatTime > FirstDayOfWeek &&
                                                    u.UserRoles.Any(r => r.Role.Name == "Customer")
                                              )
                                        .GroupBy(u => u.CreatTime.Date)
                                        .Select(g => new
                                        {
                                            g.Key,
                                            Count = g.Count()
                                        })
                                        .ToList();

            //   var TotalBook_MuonPerWeek = db.OrderDetails
            //                             .Where(d => d.CreatedTime > FirstDayOfWeek)
            //                             .GroupBy(d => d.OrderId)
            //                             .Select(g => new
            //                             {
            //                                 OrderId = g.Key,
            //                                 Quantity = g.Sum(d => d.Quantity)
            //                             })
            //                             .Join(db.Orders,
            //                                 o1 => o1.OrderId, 
            //                                 o2 => o2.Id,
            //                                 (o1, o2) => new {
            //                                     OrderId = o1.OrderId, 
            //                                     Quantity = o1.Quantity,  
            //                                     CreatedTime = o2.CreatedTime
            //                                 } 
            //                             )
            //                             .GroupBy(o => o.CreatedTime.Date)
            //                             .Select(g2 => new {
            //                                 g2.Key,
            //                                 Quantity = g2.Sum(g22 => g22.Quantity)
            //                             })
            //                             .ToList();

            var TotalBook_MuonPerWeek = db.Orders
                                    .Where(o => o.CreatedTime > FirstDayOfWeek)
                                    .Select(o => new
                                    {
                                        OrderId = o.Id,
                                        Quantity = o.OrderDetails.Sum(d => d.Quantity),
                                        CreatedTime = o.CreatedTime

                                    })
                                    .GroupBy(o => o.CreatedTime.Date)
                                    .Select(g2 => new
                                    {
                                        g2.Key,
                                        Quantity = g2.Sum(g22 => g22.Quantity)
                                    })
                                    .ToList();


            var TotalBook_Phai_Tra_PerMonth = db.Orders
                                    .Where(o => o.CreatedTime > FirstDayOfWeek
                                                && o.TimeEnd < ADD_NOW_DATE_GAN_TRA
                                                && o.Status == OrderStatus.Pendding
                                                )
                                     .Select(o => new
                                     {
                                         OrderId = o.Id,
                                         Quantity = o.OrderDetails.Sum(d => d.Quantity),
                                         CreatedTime = o.CreatedTime

                                     })
                                    .GroupBy(o => o.CreatedTime.Date)
                                    .Select(g2 => new
                                    {
                                        g2.Key,
                                        Quantity = g2.Sum(g22 => g22.Quantity)
                                    })
                                    .ToList();

            var TotalBook_Qua_Han_PerMoth = db.Orders
                                       .Where(o => o.CreatedTime > FirstDayOfWeek
                                                 && o.TimeEnd < Now
                                                 && o.Status == OrderStatus.Pendding
                                                 )
                                        .Select(o => new
                                        {
                                            OrderId = o.Id,
                                            Quantity = o.OrderDetails.Sum(d => d.Quantity),
                                            CreatedTime = o.CreatedTime

                                        })
                                        .GroupBy(o => o.CreatedTime.Date)
                                        .Select(g2 => new
                                        {
                                            g2.Key,
                                            Quantity = g2.Sum(g22 => g22.Quantity)
                                        })
                                        .ToList();

            ViewBag.ListBookOrders = db.OrderDetails.Select(d => new
            {

                Name = d.Book.Title,
                BookId = d.Book.Id,
                Quantity = d.Quantity
            })
            .GroupBy(b => b.BookId)
            .Select(g => new
            {
                BookId = g.Key,
                Count = g.Sum(g2 => g2.Quantity)
            })
            .Join(db.Books,
                                            o1 => o1.BookId,
                                            o2 => o2.Id,
                                            (o1, o2) => new ListBookDashBoard
                                            {
                                                BookId = o1.BookId,
                                                CountDiscount = o1.Count,
                                                Title = o2.Title, 
                                                Quantity = o2.Quantity 
                                            }
             )
            .ToList();


            ViewBag.Chart_PerMonth = new
            {

                TotalNewCustomerPerWeek,
                TotalBook_Qua_Han_PerMoth,
                TotalBook_Phai_Tra_PerMonth,
                TotalBook_MuonPerWeek,
                FirstDayOfWeek

            };

            // SO LIEU BANG 

            return View("/Views/Admin/Dashboard/Index.cshtml");

        }
     
    }
}
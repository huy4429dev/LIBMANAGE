using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using LibManage.Data;
using LibManage.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using LibManage.Extension;

namespace LibManage.Controllers
{
    [Route("/checkout")]
    public class CheckoutController : Controller
    {

        private ApplicationDbContext db;
        public CheckoutController(ApplicationDbContext db)
        {
            this.db = db;
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Customer = HttpContext.Session.Get<User>("customer");
            var cart = HttpContext.Session.GetString("cart");
            var dataCart = new List<Cart>();
            if (cart != null)
            {
                dataCart = JsonConvert.DeserializeObject<List<Cart>>(cart);
                if (dataCart.Count > 0)
                {
                    ViewBag.carts = dataCart;
                }
            }

            ViewBag.dataCart = dataCart;
            return View("Views/Checkout/Index.cshtml");
        }

        [HttpPost]
        public IActionResult Create([FromForm] User model)
        {
            var user = HttpContext.Session.Get<User>("customer");
            var cart = HttpContext.Session.GetString("cart");
            SkipModelValidate("Password");
            SkipModelValidate("Username");
            if (string.IsNullOrWhiteSpace(model.Address))
            {
                ModelState.AddModelError(string.Empty, "Vui lòng nhập địa chỉ");
            }
            if (string.IsNullOrWhiteSpace(model.Phone))
            {
                ModelState.AddModelError(string.Empty, "Vui lòng nhâp số điện thoại");
            }
            if (cart == null)
            {
                ModelState.AddModelError(string.Empty, "Bạn chưa lựa chọn sản phẩm nào đệ mượn");
            }
            if (ModelState.IsValid)
            {
                var dataCart = new List<Cart>();
                if (cart != null)
                {
                    dataCart = JsonConvert.DeserializeObject<List<Cart>>(cart);
                    if (dataCart.Count > 0)
                    {
                        ViewBag.carts = dataCart;
                    }
                }

                var customer = db.Users.First(item => item.Id == user.Id);

                    customer.Email = model.Email;
                    customer.FullName = model.FullName;
                    customer.Address = model.Address;
                    customer.Phone = model.Phone;

                HttpContext.Session.Set<User>("customer", new User
                {
                    Username = user.Username,
                    Id = user.Id,
                    UserRoles = user.UserRoles,
                    Email = model.Email,
                    FullName = model.FullName,
                    Address = model.Address,
                    Phone = model.Phone

                });

                var listItems = new List<OrderDetail>();
                
                dataCart.ForEach(item => {
                    listItems.Add(new OrderDetail {
                        BookId = item.Product.Id,
                        Quantity = item.Quantity
                    });
                });

                var CurrentTime = DateTime.Now;

                var Order = new Order {
                    Amount = 0,
                    PenaltyFee = 0,
                    Note = "Chưa xử lý",
                    Status = OrderStatus.NoProcess, 
                    UserId = user.Id, 
                    OrderDetails = listItems,
                    CreatedTime = CurrentTime,
                    UpdatedTime = CurrentTime,
                    FromDate = CurrentTime,
                    ToDate = CurrentTime.AddDays(3),
                    
                };

                db.Orders.Add(Order);
                db.SaveChanges();

                HttpContext.Session.Remove("cart");

                TempData["Message"] = "Tạo phiếu mượn thành công, thư viện sẽ phản hồi lại cho bạn";
            }
            else
            {
                foreach (var modelStateKey in ModelState.Keys)
                {
                    var modelStateVal = ModelState[modelStateKey];
                    foreach (var error in modelStateVal.Errors)
                    {
                        TempData["Error"] = error.ErrorMessage;
                    }
                }
            }

            return Redirect(Request.Headers["Referer"].ToString());
        }

        private void SkipModelValidate(string keyword)
        {
            if (ModelState != null)
            {
                foreach (var item in ModelState)
                {
                    if (item.Key.Contains(keyword))
                    {
                        ModelState.Remove(item.Key);
                    }
                }
            }
        }


    }
}
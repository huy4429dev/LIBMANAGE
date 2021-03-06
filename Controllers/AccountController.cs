using System.Linq;
using LibManage.Data;
using LibManage.Models;
using Microsoft.AspNetCore.Mvc;
using LibManage.Services;
using LibManage.ViewModels;
using LibManage.Extension;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using PayPal.Core;
using PayPal;
using PayPal.v1.Payments;
using System.Threading.Tasks;
using BraintreeHttp;

namespace LibManage.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext db;

        public AccountController(ApplicationDbContext db)
        {

            // create a function

            this.db = db;
        }

        [HttpGet]
        public IActionResult Index()
        {

            var user = HttpContext.Session.Get<User>("customer");

            if (user != null)
            {
                return RedirectToAction("Index", "Home");
            }

            return View("/Views/Account/Index.cshtml");
        }


        [HttpPost("customer/login")]
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
                                                          item.Password == Password
                                                    )
                            ;

                if (found != null)
                {
                    HttpContext.Session.Set<User>("customer", new User
                    {
                        Username = found.Username,
                        Id = found.Id,
                        UserRoles = found.UserRoles,
                        Email = found.Email,
                        FullName = found.FullName,
                        Address = found.Address,
                        Phone = found.Phone

                    });

                    return Redirect(Request.Headers["Referer"].ToString());
                }

                TempData["Error"] = "Sai tên đăng nhập hoặc mật khẩu";


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

            return View("/Views/Account/Index.cshtml");

        }


        [HttpGet("customer/logout")]
        public IActionResult LogOut()
        {

            HttpContext.Session.Clear();
            return Redirect(Request.Headers["Referer"].ToString());
        }


        [HttpPost("customer/register")]
        public IActionResult RegisterCustomer([FromForm] User model)
        {
            string key = "mot cai key khong thang nao biet";
            var RoleCustomer = db.Roles.FirstOrDefault(r => r.Name == "Customer");
            if (db.Users.Any(item => item.Username == model.Username))
            {
                ModelState.AddModelError(string.Empty, "Tên tài khoản đã được sử dụng");
            }

            if (db.Users.Any(item => item.Email == model.Email))
            {
                ModelState.AddModelError(string.Empty, "Địa chỉ email đã được sử dụng");
            }

            if (ModelState.IsValid)
            {
                var customer = new User
                {
                    Username = model.Username,
                    Email = model.Email,
                    FullName = model.FullName,
                    Status = true,
                    Password = AesOperation.EncryptString(key, model.Password),
                    CreatTime = DateTime.Now,
                    UserRoles = new List<UserRole> {
                        new UserRole {
                            Role = RoleCustomer
                        }
                    },
                };

                db.Users.Add(customer);
                db.SaveChanges();

                TempData["Message"] = "Tạo tài khoản thành công";
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

            return RedirectToAction("Index");
        }

        [HttpGet("customer/profile")]
        public IActionResult Profile()
        {

            var user = HttpContext.Session.Get<User>("customer");

            ViewBag.TotalBookOrder = db.Orders.Where(item => item.UserId == user.Id)
                                               .SelectMany(item => item.OrderDetails)
                                               .Sum(o => o.Quantity);

            ViewBag.TotalBookOrderIncomplete = db.Orders.Where(item => item.UserId == user.Id &&
                                                             item.Status != OrderStatus.Success &&
                                                             item.Status != OrderStatus.Dispose)
                                               .SelectMany(item => item.OrderDetails)
                                               .Sum(o => o.Quantity);

            ViewBag.Orders = db.Orders.Select(item => new Models.Order
            {
                Id = item.Id,
                OrderDetails = item.OrderDetails.Select(d => new OrderDetail
                {
                    Quantity = d.Quantity,
                    Book = new Book
                    {
                        Title = d.Book.Title,
                        Authors = d.Book.Authors,
                        Publishers = d.Book.Publishers,
                        Image = d.Book.Image
                    }
                }).ToList(),
                Status = item.Status,
                CreatedTime = item.CreatedTime
            }).ToList();

            if (user == null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View("/Views/Account/Profile.cshtml");
        }

        [HttpPost("customer/update")]
        public async Task<IActionResult> EditProfle([FromForm] User model)
        {


            var user = HttpContext.Session.Get<User>("customer");
            if (user == null)
            {
                return RedirectToAction("Index", "Home");
            }
            string key = "mot cai key khong thang nao biet";
            SkipModelValidate("Password");
            SkipModelValidate("Username");
            if (ModelState.IsValid)
            {
                var customer = db.Users.Find(user.Id);
                customer.Email = model.Email;
                customer.FullName = model.FullName;
                customer.Address = model.Address;
                customer.Phone = model.Phone;
                customer.Address = model.Address;
                customer.Email = model.Email;
                HttpContext.Session.Set<User>("customer", new User
                {
                    Username = user.Username,
                    Id = user.Id,
                    UserRoles = user.UserRoles,
                    Email = customer.Email,
                    FullName = customer.FullName,
                    Address = customer.Address,
                    Phone = customer.Phone

                });
                if (model.Password != null)
                {
                    customer.Password = AesOperation.EncryptString(key, model.Password);
                }
                db.SaveChanges();
                TempData["Message"] = "Cập nhật tài khoản thành công";
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


        [HttpGet("thanh-toan")]
        public async Task<IActionResult> Payment()
        {
            var environment = new SandboxEnvironment("Abm64fb2pMsiOB3-qjZ2wPR24vpvTFKLz1vsXd5wKZdnAcJGGEOBweT2zYUsJHGJ_DcSsRQzIiIJBuqd",
             "EK3hTnRuHU7HKT9qbkzLe4Rp7iyJrSSJVWkPEmk1m7EDc9z8uS7YO5ZHt0yQAUzpkQA-AUTW4N3JG5Up");
            var client = new PayPalHttpClient(environment);

            var itemList = new ItemList()
            {
                Items = new List<Item>()
            };

            var Total = 1000;

            itemList.Items.Add(new Item()
            {
                Currency = "USD",
                Description = "LOL",
                Name = "THANH TOAN PHAT",
                Price = "200",
                Quantity = "1",
                Sku = "sku",
                Tax = "0",
            });

            var payment = new Payment()
            {
                Intent = "Sale",
                Transactions = new List<Transaction>()
                {
                    new Transaction()
                    {
                        Amount = new Amount()
                        {
                            Total = "10",
                            Currency = "USD"
                        }
                    }
                },
                RedirectUrls = new RedirectUrls()
                {
                    CancelUrl = "https://localhost:5001/thanh-toan/thanh-cong",
                    ReturnUrl = "https://localhost:5001/thanh-toan/that-bai"
                },
                Payer = new Payer()
                {
                    PaymentMethod = "paypal"
                }
            };

            PaymentCreateRequest request = new PaymentCreateRequest();
            request.RequestBody(payment);

            try
            {
                var response = await client.Execute(request);
                var statusCode = response.StatusCode;
                Payment result = response.Result<Payment>();

                var links = result.Links.GetEnumerator();
                string paypalRedirectUrl = null;
                while (links.MoveNext())
                {
                    LinkDescriptionObject lnk = links.Current;
                    if (lnk.Rel.ToLower().Trim().Equals("approval_url"))
                    {
                        //saving the payapalredirect URL to which user will be redirected for payment  
                        paypalRedirectUrl = lnk.Href;
                    }
                }

                return Redirect(paypalRedirectUrl);
            }
            catch (HttpException httpException)
            {
                var statusCode = httpException.StatusCode;
                var debugId = httpException.Headers.GetValues("PayPal-Debug-Id").FirstOrDefault();

                //Process when Checkout with Paypal fails
                return Redirect("thanh-toan/that-bai");
            }
        }

        [HttpGet("thanh-toan/thanh-cong")]
        public IActionResult PaymentSuccess()
        {
            return Ok("payment success");
        }


        [HttpGet("thanh-toan/that-bai")]
        public IActionResult PaymentDispose()
        {
            return Ok("payment bad");
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
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using LibManage.Data;
using LibManage.Models;
using LibManage.ViewModels;
using System.Collections.Generic;
using LibManage.Services;
using LibManage.Extension;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace LibManage.Controllers
{
    [Route("/cart")]
    public class CartController : Controller
    {

        private ApplicationDbContext db;
        public CartController(ApplicationDbContext db)
        {
            this.db = db;
        }

        [HttpGet]
        public IActionResult Index()
        {


            var cart = HttpContext.Session.GetString("cart");//get key cart
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

            return View("/Views/Cart/Index.cshtml");
        }

        [HttpGet("add/{id}")]
        public IActionResult AddItem(int id)
        {

            var cart = HttpContext.Session.GetString("cart");//get key cart
            var dataCart = new List<Cart>();
            if (cart == null)
            {
                var product = db.Books
                            .Where(item => item.Id == id)
                            .Select(item => new Book
                            {
                                Id = item.Id,
                                Title = item.Title,
                                Image = item.Image,
                                Rate = item.Rate,
                                Authors = item.Authors,
                                Publisher = item.Publisher,
                                BookTpye = item.BookTpye,
                                Description = item.Description,
                                BookTypes = item.BookTypes,
                                CreatedTime = item.CreatedTime
                            })
                            .First();;
               dataCart = new List<Cart>()
               {
                   new Cart
                   {
                       Product = product,
                       Quantity = 1
                   }
               };
                HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(dataCart));

            }
            else
            {
                dataCart = JsonConvert.DeserializeObject<List<Cart>>(cart);
                bool check = true;
                for (int i = 0; i < dataCart.Count; i++)
                {
                    if (dataCart[i].Product.Id == id)
                    {
                        dataCart[i].Quantity++;
                        check = false;
                    }
                }

                if (check)
                {
                    dataCart.Add(new Cart
                    {
                        Product = db.Books.Find(id),
                        Quantity = 1
                    });
                }
                HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(dataCart));
            }
                return Ok(new {
                    dataCart, 
                    message = "Add product success"
                });
        }

        [HttpGet("remove/{id}")]
        public IActionResult RemoveItem(int id)
        {

            var cart = HttpContext.Session.GetString("cart");

                List<Cart> dataCart = JsonConvert.DeserializeObject<List<Cart>>(cart);
                var itemToRemove = dataCart.FirstOrDefault(r => r.Product.Id == id);
                dataCart.Remove(itemToRemove);
                HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(dataCart));
                return Ok(new {
                    dataCart, 
                    message = "Remove product success"
                });
        }
    }
    public class Cart
    {
        public Book Product { get; set; }
        public int Quantity { get; set; }
    }

    public class CartItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
}
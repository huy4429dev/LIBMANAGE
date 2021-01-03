using Microsoft.AspNetCore.Mvc;
using LibManage.Data;
using LibManage.Models;
using LibManage.ViewModels;
using System.Linq;
using System;
using Microsoft.Extensions.Configuration;
using LibManage.Extension;
using Microsoft.EntityFrameworkCore;
using ClosedXML.Excel;
using System.IO;
using System.Globalization;

namespace LibManage.Admin.Controllers
{
    [Route("/admin/order")]
    public class OrderController : Controller
    {
        private ApplicationDbContext db;
        private IConfiguration configuration;
        public OrderController(ApplicationDbContext db, IConfiguration configuration)
        {
            this.db = db;
            this.configuration = configuration;
        }

        [HttpGet]
        public IActionResult Index()
        {

            var data = db.Orders.Include(x => x.User)
                                .OrderByDescending(item => item.CreatedTime)
                                .ToList();

            return View("/Views/Admin/Order/Index.cshtml", data);
        }


        [HttpGet("{id}")]
        public IActionResult Detail(int id)
        {

            var data = db.Orders.Where(item => item.Id == id)
                                 .Select(item => new Order
                                 {
                                     OrderDetails = item.OrderDetails.Select(d => new OrderDetail
                                     {
                                         Book = new Book
                                         {
                                             Title = d.Book.Title,
                                             Authors = d.Book.Authors,
                                             Publishers = d.Book.Publishers,
                                             Quantity = d.Quantity,
                                             Image = d.Book.Image
                                         },
                                         Quantity = d.Quantity
                                     }).ToList(),
                                     User = item.User,
                                     Id = item.Id,
                                     Amount = item.Amount,
                                     PenaltyFee = item.PenaltyFee,
                                     TimeEnd = item.TimeEnd,
                                     Note = item.Note,
                                     Status = item.Status,
                                     FromDate = item.FromDate,
                                     ToDate = item.ToDate
                                 })
                                 .FirstOrDefault()
                ;

            return View("/Views/Admin/Order/Detail.cshtml", data);
        }

        [HttpPost("{id}")]
        public IActionResult Update(int id, [FromForm] Order model)
        {

            string RangeTime = Request.Form["datetimes"];
            var FromDate = DateTime.ParseExact(RangeTime.Substring(0, RangeTime.IndexOf("-")).Trim(), "hh:mm tt dd/MM/yyyy", CultureInfo.InvariantCulture);
            var ToDate = DateTime.ParseExact(RangeTime.Substring(RangeTime.IndexOf("-") + 1).Trim(), "hh:mm tt dd/MM/yyyy", CultureInfo.InvariantCulture);
            // check time valid 

            var TimeValid = (ToDate - FromDate).TotalDays;

            if (TimeValid > 10)
            {
                TempData["Error"] = "Khách hàng này không được mượn sách quá 10 ngày";
            }
            else
            {

                var Order = db.Orders.Include(o => o.OrderDetails).FirstOrDefault(o => o.Id == id);
                var CountBookValid = Order.OrderDetails.Count();

                if (CountBookValid > 3)
                {

                    TempData["Error"] = "Khách hàng này không được mượn số lượng sách quá 3 quyển";
                }

                Order.Status = model.Status;
                Order.FromDate = FromDate;
                Order.ToDate = ToDate;

                db.SaveChanges();

                TempData["Success"] = "Cập nhật trạng thái phiếu mượn thành công";
            }


            return Redirect(Request.Headers["Referer"].ToString());
        }

        [HttpGet("export/{id}")]
        public IActionResult Excel(int id)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Orders");
                var currentRow = 1;
                worksheet.Cell(currentRow, 1).Value = "Id";
                worksheet.Cell(currentRow, 2).Value = "Tên khách hàng";
                worksheet.Cell(currentRow, 3).Value = "Điện thoại";
                worksheet.Cell(currentRow, 4).Value = "Email";
                worksheet.Cell(currentRow, 5).Value = "Địa chỉ";
                worksheet.Cell(currentRow, 6).Value = "Đơn giá";
                worksheet.Cell(currentRow, 7).Value = "Phí phạt";
                worksheet.Cell(currentRow, 8).Value = "Thành tiền";
                worksheet.Cell(currentRow, 9).Value = "Trạng thái";

                var order = db.Orders.Include(o => o.User).FirstOrDefault(o => o.Id == id);
                currentRow++;
                worksheet.Cell(currentRow, 1).Value = order.Id;
                worksheet.Cell(currentRow, 2).Value = order.User.Username;
                worksheet.Cell(currentRow, 3).Value = order.User.Phone + "\\";
                worksheet.Cell(currentRow, 4).Value = order.User.Email;
                worksheet.Cell(currentRow, 5).Value = order.User.Address;
                worksheet.Cell(currentRow, 7).Value = order.User;
                worksheet.Cell(currentRow, 7).Value = order.User;
                worksheet.Cell(currentRow, 8).Value = order.Amount;
                worksheet.Cell(currentRow, 9).Value = order.Status == OrderStatus.Success ? "Đã xử lý" : "Hoàn thành";

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    string count = DateTime.Now.Millisecond.ToString();
                    return File(
                        content,
                        "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                        "DH" + count + ".xlsx");
                }
            }
        }

    }
}
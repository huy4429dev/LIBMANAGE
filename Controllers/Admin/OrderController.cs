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

            var data = db.Orders.Include(x => x.User).ToList();

            return View("/Views/Admin/Order/Index.cshtml", data);
        }


        [HttpGet("{id}")]
        public IActionResult Detail(int id)
        {

            var data = db.Orders.Include(x => x.User).FirstOrDefault(item => item.Id == id);

            return View("/Views/Admin/Order/Detail.cshtml", data);
        }

        [HttpPost("{id}")]
        public IActionResult Update(int id, [FromForm] Order model)
        {
            var found = db.Orders.Find(id);
            found.Status = model.Status;
            db.SaveChanges();

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
                        "DH"+count+".xlsx");
                }
            }
        }

    }
}
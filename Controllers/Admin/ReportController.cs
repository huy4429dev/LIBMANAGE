using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using LibManage.Models;
using LibManage.Data;
using LibManage.Extension;
using LibManage.ViewModels;
using Microsoft.AspNetCore.Mvc;
using ClosedXML.Excel;
using System.IO;

namespace LibManage.Admin.Controllers
{

    [Route("/admin/report")]
    public class ReportController : Controller
    {

        private ApplicationDbContext db;
        public ReportController(ApplicationDbContext db)
        {
            this.db = db;
        }

        [HttpGet("order")]
        public IActionResult OrderReport(DateTime FromDate, DateTime ToDate)
        {

            ViewBag.Data = db.Orders.Select(o => new
            {
                o.CreatedTime,
                o.PenaltyFee,
                o.Status,
                TotalBook = o.OrderDetails.Sum(d => d.Quantity),
                CustomerId = o.User.Id
            })
            .GroupBy(g => g.CreatedTime.Date)
            .Select(g => new
            {
                Date = g.Key,
                Total = g.Count(),
                PenatyFee = g.Sum(o => o.PenaltyFee),
                TotalOrdrerSuccess = g.Sum(o => o.Status == OrderStatus.Success ? 1 : 0),
                TotalOrdrerDispose = g.Sum(o => o.Status == OrderStatus.Dispose ? 1 : 0),
                TotalOrdrerBorrowed = g.Sum(o => o.Status == OrderStatus.Borrowed ? 1 : 0),
                TotalOrdrerNoProcess = g.Sum(o => o.Status == OrderStatus.NoProcess ? 1 : 0),
                TotalOrdrerOverdue = g.Sum(o => o.Status == OrderStatus.Overdue ? 1 : 0),
                TotalBook = g.Sum(o => o.TotalBook),
                TotalCustomer = g.Select(o => o.CustomerId).Distinct().Count()
            });


            return View("/Views/Admin/Report/OrderReport.cshtml");
        }

        [HttpGet("order/ajax")]
        public IActionResult GetDataOrderReport(DateTime toDate, DateTime fromDate)
        {

            var data = db.Orders
            .Where(item => item.CreatedTime > toDate && item.CreatedTime < fromDate)
            .Select(o => new
            {
                o.CreatedTime,
                o.PenaltyFee,
                o.Status,
                TotalBook = o.OrderDetails.Sum(d => d.Quantity),
                CustomerId = o.User.Id
            })
             .GroupBy(g => g.CreatedTime.Date)
             .Select(g => new
             {
                 Date = g.Key,
                 Total = g.Count(),
                 PenatyFee = g.Sum(o => o.PenaltyFee),
                 TotalOrdrerSuccess = g.Sum(o => o.Status == OrderStatus.Success ? 1 : 0),
                 TotalOrdrerDispose = g.Sum(o => o.Status == OrderStatus.Dispose ? 1 : 0),
                 TotalOrdrerBorrowed = g.Sum(o => o.Status == OrderStatus.Borrowed ? 1 : 0),
                 TotalOrdrerNoProcess = g.Sum(o => o.Status == OrderStatus.NoProcess ? 1 : 0),
                 TotalOrdrerOverdue = g.Sum(o => o.Status == OrderStatus.Overdue ? 1 : 0),
                 TotalBook = g.Sum(o => o.TotalBook),
                 TotalCustomer = g.Select(o => o.CustomerId).Distinct().Count()
             });

            return Ok(new
            {
                data
            });
        }

        [HttpGet("order/excel")]
        public IActionResult ExportExcelReportOrder(DateTime? fromDate = null, DateTime? toDate = null)
        {

            if (!fromDate.HasValue)
            {
                fromDate = DateTime.Now;
                toDate = fromDate.Value.AddMonths(-1);
            }

            var data = db.Orders
            .Where(item => item.CreatedTime > toDate && item.CreatedTime < fromDate)
            .Select(o => new
            {
                o.CreatedTime,
                o.PenaltyFee,
                o.Status,
                TotalBook = o.OrderDetails.Sum(d => d.Quantity),
                CustomerId = o.User.Id
            })
             .GroupBy(g => g.CreatedTime.Date)
             .Select(g => new
             {
                 Date = g.Key,
                 Total = g.Count(),
                 PenatyFee = g.Sum(o => o.PenaltyFee),
                 TotalOrdrerSuccess = g.Sum(o => o.Status == OrderStatus.Success ? 1 : 0),
                 TotalOrdrerDispose = g.Sum(o => o.Status == OrderStatus.Dispose ? 1 : 0),
                 TotalOrdrerBorrowed = g.Sum(o => o.Status == OrderStatus.Borrowed ? 1 : 0),
                 TotalOrdrerNoProcess = g.Sum(o => o.Status == OrderStatus.NoProcess ? 1 : 0),
                 TotalOrdrerOverdue = g.Sum(o => o.Status == OrderStatus.Overdue ? 1 : 0),
                 TotalBook = g.Sum(o => o.TotalBook),
                 TotalCustomer = g.Select(o => o.CustomerId).Distinct().Count()
             });


            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Report order");
                var currentRow = 1;
                worksheet.Cell(currentRow, 1).Value = "Thời gian";
                worksheet.Cell(currentRow, 2).Value = "Lượt mượn";
                worksheet.Cell(currentRow, 3).Value = "Lượt trả đúng hạn";
                worksheet.Cell(currentRow, 4).Value = "Lượt trả trễ hạn";
                worksheet.Cell(currentRow, 5).Value = "Tiền nộp phạt";
                worksheet.Cell(currentRow, 6).Value = "Số sách mượn";
                worksheet.Cell(currentRow, 7).Value = "Số khách hàng";


                foreach (var item in data)
                {
                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = item.Date.ToString("dd/MM/yyyy");
                    worksheet.Cell(currentRow, 2).Value = item.Total;
                    worksheet.Cell(currentRow, 3).Value = item.TotalOrdrerSuccess;
                    worksheet.Cell(currentRow, 4).Value = item.TotalOrdrerOverdue;
                    worksheet.Cell(currentRow, 5).Value = item.PenatyFee;
                    worksheet.Cell(currentRow, 6).Value = item.TotalBook;
                    worksheet.Cell(currentRow, 7).Value = item.TotalCustomer;
                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    string count = DateTime.Now.Millisecond.ToString();
                    return File(
                        content,
                        "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                        "BC-LUOT-MUON" + count + ".xlsx");
                }
            }
        }

        [HttpGet("customer")]
        public IActionResult CustomerReport(DateTime FromDate, DateTime ToDate)
        {

            ViewBag.Data = db.Orders.Select(o => new
            {
                o.CreatedTime,
                o.PenaltyFee,
                o.Status,
                TotalBook = o.OrderDetails.Sum(d => d.Quantity),
                CustomerId = o.User.Id,
                Customer = o.User
            })
            .GroupBy(g => g.CreatedTime.Date)
            .Select(g => new
            {
                Date = g.Key,
                Total = g.Count(),
                TotalCustomer = g.Select(o => o.CustomerId).Distinct().Count(),
                TotalOldCustomer = g.Where(c => c.Customer.CreatTime < g.Key).Select(c => c.CustomerId).Distinct().Count(),
                TotalNewCustomer = g.Where(c => c.Customer.CreatTime >= g.Key).Select(c => c.CustomerId).Distinct().Count()
            });

            return View("/Views/Admin/Report/CustomerReport.cshtml");
        }

        [HttpGet("customer/ajax")]
        public IActionResult GetDataCustomerReport(DateTime toDate, DateTime fromDate)
        {
            var data = db.Orders
            .Where(item => item.CreatedTime > toDate && item.CreatedTime < fromDate)
           .Select(o => new
            {
                o.CreatedTime,
                o.PenaltyFee,
                o.Status,
                TotalBook = o.OrderDetails.Sum(d => d.Quantity),
                CustomerId = o.User.Id,
                Customer = o.User
            })
            .GroupBy(g => g.CreatedTime.Date)
            .Select(g => new
            {
                Date = g.Key,
                Total = g.Count(),
                TotalCustomer = g.Select(o => o.CustomerId).Distinct().Count(),
                TotalOldCustomer = g.Where(c => c.Customer.CreatTime < g.Key).Select(c => c.CustomerId).Distinct().Count(),
                TotalNewCustomer = g.Where(c => c.Customer.CreatTime >= g.Key).Select(c => c.CustomerId).Distinct().Count()
            });

            return Ok(new
            {
                data
            });
        }


        [HttpGet("employee")]
        public IActionResult EmployeeReport(DateTime FromDate, DateTime ToDate)
        {
            ViewBag.Data = db.Orders
            .Where(o => o.UserverifyId != null)
            .Select(o => new
            {
                o.CreatedTime,
                o.PenaltyFee,
                o.Status,
                TotalBook = o.OrderDetails.Sum(d => d.Quantity),
                CustomerId = o.User.Id, 
                o.Userverify
            })
            .GroupBy(g => g.Userverify.Username)
            .Select(g => new
            {
                userName = g.Key,
                Total = g.Count(),
                PenatyFee = g.Sum(o => o.PenaltyFee),
                TotalOrdrerSuccess = g.Sum(o => o.Status == OrderStatus.Success ? 1 : 0),
                TotalOrdrerDispose = g.Sum(o => o.Status == OrderStatus.Dispose ? 1 : 0),
                TotalOrdrerBorrowed = g.Sum(o => o.Status == OrderStatus.Borrowed ? 1 : 0),
                TotalOrdrerNoProcess = g.Sum(o => o.Status == OrderStatus.NoProcess ? 1 : 0),
                TotalOrdrerOverdue = g.Sum(o => o.Status == OrderStatus.Overdue ? 1 : 0),
                TotalBook = g.Sum(o => o.TotalBook),
                TotalCustomer = g.Select(o => o.CustomerId).Distinct().Count(),
            }).ToList();

            return View("/Views/Admin/Report/EmployeeReport.cshtml");
        }

        [HttpGet("employee/ajax")]
        public IActionResult GetDataEmployeeReport(DateTime toDate, DateTime fromDate)
        {

            var data = db.Orders
            .Where(item => item.CreatedTime > toDate && item.CreatedTime < fromDate)
            .Select(o => new
            {
                o.CreatedTime,
                o.PenaltyFee,
                o.Status,
                o.Userverify,
                TotalBook = o.OrderDetails.Sum(d => d.Quantity),
                CustomerId = o.User.Id
            })
             .GroupBy(g => g.Userverify.Id)
             .Select(g => new
             {
                 Date = g.Key,
                 Total = g.Count(),
                 PenatyFee = g.Sum(o => o.PenaltyFee),
                 TotalOrdrerSuccess = g.Sum(o => o.Status == OrderStatus.Success ? 1 : 0),
                 TotalOrdrerDispose = g.Sum(o => o.Status == OrderStatus.Dispose ? 1 : 0),
                 TotalOrdrerBorrowed = g.Sum(o => o.Status == OrderStatus.Borrowed ? 1 : 0),
                 TotalOrdrerNoProcess = g.Sum(o => o.Status == OrderStatus.NoProcess ? 1 : 0),
                 TotalOrdrerOverdue = g.Sum(o => o.Status == OrderStatus.Overdue ? 1 : 0),
                 TotalBook = g.Sum(o => o.TotalBook),
                 TotalCustomer = g.Select(o => o.CustomerId).Distinct().Count()
             });

            return Ok(new
            {
                data
            });
        }
    }
}
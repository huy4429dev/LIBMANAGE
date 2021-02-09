using System;
using System.Linq;
using System.Collections.Generic;
using LibManage.Data;
using LibManage.Models;
using Microsoft.AspNetCore.Mvc;
using LibManage.Services;
using Microsoft.EntityFrameworkCore;

namespace LibManage.Admin.Controllers
{
    [Route("/admin/Employee")]
    public class EmployeeController : Controller
    {

        private readonly ApplicationDbContext db;

        public EmployeeController(ApplicationDbContext db)
        {

            this.db = db;
        }


        public IActionResult Index()
        {

            var Employees = db.Users
                              .Where(item => item.UserRoles.Any(r => r.Role.Name.ToLower() == "librarian"))
                              .OrderBy(item => item.Id)
                              .ToList();

            return View("/Views/Admin/Employee/Index.cshtml", Employees);

        }

        [HttpGet("search")]

        public IActionResult Search(string query)
        {

            query = "%" + query + "%";

            var Employees = db.Users
                                  .Where(item => EF.Functions.ILike(item.Username, query)
                                                 || EF.Functions.ILike(item.Address, query)
                                         )
                               .OrderBy(item => item.Id).ToList();

            return View("/Views/Admin/Employee/Index.cshtml", Employees);
        }


        [HttpPost()]
        public IActionResult Create([FromForm] User model)
        {
            SkipModelValidate("ConfirmPassword");

            if (ModelState.IsValid)
            {

                var found = db.Users.Any(item => item.Username == model.Username || item.Email == model.Email);

                if (found)
                {
                    ModelState.AddModelError("Found Employee", "nhân viên đã tồn tại");
                }
                else
                {
                    string key = "mot cai key khong thang nao biet";
                    model.Status = true;
                    model.CreatTime = DateTime.Now;
                    model.Password = AesOperation.EncryptString(key, model.Password);
                    model.Status = true;
                    model.UserRoles = new List<UserRole> {
                        new UserRole{
                             RoleId = db.Roles.Where(r => r.Name == "Librarian").Select(r => r.Id).FirstOrDefault()
                        }
                    };
                    db.Users.Add(model);
                    db.SaveChanges();
                    TempData["message"] = "Thêm mới nhân viên thành công";
                }

            }
            else
            {
                TempData["Error"] = ModelState.Select(x => x.Value.Errors)
                                  .Where(y => y.Count > 0)
                                  .First()
                                  .Select(m => m.ErrorMessage)
                                  .First();

            }

            return RedirectToAction("Index");

        }

        [HttpPost("update/{id}")]
        public IActionResult Update(int id, [FromForm] User model)
        {
            SkipModelValidate("ConfirmPassword");
            SkipModelValidate("Username");
            SkipModelValidate("Status");
            if (ModelState.IsValid)
            {
                var found = db.Users.Find(id);
                // check category found

                if (found == null)
                {
                    ModelState.AddModelError("Found Employee", "Không tồn tại nhân viên");
                }

                found.Address = model.Address;
                found.FullName = model.FullName;
                found.BirthDate = model.BirthDate;

                found.Phone = model.Phone;
                // add category
                found.Status = true;

                db.SaveChanges();

                // alert success to view
                TempData["message"] = "Cập nhật nhân viên thành công";
            }
            return RedirectToAction("Index");

        }

        [HttpPost("delete/{id}")]

        public IActionResult Delete(int id)
        {

            var found = db.Users.Find(id);

            // check category found

            if (found == null)
            {
                ModelState.AddModelError("Found Employee", "Employee not found");
            }

            db.Users.Remove(found);
            db.SaveChanges();

            TempData["message"] = "Xóa nhân viên thành công";

            return RedirectToAction("Index");
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
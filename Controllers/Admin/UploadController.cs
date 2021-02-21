using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LibManage.Data;
using LibManage.Models;
namespace LibManage.Controllers
{
    [Route("/admin/upload")]
    public class UploadController : Controller
    {

        private ApplicationDbContext db;

        public UploadController(

            ApplicationDbContext db
        )
        {
            this.db = db;
        }

        [HttpPost, DisableRequestSizeLimit]
        public  IActionResult Upload(string path)
        {
            try
            {

                var file = Request.Form.Files[0];
                var folderName = Path.Combine("wwwroot", "uploads/products");
                var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);
                if (file.Length > 0)
                {
                    var now = DateTime.Now.Ticks.ToString();
                    var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    var typeFile = fileName.Substring(fileName.LastIndexOf("."));
                    fileName = fileName.Substring(0, fileName.Length - typeFile.Length) + now + typeFile;
                    var fullPath = Path.Combine(pathToSave, fileName);
                    var dbPath = Path.Combine(folderName, fileName);
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }

                    path = dbPath.Substring(7);

                    string pathFull =  $"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}{path}";

                    return Ok(new { pathFull , path });
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Internal server errors {e}");
            }
        }

    }
}
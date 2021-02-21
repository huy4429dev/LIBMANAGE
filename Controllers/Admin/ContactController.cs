using System.Threading.Tasks;
using LibManage.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace LibManage.Admin.Controllers{

    [Route("admin/contact/")]
    public class ContactController : Controller
    {
        private ApplicationDbContext db;

        public ContactController(ApplicationDbContext db)
        {
            this.db = db;    
        }

        [HttpGet]
        public  IActionResult Index(){
             
            var data  =  db.Contacts.OrderByDescending(item => item.Id).ToList();
            return View("Views/Admin/Contact/Index.cshtml", data);
        }

        [HttpGet("update-status/{id}")]
        public  async Task<IActionResult> updateStatus(int Id){
        
            var Contact = await db.Contacts.FindAsync(Id);
            if(Contact != null){
                Contact.Status = true;
                await db.SaveChangesAsync();
                return Ok(new {status = true});
            }
            return BadRequest("Không tồn tại liên hệ");
        }

    }
}
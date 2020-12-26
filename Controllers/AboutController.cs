using Microsoft.AspNetCore.Mvc;

namespace LibManage.Controllers
{
    public class AboutController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View("/Views/About/Index.cshtml");
        }

    }
}
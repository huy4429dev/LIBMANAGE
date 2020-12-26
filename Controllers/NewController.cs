using Microsoft.AspNetCore.Mvc;

namespace LibManage.Controllers
{
    public class NewController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View("/Views/New/Index.cshtml");
        }

    }
}
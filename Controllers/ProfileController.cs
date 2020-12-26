using Microsoft.AspNetCore.Mvc;

namespace LibManage.Controllers
{
    public class ProfileController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View("/Views/Profile/Index.cshtml");
        }

    }
}
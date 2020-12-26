using Microsoft.AspNetCore.Mvc;

namespace LibManage.Controllers
{
    public class AccountController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View("/Views/Account/Index.cshtml");
        }

    }
}
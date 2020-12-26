using Microsoft.AspNetCore.Mvc;

namespace LibManage.Controllers
{
    [Route("/shop")]
    public class ShopController : Controller
    {

        [HttpGet("product/{id}")]

        public IActionResult ProductDetail()
        {
            return View("/Views/Product/Index.cshtml");
        }

        [HttpGet("cart")]
        public IActionResult Cart()
        {
            return View("/Views/Cart/Index.cshtml");
        }

    }
}
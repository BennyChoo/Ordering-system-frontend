using Microsoft.AspNetCore.Mvc;

namespace Front_end___ordering.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace Front_end___ordering.ViewComponents
{
    public class AppetizersViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("Appetizers");
        }
    }
}

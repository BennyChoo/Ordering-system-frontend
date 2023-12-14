using Microsoft.AspNetCore.Mvc;

namespace Front_end___ordering.ViewComponents
{
    public class SandwichesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("Sandwiches");
        }
    }
}

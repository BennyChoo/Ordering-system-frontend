using Microsoft.AspNetCore.Mvc;

namespace Front_end___ordering.ViewComponents
{
    public class MostPopularViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("MostPopular");
        }
    }
}

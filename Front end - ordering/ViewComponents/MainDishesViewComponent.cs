using Microsoft.AspNetCore.Mvc;

namespace Front_end___ordering.ViewComponents
{
    public class MainDishesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("MainDishes");
        }
    }
}

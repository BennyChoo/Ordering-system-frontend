using Microsoft.AspNetCore.Mvc;

namespace Front_end___ordering.ViewComponents
{
    public class PastaViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("Pasta");
        }
    }
}

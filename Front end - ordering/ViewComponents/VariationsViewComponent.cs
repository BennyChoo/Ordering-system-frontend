using Microsoft.AspNetCore.Mvc;

namespace Front_end___ordering.ViewComponents
{
    public class VariationsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string variationsType)
        {
            if (variationsType == "AddOns")
            {
                return View("AddOns");
            }
            else if (variationsType == "ChangePart")
            {
                return View("ChangePart");
            }
            else if (variationsType == "Takeaway")
            {
                return View("Takeaway");
            }
            

            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace Front_end___ordering.ViewComponents
{
    public class CategoryViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string categoryType)
        {
            if (categoryType == "Appetizers")
            {
                return View("Appetizers");
            }
            else if (categoryType == "MainDishes")
            {
                return View("MainDishes");
            }
            else if (categoryType == "MostPopular")
            {
                return View("MostPopular");
            }
            else if (categoryType == "Pasta")
            {
                return View("Pasta");
            }
            else if (categoryType == "Sandwiches")
            {
                return View("Sandwiches");
            }

            return View();
        }
    }
}

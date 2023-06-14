using Microsoft.AspNetCore.Mvc;

namespace CvWebSite.ViewComponents.Dashboard
{
    public class VisitorMap : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

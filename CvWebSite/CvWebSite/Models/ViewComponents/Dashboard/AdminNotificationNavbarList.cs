using Microsoft.AspNetCore.Mvc;

namespace CvWebSite.Models.ViewComponents.Dashboard
{
    public class AdminNotificationNavbarList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace CvWebSite.Models.ViewComponents.Dashboard
{
    public class AdminNavbarMessageList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

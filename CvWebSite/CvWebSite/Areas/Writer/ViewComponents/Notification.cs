using Microsoft.AspNetCore.Mvc;

namespace CvWebSite.Areas.Writer.ViewComponents
{
    public class Notification : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace CvWebSite.ViewComponents.Dashboard
{
    public class LastFiveProject : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();

        }


    }
}

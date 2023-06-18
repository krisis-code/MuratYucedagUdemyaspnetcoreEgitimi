using Microsoft.AspNetCore.Mvc;

namespace CvWebSite.Models.ViewComponents.Dashboard
{
    public class LastFiveProject : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();

        }


    }
}

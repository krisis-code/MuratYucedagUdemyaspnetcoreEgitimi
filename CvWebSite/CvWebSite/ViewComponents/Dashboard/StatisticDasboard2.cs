using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CvWebSite.ViewComponents.Dashboard
{
    public class StatisticDasboard2 : ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = c.portfolios.Count();
            ViewBag.v2 = c.services.Count();
            ViewBag.v3 = c.messages.Count();
            return View();

        }

    }
}

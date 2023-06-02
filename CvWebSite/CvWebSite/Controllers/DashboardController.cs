using Microsoft.AspNetCore.Mvc;

namespace CvWebSite.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

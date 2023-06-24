
using Microsoft.AspNetCore.Mvc;

namespace CvWebSite.Areas.Writer.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace CvWebSite.Controllers
{
    public class FeatureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

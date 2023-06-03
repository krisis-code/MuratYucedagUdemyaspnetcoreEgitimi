using Microsoft.AspNetCore.Mvc;

namespace CvWebSite.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

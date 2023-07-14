using Microsoft.AspNetCore.Mvc;

namespace CvWebSite.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Index()
        {
            return View();

        }
        public IActionResult Error404()
        {
            return View();
        }
    }
}

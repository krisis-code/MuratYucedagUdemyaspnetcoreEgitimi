using Microsoft.AspNetCore.Mvc;

namespace CvWebSite.Controllers
{
    public class AdminMessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

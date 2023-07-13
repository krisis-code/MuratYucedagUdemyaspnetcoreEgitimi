using Microsoft.AspNetCore.Mvc;

namespace CvWebSite.Controllers
{
    public class AdminLoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

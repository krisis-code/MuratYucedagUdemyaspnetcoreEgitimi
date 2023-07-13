using Microsoft.AspNetCore.Mvc;

namespace CvWebSite.Controllers
{
    public class WriterUserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

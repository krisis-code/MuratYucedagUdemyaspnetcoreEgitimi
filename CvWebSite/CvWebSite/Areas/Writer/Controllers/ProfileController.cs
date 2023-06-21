using Microsoft.AspNetCore.Mvc;

namespace CvWebSite.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class ProfileController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}

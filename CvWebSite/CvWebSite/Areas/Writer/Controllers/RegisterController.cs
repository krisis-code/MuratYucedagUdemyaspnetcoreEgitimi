using CvWebSite.Areas.Writer.Models;
using Microsoft.AspNetCore.Mvc;

namespace CvWebSite.Areas.Writer.Controllers
{
    public class RegisterController : Controller
    {
        [Area("Writer")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(UserRegisterViewModel p)
        {
            if (ModelState.IsValid)
            {
                

            }
            return View();
        }
    }
}

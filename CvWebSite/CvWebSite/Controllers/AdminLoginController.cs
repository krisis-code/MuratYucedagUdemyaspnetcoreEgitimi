using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CvWebSite.Controllers
{
    [AllowAnonymous]
    public class AdminLoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

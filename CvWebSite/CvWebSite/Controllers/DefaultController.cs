using Microsoft.AspNetCore.Mvc;

namespace CvWebSite.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult HeaderPartial()
        {
            return new PartialViewResult();
        }
        public PartialViewResult NavbarPartial()
        {
            return new PartialViewResult();
           
        }
    }
}

using BusinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CvWebSite.Controllers
{
    public class AboutController : Controller
    {

        AboutManager aboutManager = new AboutManager(new EfAboutDal());
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.v1 = "Hakkında Düzenleme";
            ViewBag.v2 = "Hakkında";
            ViewBag.v3 = "Hakkında Düzenleme";
            var values = aboutManager.TGetById(1);

            return View(values);






        }
        [HttpPost]
        public IActionResult Index(About about)
        {
            ViewBag.v1 = "Hakkında Düzenleme";
            ViewBag.v2 = "Hakkında";
            ViewBag.v3 = "Hakkında Düzenleme";
            aboutManager.TUpdate(about);

            return RedirectToAction("Index", "Default");

        }

    }
}

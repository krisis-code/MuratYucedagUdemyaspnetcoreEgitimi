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
            var values = aboutManager.TGetById(1);
            return View(values);

        }
        [HttpPost]
        public IActionResult Index(About about)
        {
           
            aboutManager.TUpdate(about);
            return RedirectToAction("Index", "Default");

        }

    }
}

using BusinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CvWebSite.Controllers
{
    public class ExperienceController : Controller
    {
        ExperinceManager experinceManager = new ExperinceManager(new EfExperinceDal());
        public IActionResult Index()
        {
            ViewBag.v1 = "Deneyim Listesi";
            ViewBag.v2 = "Deneyimler";
            ViewBag.v3 = "Deneyim  Listesi";
            var values = experinceManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddExperience() {
            ViewBag.v1 = "Deneyim Düzenle";
            ViewBag.v2 = "Deneyimler";
            ViewBag.v3 = "Deneyim  Düzenle";


            return View();

        }
        [HttpPost]
        public IActionResult AddExperience(Experience experience)
        {
            experinceManager.TAdd(experience);
            return RedirectToAction("Index");

        }
        public IActionResult DeleteExperience(int id)
        {
            var values = experinceManager.TGetById(id);
            experinceManager.TDelete(values);
            return RedirectToAction("Index");

        }
      
        [HttpGet]
        public IActionResult EditExperience(int id)
        {
            ViewBag.v1 = "Deneyim Düzenleme";
            ViewBag.v2 = "Deneyimler";
            ViewBag.v3 = "Deneyim  Düzenleme";
            var values = experinceManager.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditExperience(Experience experience)
        {
            experinceManager.TUpdate(experience);
            return RedirectToAction("Index");
        }


    }
}

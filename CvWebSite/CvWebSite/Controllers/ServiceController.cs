using BusinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CvWebSite.Controllers
{
    public class ServiceController : Controller
    {
        ServiceManager serviceManager = new ServiceManager(new EfServiceDall());

       
        public IActionResult Index()
        {
            ViewBag.v1 = "Servis Listesi";
            ViewBag.v2 = "Servis";
            ViewBag.v3 = "Servis Listesi";
           var values = serviceManager.TGetList();

            return View(values);
        }
        [HttpGet]
        public IActionResult AddService()
        {

            ViewBag.v1 = "Servis Ekleme";
            ViewBag.v2 = "Servis";
            ViewBag.v3 = "Servis Ekleme";
            return View();

        }
        [HttpPost]
        public IActionResult AddService(Service service)
        {
            serviceManager.TAdd(service);
            return RedirectToAction("Index");

        }
        public IActionResult DeleteService(int id)
        {
            var values = serviceManager.TGetById(id);
            serviceManager.TDelete(values);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult EditService(int id)
        {
            ViewBag.v1 = "Yetenek Düzenleme";
            ViewBag.v2 = "Yetenekler";
            ViewBag.v3 = "Yetenek Düzenleme";
            var values = serviceManager.TGetById(id);

            return View(values);

        }
        [HttpPost]
        public IActionResult EditService(Service service)
        {
            ViewBag.v1 = "Yetenek Düzenleme";
            ViewBag.v2 = "Yetenekler";
            ViewBag.v3 = "Yetenek Düzenleme";
            serviceManager.TUpdate(service);

            return RedirectToAction("Index");

        }
    }
}

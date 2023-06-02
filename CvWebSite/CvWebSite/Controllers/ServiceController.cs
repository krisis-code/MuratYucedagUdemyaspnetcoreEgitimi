using BusinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CvWebSite.Controllers
{
    public class ServiceController : Controller
    {
        ServiceManager serviceManager = new ServiceManager(new EfServiceDall());

        [HttpGet]
        public IActionResult Index()
        {
;           var values = serviceManager.TGetList();

            return View(values);
        }
    }
}

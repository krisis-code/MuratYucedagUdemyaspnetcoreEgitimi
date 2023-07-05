

using BusinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CvWebSite.Controllers
{
    public class FeatureController : Controller
    {
        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());
        [HttpGet]
        public IActionResult Index()
        {
          
            
            var values = featureManager.TGetById(1);

            return View(values);

        }
        [HttpPost]
        public IActionResult Index(Feature feature)
        {
            

            featureManager.TUpdate(feature);

            return RedirectToAction("Index","Default");

        }
    }
}

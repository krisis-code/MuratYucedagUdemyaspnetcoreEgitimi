using BusinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CvWebSite.Controllers
{
    public class Experience2Controller : Controller
    {
        ExperinceManager experinceManager = new ExperinceManager(new EfExperinceDal());
        public IActionResult Index()
        {

            return View();
        }
        public IActionResult ListExperience()
        {
            var values = JsonConvert.SerializeObject(experinceManager.TGetList());
            return Json(values);

        }
        [HttpPost]
        public IActionResult AddExperience(Experience p)
        {
            experinceManager.TAdd(p);
            var values = JsonConvert.SerializeObject(p);
            return Json(values);
        }
        public IActionResult GetById(int ExperinceId)
        {
            var v = experinceManager.TGetById(ExperinceId);
            var values = JsonConvert.SerializeObject(v);
            return Json(values);

        }
        public IActionResult DeleteExperience(int id)
        {
            var v = experinceManager.TGetById(id);
            experinceManager.TDelete(v);


            return NoContent(); 
        }
    }
}

using BusinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CvWebSite.Controllers
{
    public class WriterUserController : Controller
    {
        WriterUserManager userManager = new WriterUserManager(new EfWriterUserDal());
        public IActionResult Index()
        {
           
            return View();
        }
        public IActionResult ListUser() 
        {
            var values = JsonConvert.SerializeObject(userManager.TGetList());
            return Json(values);

        }
    }
}

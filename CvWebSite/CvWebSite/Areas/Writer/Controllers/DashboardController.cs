
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace CvWebSite.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class DashboardController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public DashboardController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.v = values.Name + " " + values.Surname;


            //weater api
            string api = "bc02bd29cb8dd5abdda09924153015ee";
            string connetion = "https://api.openweathermap.org/data/2.5/weather?q=%C4%B0stanbul&mode=xml&lang=tr&units=metric&appid="+api;
            XDocument document = XDocument.Load(connetion);
            ViewBag.v5 = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;



            //Statistic

            Context c = new Context();
            ViewBag.v1 = 0;
            ViewBag.v2 = c.announcements.Count();
            ViewBag.v3 = 0;
            ViewBag.v4 = c.skills.Count();
            return View();
        }
    }
}
/*
 
 bc02bd29cb8dd5abdda09924153015ee
 
 
 */
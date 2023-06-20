using BusinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CvWebSite.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Authorize]
    public class DefaultController : Controller
    {
        
        AnnouncementsManager announcementsManager = new AnnouncementsManager(new EfannouncementsDal());
        public IActionResult Index()
        {
            var values = announcementsManager.TGetList();
            return View( values);
        }
        [HttpGet]
        public IActionResult AnnouncementDetails(int id)
        {
            Announcement  announcements = announcementsManager.TGetById(id);
            return View(announcements);
        }
    }
}


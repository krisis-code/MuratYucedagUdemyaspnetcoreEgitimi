using BusinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CvWebSite.Areas.Writer.ViewComponents
{
    public class Notification : ViewComponent
    {
        AnnouncementsManager announcementsManager = new AnnouncementsManager(new EfannouncementsDal());
        public IViewComponentResult Invoke()
        {
            var values = announcementsManager.TGetList().Take(5).ToList();
            return View(values);
        }
    }
}

using BusinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CvWebSite.Controllers
{
    public class ContactController : Controller
    {
        MessageManager messageManager = new MessageManager(new EfMessageDal());
        public IActionResult Index()
        {
            var values = messageManager.TGetList();
            return View(values);
        }
    }
}

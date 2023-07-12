using BusinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CvWebSite.Controllers
{
    public class AdminMessageController : Controller
    {
        WriterMessageManager writermessageManager = new WriterMessageManager(new EfWriterMessageDal());
        public IActionResult ReceiverMessageList()
        {
            string p = "admin@gmail.com";
            var values = writermessageManager.GetListReceiverMessage(p);
            return View(values);
        }
        public IActionResult SenderMessageList()
        {
            string p = "admin@gmail.com";
            var values = writermessageManager.GetListReceiverMessage(p);
            return View(values);
        }
        public IActionResult AdminMessageDetails(int id)
        {
            var values = writermessageManager.TGetById(id);
            return View(values);
        }
        public IActionResult ContactDetails(int id)
        {
            var values = writermessageManager.TGetById(id);
            return View(values);
        }
    }
}

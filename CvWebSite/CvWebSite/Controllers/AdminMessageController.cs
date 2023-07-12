using BusinesLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
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
            var values = writermessageManager.GetListSenderMessage(p);
            return View(values);
        }
        public IActionResult AdminMessageDetails(int id)
        {
            var values = writermessageManager.TGetById(id);
            return View(values);
        }
        public IActionResult AdminMessageDelete(int id)
        {
            var values = writermessageManager.TGetById(id);
            writermessageManager.TDelete(values);
            if (values.SenderName != null)
            {
                return RedirectToAction("SenderMessageList");
            }
            return RedirectToAction("ReceiverMessageList");

        }
        [HttpGet]
        public IActionResult AdminMessageSend()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AdminMessageSend(WriterMessage p)
        {
            p.Sender = "admin@gmail.com";
            p.SenderName = "Admin";
            p.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            Context c = new Context();
            var usernamesurname = c.Users.Where(x => x.Email == p.Receiver).Select(y => y.Name + " " + y.Surname).FirstOrDefault();
            p.ReceiverName = usernamesurname;
            writermessageManager.TAdd(p);
            return RedirectToAction("SenderMessageList");
        }
    }

    }


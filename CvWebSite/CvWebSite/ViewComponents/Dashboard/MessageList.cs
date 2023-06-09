using BusinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;


namespace CvWebSite.ViewComponents.Dashboard
{
    public class MessageList : ViewComponent
    {
        UserMessageManager messageManager =  new UserMessageManager(new EfUserMessageDal());
        public IViewComponentResult Invoke()
        {
            var values = messageManager.GetUserMessageWithUserService();
            return View(values);
        }
    }
}

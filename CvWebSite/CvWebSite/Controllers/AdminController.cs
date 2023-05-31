using Microsoft.AspNetCore.Mvc;

namespace CvWebSite.Controllers
{
    public class AdminController : Controller
    {
        public PartialViewResult PartialSideBar()
        {
            return PartialView();
        }

        public PartialViewResult PartialFooter()
        {

            return PartialView();
        }
        public PartialViewResult PartialNavbar() { 
        
            return PartialView();
        
        }

        public PartialViewResult PartialHead()
        {

            return PartialView();

        }
        public PartialViewResult PartialScript()
        {

            return PartialView();

        }

        public PartialViewResult NavigaitonPartial()
        {

            return PartialView();

        }
    }
}

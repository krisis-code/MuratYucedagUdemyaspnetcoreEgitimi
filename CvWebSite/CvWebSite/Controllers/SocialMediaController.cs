using BusinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace CvWebSite.Controllers
{
    [Authorize(Roles = "Admin")]
    public class SocialMediaController : Controller
    {
        SocialMediaManager socialMediaManager = new SocialMediaManager(new EfSocialMediaDal());
        public IActionResult Index()
        {
            var values = socialMediaManager.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddSocialMedia() 
        {
            return View();
                
        }
        [HttpPost]
        public IActionResult AddSocialMedia(SocialMedia p)
        {
            socialMediaManager.Insert(p);
                
            return RedirectToAction("Index");

        }
        public IActionResult DeleteSocialMedia(int id)
        {
            var values = socialMediaManager.GetById(id);
            socialMediaManager.Delete(values);

            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult EditSocialMedia(int id)
        {
            var values = socialMediaManager.GetById(id);
            return View(values);

        }
        [HttpPost]
        public IActionResult EditSocialMedia(SocialMedia p)
        {
        
            socialMediaManager.Update(p);
            return RedirectToAction("Index");


        }
    }
}

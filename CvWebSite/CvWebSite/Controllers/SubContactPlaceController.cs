using BusinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace CvWebSite.Controllers
{
    [Authorize(Roles = "Admin")]
    public class SubContactPlaceController : Controller
    {
        ContactManager contactManager = new ContactManager(new EfContactDal());
        [HttpGet]
        public IActionResult Index()
        {
            var values = contactManager.TGetById(1);
            return View(values);

        }
        [HttpPost]
        public IActionResult Index(Contact contact)
        {

            contactManager.TUpdate(contact);
            return RedirectToAction("Index", "Default");

        }
    }
}

using CvWebSite.Areas.Writer.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CvWebSite.Areas.Writer.Controllers
{
    public class RegisterController : Controller
    {


        //private readonly UserManager<WriterUser> _userManager;

        //public RegisterController(UserManager<WriterUser> userManager)
        //{
        //    _userManager = userManager;
        //}

        [Area("Writer")]
        [HttpGet]
        public IActionResult Index()
        {
            return View(new UserRegisterViewModel());
        }

        [HttpPost]
        public async Task< IActionResult> Index(UserRegisterViewModel p)
        {
            //if (ModelState.IsValid)
            //{
            //    WriterUser w = new WriterUser()
            //    {
            //        Name = p.Name,
            //        Surname = p.Surname,
            //        Email = p.Mail,
            //        UserName = p.UserName,
            //        ImageUrl = p.ImageUrl

            //    };

            //    var result = await _userManager.CreateAsync(w,p.Password);

            //    if (result.Succeeded)
            //    {
            //        return RedirectToAction("/Index", "Login");
            //    }
            //    else
            //    {
            //        foreach (var item in result.Errors)
            //        {
            //            ModelState.AddModelError("", item.Description);

            //        }

            //    }
             
            //}
        
            return View(p);
        }
    }
}

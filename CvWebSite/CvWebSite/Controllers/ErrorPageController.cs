using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace CvWebSite.Controllers
{
    
    public class ErrorPageController : Controller
    {
        public IActionResult Index()
        {
            return View();

        }
        public IActionResult Error404()
        {
            return View();
        }
    }
}

using BusinesLayer.Concrete;
using BusinesLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using FluentValidation.Results;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CvWebSite.Controllers;

public class PortfolioController : Controller
{
    PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());

    

    public IActionResult Index()
    {

        
        var values= portfolioManager.TGetList();
        return View(values);
    }
    [HttpGet]
    public IActionResult AddPortfolio()
    {
        ViewBag.v1 = "Proje Listesi";
        ViewBag.v2 = "Projelerim";
        ViewBag.v3 = "Proje  Listesi";
        return View();
    }

    [HttpPost]
    public IActionResult AddPortfolio(Portfolio p)
    {
       
        PortfolioValidator validations = new PortfolioValidator();
        ValidationResult result = validations.Validate(p);   
       
        if (result.IsValid)
        {
            portfolioManager.TAdd(p);
            return RedirectToAction("Index");
        }
        else
        {
            foreach (var item in result.Errors)
            {
              ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
            }
        }
      
        return View();
    }
}

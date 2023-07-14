using BusinesLayer.Concrete;
using BusinesLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using FluentValidation.Results;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.AspNetCore.Authorization;
using System.Data;

namespace CvWebSite.Controllers;


[Authorize(Roles = "Admin")]
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
    public IActionResult DeletePortfolio(int id)
    {
        var values = portfolioManager.TGetById(id);
        portfolioManager.TDelete(values);
        return RedirectToAction("Index");

    }
    [HttpGet]
    public IActionResult EditPortfolio(int id)
    {
        var values = portfolioManager.TGetById(id);
        return View(values);

    }
    [HttpPost]
    public IActionResult EditPortfolio(Portfolio  portfolio)
    {
        PortfolioValidator validator = new PortfolioValidator();
        ValidationResult result = validator.Validate(portfolio);
        if (result.IsValid)
        { 
            portfolioManager.TUpdate(portfolio);
            return RedirectToAction("Index");

        }
        else
        {
            foreach (var item in result.Errors)
            {
                ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
            }
        }
        return View();

        

    }
}

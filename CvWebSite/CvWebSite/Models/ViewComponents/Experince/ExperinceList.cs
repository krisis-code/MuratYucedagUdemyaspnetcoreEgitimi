using BusinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CvWebSite.Models.ViewComponents.Experince
{
    public class ExperinceList : ViewComponent
    {
        ExperinceManager experinceManager = new ExperinceManager(new EfExperinceDal());
        public IViewComponentResult Invoke()
        {
            var values = experinceManager.TGetList();

            return View(values);
        }
    }
}

using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Areas.Member.Controllers
{
    [Area("Member")]
	[Route("Member/[controller]/[action]")]

	public class DestinationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());

        public IActionResult Index()
        {
            var destinations = destinationManager.TGetAll();
            return View(destinations);
        }

        public IActionResult GetCitiesSearchByName(string searchString)
        {
            ViewData["CurrentFilter"] = searchString;
            var values=from x in destinationManager.TGetAll() select x;
            if(!string.IsNullOrEmpty(searchString))
            {
                values=values.Where(y=>y.City.Contains(searchString));
            }
            return View(values.ToList());
        }

    }
}

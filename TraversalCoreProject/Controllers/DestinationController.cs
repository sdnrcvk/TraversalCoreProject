using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Controllers
{
    public class DestinationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        public IActionResult Index()
        {
            var destinations=destinationManager.TGetAll();
            return View(destinations);
        }

        [HttpGet]
        public IActionResult DestinationDetails(int id)
        {
            var destination=destinationManager.TGetById(id);
            return View(destination);
        }

        [HttpPost]
        public IActionResult DestinationDetails(Destination p) 
        {
            return View();
        }
    }
}

using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Controllers
{
    [AllowAnonymous]
    public class DestinationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        private readonly UserManager<AppUser> _userManager;

        public DestinationController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var destinations=destinationManager.TGetAll();
            return View(destinations);
        }


        [HttpGet]
        public async Task<IActionResult> DestinationDetails(int id)
        {
            ViewBag.Id = id;
            ViewBag.destId = id;
            var value = await _userManager.FindByNameAsync(User.Identity.IsAuthenticated ? User.Identity.Name : "");
            if (value != null)
            {
                ViewBag.userId = value.Id;
            }
            var values =destinationManager.TGetDestinationWithGuide(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult DestinationDetails(Destination p) 
        {
            return View();
        }
    }
}

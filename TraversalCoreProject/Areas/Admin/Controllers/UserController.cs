using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly IAppUserService _appUserService;

        public UserController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }

        public IActionResult Index()
        {
            var users=_appUserService.TGetAll();
            return View(users);
        }

        public IActionResult DeleteUser(int id)
        {
            var values = _appUserService.TGetById(id);
            _appUserService.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditUser(int id)
        {
            var values = _appUserService.TGetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult EditUser(AppUser appUser)
        {
            _appUserService.TUpdate(appUser);
            return RedirectToAction("Index");
        }

        public IActionResult CommentUser(int id)
        {
            _appUserService.TGetAll();
            return View();
        }

        public IActionResult ReservationUser(int id)
        {
            _appUserService.TGetAll();
            return View();
        }
    }
}

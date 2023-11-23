using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Controllers
{
    public class ErrorPage : Controller
    {
        public IActionResult Error404(int code)
        {
            return View();
        }
    }
}

using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.AdminDashboard
{
    public class _Card1Statistic:ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.destinationNumber = c.Destinations.Count();
            ViewBag.guestNumber=c.Users.Count();
            return View();
        }
    }
}

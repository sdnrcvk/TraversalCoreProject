using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Default
{
    public class _StatisticsPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using var c = new Context();
            ViewBag.totalDestinations = c.Destinations.Count();
            ViewBag.totalGuides= c.Guides.Count();
            ViewBag.totalCustomers = "285";
            return View();
        }
    }
}

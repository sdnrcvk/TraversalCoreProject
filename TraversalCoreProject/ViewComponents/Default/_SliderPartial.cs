using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Default
{
    public class _SliderPartial:ViewComponent
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());

        public IViewComponentResult Invoke()
        {
            var destinations = destinationManager.TGetAll();
            return View(destinations);
        }
    }
}

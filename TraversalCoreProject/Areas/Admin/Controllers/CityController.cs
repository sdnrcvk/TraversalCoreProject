using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TraversalCoreProject.Models;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CityController : Controller
    {
        private readonly IDestinationService _destinationService;

        public CityController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CityList()
        {
            var jsonCity = JsonConvert.SerializeObject(_destinationService.TGetAll());
            return Json(jsonCity);
        }

        [HttpPost]
        public IActionResult AddCityDestination(Destination destination)
        {
            destination.Status = true;
            _destinationService.TAdd(destination);
            var values=JsonConvert.SerializeObject(destination);
            return Json(values);
        }

        public IActionResult GetById(int DestinationID)
        {
            var values = _destinationService.TGetById(DestinationID);
            var jsonCity = JsonConvert.SerializeObject(values);
            return Json(jsonCity);
        }

        public IActionResult DeleteCityDestination(int id)
        {
            var values = _destinationService.TGetById(id);
            _destinationService.TDelete(values);
            return NoContent();
        }

        public IActionResult UpdateCityDestination(Destination destination)
        {
            _destinationService.TUpdate(destination);
            var v = JsonConvert.SerializeObject(destination);
            return Json(v);
        }
    }
}

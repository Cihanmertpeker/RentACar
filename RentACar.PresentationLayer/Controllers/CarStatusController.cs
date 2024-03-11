using Microsoft.AspNetCore.Mvc;
using RentACar.BusinessLayer.Abstract;
using RentACar.EntityLayer.Concrete;

namespace RentACar.PresentationLayer.Controllers
{
    public class CarStatusController : Controller
    {
        private readonly ICarStatusService _carStatusService;

        public CarStatusController(ICarStatusService carStatusService)
        {
            _carStatusService = carStatusService;
        }

        public IActionResult Index()
        {
            var values = _carStatusService.TGetListAll();
            return View(values);
        }
        public IActionResult CreateCarStatus()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateCarStatus(CarStatus carStatus)
        {
            _carStatusService.TInsert(carStatus);
            return RedirectToAction("Index");
        }
        public IActionResult RemoveCarStatus(int id) 
        {
            var values = _carStatusService.TGetById(id);
            _carStatusService.TDelete(values);
            return RedirectToAction("Index");
        }

        public IActionResult UpdateCarStatus(int id)
        {
            var value = _carStatusService.TGetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateCarStatus(CarStatus carStatus)
        {
            _carStatusService.TUpdate(carStatus);
            return RedirectToAction("Index");
        }
    }
}

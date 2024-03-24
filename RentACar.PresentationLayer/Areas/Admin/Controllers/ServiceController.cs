using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RentACar.BusinessLayer.Abstract;
using RentACar.DtoLayer.DTOs.ServiceDtos;
using RentACar.EntityLayer.Concrete;

namespace RentACar.PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]")]
    public class ServiceController : Controller
    {
        private readonly IServiceService _serviceService;
        private readonly IMapper _mapper;

        public ServiceController(IServiceService serviceService, IMapper mapper)
        {
            _serviceService = serviceService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var services = _serviceService.TGetList();
            var values = _mapper.Map<List<ServiceDto>>(services);
            return View(values);
        }

        public IActionResult DeleteService(int id)
        {
            _serviceService.TDelete(id);
            return RedirectToAction("Index");
        }

        public IActionResult AddService()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddService(ServiceDto serviceDto)
        {
            var newService = _mapper.Map<Service>(serviceDto);
            _serviceService.TInsert(newService);
            return RedirectToAction("Index");
        }

        public IActionResult UpdateService(int id)
        {
            var service = _serviceService.TGetByID(id);
            var value = _mapper.Map<ServiceDto>(service);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateService(ServiceDto serviceDto)
        {
            var updateService = _mapper.Map<Service>(serviceDto);
            _serviceService.TUpdate(updateService);
            return RedirectToAction("Index");
        }
    }
}

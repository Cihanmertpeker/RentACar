using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using RentACar.BusinessLayer.Abstract;
using RentACar.BusinessLayer.ValidationRules.ServiceValidation;
using RentACar.EntityLayer.Concrete;

namespace RentACar.PresentationLayer.Controllers
{
	public class ServiceController : Controller
	{
		private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        public IActionResult Index()
		{
			var values = _serviceService.TGetListAll();
			return View(values);
		}
		public IActionResult ServiceList()
		{
			var values = _serviceService.TGetListAll();
			return View(values);
		}
		public IActionResult CreateService()
		{ 

			return View();
		}

		[HttpPost]
        public IActionResult CreateService(Service service)
        {
			CreateServiceValidator validationRules = new CreateServiceValidator();
			ValidationResult result = validationRules.Validate(service);
			if (result.IsValid)
			{
				_serviceService.TInsert(service);
				return RedirectToAction("Index");
			}
			else
			{
				foreach (var item in result.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
                return View();
            }
        }
    }
}

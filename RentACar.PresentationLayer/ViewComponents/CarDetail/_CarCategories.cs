using Microsoft.AspNetCore.Mvc;
using RentACar.BusinessLayer.Abstract;

namespace RentACar.PresentationLayer.ViewComponents.CarDetail
{
	public class _CarCategories : ViewComponent
	{
		private readonly ICarService _carService;

		public _CarCategories(ICarService carService)
		{
			_carService = carService;
		}

		public IViewComponentResult Invoke()
		{
			var values = _carService.GetCategoryCount();
			return View(values);
		}
	}
}

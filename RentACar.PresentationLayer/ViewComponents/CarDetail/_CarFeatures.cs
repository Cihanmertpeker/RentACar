using Microsoft.AspNetCore.Mvc;
using RentACar.BusinessLayer.Abstract;

namespace RentACar.PresentationLayer.ViewComponents.CarDetail
{
	public class _CarFeatures : ViewComponent
	{
		private readonly ICarFeatureService _carFeatureService;

		public _CarFeatures(ICarFeatureService carFeatureService)
		{
			_carFeatureService = carFeatureService;
		}

		public IViewComponentResult Invoke(int id)
		{
			var values = _carFeatureService.GetFeaturesByCarId(id);
			return View(values);
		}
	}
}

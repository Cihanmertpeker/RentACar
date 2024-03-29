﻿using Microsoft.AspNetCore.Mvc;
using RentACar.BusinessLayer.Abstract;

namespace RentACar.PresentationLayer.ViewComponents.CarDetail
{
	public class _CarMainDetails : ViewComponent
	{
		private readonly ICarService _carService;

		public _CarMainDetails(ICarService carService)
		{
			_carService = carService;
		}

		public IViewComponentResult Invoke(int id)
		{
			var value = _carService.TGetAll().Where(x => x.CarID == id).FirstOrDefault();
			return View(value);
		}
	}

}

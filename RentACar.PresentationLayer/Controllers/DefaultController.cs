﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RentACar.BusinessLayer.Abstract;
using RentACar.EntityLayer.Concrete;
using System.Linq;
using System.Text.Json;

namespace RentACar.PresentationLayer.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
		private readonly ICarService _carService;

		public DefaultController(ICarService carService)
		{
			_carService = carService;
		}

		public IActionResult Index()
		{
			var cars = _carService.TGetAll();

			IEnumerable<SelectListItem> models = (from x in cars
												  select new SelectListItem
												  {
													  Text = x.Brand.BrandName + " " + x.CarName,
													  Value = x.CarName,

												  }).ToList();

			ViewBag.cars = models;
			var gasList = cars.Select(x => x.GasType).Distinct().ToList();
			IEnumerable<SelectListItem> gasTypes = (from x in gasList
													select new SelectListItem
													{
														Text = x,
														Value = x,

													}).ToList();

			ViewBag.gas = gasTypes;

			var gearList = cars.Select(x => x.Gear).Distinct().ToList();
			IEnumerable<SelectListItem> gearTypes = (from x in gearList
													 select new SelectListItem
													 {
														 Text = x,
														 Value = x,

													 }).ToList();

			ViewBag.gear = gearTypes;
			return View();
		}

		[HttpGet]
		public PartialViewResult FilterCars()
		{
			var cars = _carService.TGetAll();

			IEnumerable<SelectListItem> models = (from x in cars
												  select new SelectListItem
												  {
													  Text = x.Brand.BrandName + " " + x.CarName,
													  Value = x.CarName,

												  }).ToList();

			ViewBag.cars = models;

			var gasList = cars.Select(x => x.GasType).Distinct().ToList();
			IEnumerable<SelectListItem> gasTypes = (from x in gasList
													select new SelectListItem
													{
														Text = x,
														Value = x,

													}).ToList();

			ViewBag.gas = gasTypes;

			var gearList = cars.Select(x => x.Gear).Distinct().ToList();
			IEnumerable<SelectListItem> gearTypes = (from x in gearList
													 select new SelectListItem
													 {
														 Text = x,
														 Value = x,

													 }).ToList();

			ViewBag.gear = gearTypes;
			return PartialView();
		}

		[HttpPost]
		public IActionResult FilterCars(Car car)
		{
			ViewData["model"] = car.CarName;
			ViewData["year"] = car.Year;
			ViewData["gasType"] = car.GasType;
			ViewData["gearType"] = car.Gear;


			var values = _carService.TGetAll();




			if (!string.IsNullOrEmpty(car.CarName) || car.Year != null || !string.IsNullOrEmpty(car.GasType) || !string.IsNullOrEmpty(car.Gear))
			{


				var lowerCaseModel = car.CarName.ToLower();
				var lowerCaseGasType = car.GasType.ToLower();
				var lowerCaseGearType = car.Gear.ToLower();
				values = values.Where(x => x.CarName.ToLower().Contains(lowerCaseModel) && x.Year >= car.Year && x.GasType.ToLower() == lowerCaseGasType && x.Gear.ToLower() == lowerCaseGearType).ToList();


				TempData["filteredCars"] = JsonSerializer.Serialize(values);
				return RedirectToAction("Index", "RentCar");





			}

			return RedirectToAction("Index");
		}
	}
}

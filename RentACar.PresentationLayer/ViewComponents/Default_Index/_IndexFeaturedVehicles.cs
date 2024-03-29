﻿using Microsoft.AspNetCore.Mvc;
using RentACar.BusinessLayer.Abstract;

namespace RentACar.PresentationLayer.ViewComponents.Default_Index
{
    public class _IndexFeaturedVehicles : ViewComponent
    {
        private readonly ICarService _carService;

        public _IndexFeaturedVehicles(ICarService carService)
        {
            _carService = carService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _carService.GetLast5Cars();
            return View(values);
        }
    }
}

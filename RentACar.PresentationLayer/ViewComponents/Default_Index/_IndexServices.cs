﻿using Microsoft.AspNetCore.Mvc;
using RentACar.BusinessLayer.Abstract;

namespace RentACar.PresentationLayer.ViewComponents.Default_Index
{
    public class _IndexServices : ViewComponent
    {
        private readonly IServiceService _serviceService;

        public _IndexServices(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _serviceService.TGetList();
            return View(values);
        }
    }
}

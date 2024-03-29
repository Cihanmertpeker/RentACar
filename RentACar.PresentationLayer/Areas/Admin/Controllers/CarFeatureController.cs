﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RentACar.BusinessLayer.Abstract;
using RentACar.DtoLayer.DTOs.CarFeatureDtos;
using RentACar.EntityLayer.Concrete;

namespace RentACar.PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]")]
    public class CarFeatureController : Controller
    {
        private readonly ICarFeatureService _carFeatureService;
        private readonly ICarService _carService;
        private readonly IMapper _mapper;

        public CarFeatureController(ICarFeatureService carFeatureService, ICarService carService, IMapper mapper)
        {
            _carFeatureService = carFeatureService;
            _carService = carService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var features = _carFeatureService.TGetList();
            var values = _mapper.Map<List<CarFeatureDto>>(features);
            return View(values);
        }

        public IActionResult AddCarFeature()
        {
            ViewBag.cars = new List<SelectListItem>(from x in _carService.TGetAll()
                                                    select new SelectListItem
                                                    {
                                                        Text = x.Brand.BrandName + " " + x.CarName,
                                                        Value = x.CarID.ToString()
                                                    }).ToList();
            return View();
        }
        [HttpPost]
        public IActionResult AddCarFeature(CarFeatureDto carFeatureDto)
        {

            _carFeatureService.TInsert(_mapper.Map<CarFeature>(carFeatureDto));
            return RedirectToAction("Index");
        }

        public IActionResult DeleteCarFeature(int id)
        {
            _carFeatureService.TDelete(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateCarFeature(int id)
        {
            ViewBag.cars = new List<SelectListItem>(from x in _carService.TGetAll()
                                                    select new SelectListItem
                                                    {
                                                        Text = x.Brand.BrandName + " " + x.CarName,
                                                        Value = x.CarID.ToString()
                                                    }).ToList();

            var feature = _carFeatureService.TGetByID(id);
            var value = _mapper.Map<CarFeatureDto>(feature);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateCarFeature(CarFeatureDto carFeatureDto)
        {

            _carFeatureService.TUpdate(_mapper.Map<CarFeature>(carFeatureDto));
            return RedirectToAction("Index");
        }
    }
}

﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RentACar.BusinessLayer.Abstract;
using RentACar.DtoLayer.DTOs.CarDtos;
using RentACar.EntityLayer.Concrete;

namespace RentACar.PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]")]
    public class CarController : Controller
    {
        private readonly ICarService _carService;
        private readonly IBrandService _brandService;
        private readonly ICategoryService _categoryService;
        private readonly ICarStatusService _carStatusService;
        private readonly IMapper _mapper;

        public CarController(ICarService carService, IBrandService brandService, ICategoryService categoryService, ICarStatusService carStatusService, IMapper mapper)
        {
            _carService = carService;
            _brandService = brandService;
            _categoryService = categoryService;
            _carStatusService = carStatusService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var cars = _carService.TGetAll();
            var values = _mapper.Map<List<CarDto>>(cars);
            return View(values);
        }

        public IActionResult AddCar()
        {
            ViewBag.brands = new List<SelectListItem>(from x in _brandService.TGetList()
                                                      select new SelectListItem
                                                      {
                                                          Text = x.BrandName,
                                                          Value = x.BrandID.ToString()
                                                      }).ToList();

            ViewBag.category = new List<SelectListItem>(from x in _categoryService.TGetList()
                                                        select new SelectListItem
                                                        {
                                                            Text = x.CategoryName,
                                                            Value = x.CategoryID.ToString()
                                                        }).ToList();

            ViewBag.carStatus = new List<SelectListItem>(from x in _carStatusService.TGetList()
                                                         select new SelectListItem
                                                         {
                                                             Text = x.StatusName,
                                                             Value = x.CarStatusID.ToString()
                                                         }).ToList();
            return View();
        }
        [HttpPost]
        public IActionResult AddCar(CarDto carDto)
        {
            var newCar = _mapper.Map<Car>(carDto);

            _carService.TInsert(newCar);
            return RedirectToAction("Index");


        }

        [HttpGet]
        public IActionResult UpdateCar(int id)
        {
            ViewBag.brands = new List<SelectListItem>(from x in _brandService.TGetList()
                                                      select new SelectListItem
                                                      {
                                                          Text = x.BrandName,
                                                          Value = x.BrandID.ToString()
                                                      }).ToList();

            ViewBag.category = new List<SelectListItem>(from x in _categoryService.TGetList()
                                                        select new SelectListItem
                                                        {
                                                            Text = x.CategoryName,
                                                            Value = x.CategoryID.ToString()
                                                        }).ToList();

            ViewBag.carStatus = new List<SelectListItem>(from x in _carStatusService.TGetList()
                                                         select new SelectListItem
                                                         {
                                                             Text = x.StatusName,
                                                             Value = x.CarStatusID.ToString()
                                                         }).ToList();
            var car = _carService.TGetByID(id);
            var value = _mapper.Map<CarDto>(car);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateCar(CarDto carDto)
        {
            var updateCar = _mapper.Map<Car>(carDto);
            _carService.TUpdate(updateCar);
            return RedirectToAction("Index");
        }
    }
}

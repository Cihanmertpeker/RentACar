﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RentACar.BusinessLayer.Abstract;
using RentACar.DtoLayer.DTOs.CarDetailDtos;
using RentACar.EntityLayer.Concrete;

namespace RentACar.PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]")]
    public class CarDetailController : Controller
    {
        private readonly ICarDetailService _carDetailService;
        private readonly ICarService _carService;
        private readonly IMapper _mapper;

        public CarDetailController(ICarDetailService carDetailService, ICarService carService, IMapper mapper)
        {
            _carDetailService = carDetailService;
            _carService = carService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var carDetails = _carDetailService.GetAll();
            var values = _mapper.Map<List<CarDetailDto>>(carDetails);
            return View(values);
        }

        public IActionResult DeleteCarDetail(int id)
        {
            _carDetailService.TDelete(id);
            return RedirectToAction("Index");
        }

        public IActionResult AddCarDetail()
        {
            ViewBag.car = new List<SelectListItem>(from x in _carService.TGetAll()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.Brand.BrandName + " " + x.CarName,
                                                       Value = x.CarID.ToString()
                                                   }).ToList();

            return View();
        }

        [HttpPost]
        public IActionResult AddCarDetail(CarDetailDto carDetailDto)
        {
            var newDetail = _mapper.Map<CarDetail>(carDetailDto);
            _carDetailService.TInsert(newDetail);
            return RedirectToAction("Index");

        }

        public IActionResult UpdateCarDetail(int id)
        {
            ViewBag.car = new List<SelectListItem>(from x in _carService.TGetAll()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.Brand.BrandName + " " + x.CarName,
                                                       Value = x.CarID.ToString()
                                                   }).ToList();
            var carDetail = _carDetailService.TGetByID(id);
            var value = _mapper.Map<CarDetailDto>(carDetail);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateCarDetail(CarDetailDto carDetailDto)
        {
            _carDetailService.TUpdate(_mapper.Map<CarDetail>(carDetailDto));
            return RedirectToAction("Index");
        }
    }
}

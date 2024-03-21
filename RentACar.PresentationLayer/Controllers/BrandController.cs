﻿using Microsoft.AspNetCore.Mvc;
using RentACar.BusinessLayer.Abstract;
using RentACar.EntityLayer.Concrete;

namespace RentACar.PresentationLayer.Controllers
{
    public class BrandController : Controller
    {
        private readonly IBrandService _brandService;

        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        public IActionResult Index()
        {
            var values = _brandService.TGetListAll();
            return View(values);
        }

        public IActionResult AddBrand()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddBrand(Brand brand)
        {
            _brandService.TInsert(brand);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteBrand(int id)
        {
            var value = _brandService.TGetById(id);
            _brandService.TDelete(value);

            return RedirectToAction("Index");
        }

        public IActionResult UpdateBrand(int id)
        {
            var value = _brandService.TGetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateBrand(Brand brand)
        {
            _brandService.TUpdate(brand);
            return RedirectToAction("Index");
        }


        public IActionResult GetBrandSearchByName(string p)
        {
            ViewData["CurrentFilter"] = p;
            var values = from x in _brandService.TGetListAll() select x;
            if (!string.IsNullOrEmpty(p))
            {
                values = values.Where(y=>y.BrandName.Contains(p));
            }
            return View(values.ToList());
        }

    }
}

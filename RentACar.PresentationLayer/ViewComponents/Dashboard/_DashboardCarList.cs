using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RentACar.BusinessLayer.Abstract;
using RentACar.DtoLayer.DTOs.CarDtos;

namespace RentACar.PresentationLayer.ViewComponents.Dashboard
{
    public class _DashboardCarList : ViewComponent
    {
        private readonly ICarService _carService;
        private readonly IMapper _mapper;

        public _DashboardCarList(ICarService carService, IMapper mapper)
        {
            _carService = carService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            var cars = _carService.GetLast5Cars();
            var values = _mapper.Map<List<CarDto>>(cars);
            return View(values);
        }
    }   
}

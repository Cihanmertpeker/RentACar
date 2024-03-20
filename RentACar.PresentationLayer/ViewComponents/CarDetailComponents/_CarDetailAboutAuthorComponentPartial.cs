using Microsoft.AspNetCore.Mvc;
using RentACar.BusinessLayer.Abstract;

namespace RentACar.PresentationLayer.ViewComponents.CarDetailComponents
{
    public class _CarDetailAboutAuthorComponentPartial:ViewComponent
    {
        private readonly ICarDetailService _carDetailService;

        public _CarDetailAboutAuthorComponentPartial(ICarDetailService carDetailService)
        {
            _carDetailService = carDetailService;
        }

        public IViewComponentResult Invoke(int id)
        {
            var values = _carDetailService.TGetCarDetailWithAuthor(id);
            return View(values);
        }
    }
}

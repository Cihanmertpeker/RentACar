using Microsoft.AspNetCore.Mvc;
using RentACar.BusinessLayer.Abstract;

namespace RentACar.PresentationLayer.ViewComponents.ServiceComponents
{
    public class _HowItWorkStepComponentPartial : ViewComponent
    {

        private readonly IHowItWorksStepService _howItWorkStepService;

        public _HowItWorkStepComponentPartial(IHowItWorksStepService howItWorkStepService)
        {
            _howItWorkStepService = howItWorkStepService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _howItWorkStepService.GetListAll();
            return View(values);
        }
    }
}

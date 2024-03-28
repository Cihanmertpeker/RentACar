using Microsoft.AspNetCore.Mvc;

namespace RentACar.PresentationLayer.ViewComponents.Default_Index
{
    public class _IndexRentCarWays : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

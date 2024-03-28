using Microsoft.AspNetCore.Mvc;

namespace RentACar.PresentationLayer.ViewComponents.Default_Index
{
    public class _IndexBecomeDriver : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

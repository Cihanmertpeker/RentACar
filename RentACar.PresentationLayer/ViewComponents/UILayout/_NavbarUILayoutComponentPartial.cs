using Microsoft.AspNetCore.Mvc;

namespace RentACar.PresentationLayer.ViewComponents.UILayout
{
    public class _NavbarUILayoutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

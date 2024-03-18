using Microsoft.AspNetCore.Mvc;

namespace RentACar.PresentationLayer.ViewComponents.UILayout
{
    public class _CoverUILayoutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

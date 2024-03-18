using Microsoft.AspNetCore.Mvc;

namespace RentACar.PresentationLayer.ViewComponents.UILayout
{
    public class _FooterUILayoutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

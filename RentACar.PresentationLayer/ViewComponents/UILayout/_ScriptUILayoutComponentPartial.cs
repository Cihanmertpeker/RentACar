using Microsoft.AspNetCore.Mvc;

namespace RentACar.PresentationLayer.ViewComponents.UILayout
{
    public class _ScriptUILayoutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

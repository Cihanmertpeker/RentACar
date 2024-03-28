using Microsoft.AspNetCore.Mvc;

namespace RentACar.PresentationLayer.Views.Shared.Components.DefaultLayout
{
    public class _DefaultFooter : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

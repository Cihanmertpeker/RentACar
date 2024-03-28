using Microsoft.AspNetCore.Mvc;

namespace RentACar.PresentationLayer.Views.Shared.Components.DefaultLayout
{
    public class _DefaultNavbar : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

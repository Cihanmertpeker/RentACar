using Microsoft.AspNetCore.Mvc;

namespace RentACar.PresentationLayer.ViewComponents.AdminLayout
{
    public class _AdminSideBar : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

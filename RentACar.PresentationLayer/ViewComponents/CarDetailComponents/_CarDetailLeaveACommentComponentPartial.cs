using Microsoft.AspNetCore.Mvc;

namespace RentACar.PresentationLayer.ViewComponents.CarDetailComponents
{
    public class _CarDetailLeaveACommentComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

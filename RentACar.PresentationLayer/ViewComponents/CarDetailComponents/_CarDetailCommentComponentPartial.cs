using Microsoft.AspNetCore.Mvc;

namespace RentACar.PresentationLayer.ViewComponents.CarDetailComponents
{
    public class _CarDetailCommentComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using RentACar.BusinessLayer.Abstract;

namespace RentACar.PresentationLayer.ViewComponents.CarDetailComponents
{
    public class _CarDetailCommentComponentPartial:ViewComponent
    {
        private readonly ICommentService _commentService;

        public _CarDetailCommentComponentPartial(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IViewComponentResult Invoke(int id)
        {
            var values = _commentService.TGetCommentsByCar(id);
            return View(values);
        }
    }
}

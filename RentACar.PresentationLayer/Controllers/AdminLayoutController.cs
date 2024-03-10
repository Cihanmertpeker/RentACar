using Microsoft.AspNetCore.Mvc;

namespace RentACar.PresentationLayer.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

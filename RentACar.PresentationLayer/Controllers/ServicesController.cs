using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace RentACar.PresentationLayer.Controllers
{
    [AllowAnonymous]

    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

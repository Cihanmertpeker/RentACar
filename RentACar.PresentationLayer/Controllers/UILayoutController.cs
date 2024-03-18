using Microsoft.AspNetCore.Mvc;

namespace RentACar.PresentationLayer.Controllers
{
	public class UILayoutController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}

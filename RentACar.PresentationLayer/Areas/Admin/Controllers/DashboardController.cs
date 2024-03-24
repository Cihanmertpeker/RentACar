using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RentACar.DataAccessLayer.Concrete;
using RentACar.EntityLayer.Concrete;

namespace RentACar.PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]")]
    public class DashboardController : Controller
    {
        private readonly RentACarContext _context;
        private readonly UserManager<AppUser> _userManager;

        public DashboardController(RentACarContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.name = user.NameSurname;

            ViewBag.cars = _context.Cars.Count();
            ViewBag.categories = _context.Categories.Count();
            ViewBag.brands = _context.Brands.Count();
            ViewBag.comments = _context.Reviews.Count();
            return View();
        }
    }
}

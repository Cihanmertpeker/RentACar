using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RentACar.BusinessLayer.Abstract;

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

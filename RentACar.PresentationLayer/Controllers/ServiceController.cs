﻿using Microsoft.AspNetCore.Mvc;

namespace RentACar.PresentationLayer.Controllers
{
	public class ServiceController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}

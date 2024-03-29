﻿using Microsoft.AspNetCore.Mvc;
using RentACar.BusinessLayer.Abstract;

namespace RentACar.PresentationLayer.ViewComponents.CarDetail
{
	public class _CarReviews : ViewComponent
	{
		IReviewService _reviewService;

		public _CarReviews(IReviewService reviewService)
		{
			_reviewService = reviewService;
		}

		public IViewComponentResult Invoke(int id)
		{
			var values = _reviewService.GetReviewsByCar(id);
			ViewBag.count = _reviewService.GetReviewsByCar(id).Count();
			return View(values);
		}
	}
}

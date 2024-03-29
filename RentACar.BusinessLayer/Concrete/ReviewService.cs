﻿using RentACar.BusinessLayer.Abstract;
using RentACar.DataAccessLayer.Abstract;
using RentACar.DataAccessLayer.Concrete;
using RentACar.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.BusinessLayer.Concrete
{
	public class ReviewService : IReviewService
	{
		private readonly IGenericDal<Review> _reviewDal;
		private readonly RentACarContext _context;

        public ReviewService(IGenericDal<Review> reviewDal, RentACarContext context)
        {
            _reviewDal = reviewDal;
            _context = context;
        }

        public List<Review> GetReviewsByCar(int id)
		{
			

			return _context.Reviews.Where(x=>x.CarId == id).ToList();
		}

		public void TDelete(int id)
		{
			_reviewDal.Delete(id);
		}

		public Review TGetByID(int id)
		{
			return _reviewDal.GetByID(id);
		}

		public List<Review> TGetList()
		{
			return _context.Reviews.Include(x=>x.Car).ThenInclude(x=>x.Brand).ToList();
		}

		public void TInsert(Review entity)
		{
			_reviewDal.Insert(entity);
		}

		public void TUpdate(Review entity)
		{
			_reviewDal.Update(entity);
		}
	}
}

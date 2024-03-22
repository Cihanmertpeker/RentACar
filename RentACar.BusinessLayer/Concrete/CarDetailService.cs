using RentACar.BusinessLayer.Abstract;
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
	public class CarDetailService : ICarDetailService
	{
		private readonly IGenericDal<CarDetail> _carDetailDal;
        private readonly RentACarContext _context;

		public CarDetailService(IGenericDal<CarDetail> carDetailDal,RentACarContext context)
		{
			_carDetailDal = carDetailDal;
			_context = context;
		}

        public List<CarDetail> GetAll()
        {
            return _context.CarDetails.Include(x=>x.Car).ThenInclude(x=>x.Brand).ToList();
        }

        public CarDetail GetDetailByCarId(int id)
		{
			
			return _context.CarDetails.Include(x => x.Car).ThenInclude(x=>x.Brand).FirstOrDefault(x => x.CarID == id);
		}

		public void TDelete(int id)
		{
			_carDetailDal.Delete(id);
		}

		public CarDetail TGetByID(int id)
		{
			return _carDetailDal.GetByID(id);
		}

		public List<CarDetail> TGetList()
		{
			return _carDetailDal.GetList();
		}

		public void TInsert(CarDetail entity)
		{
			_carDetailDal.Insert(entity);
		}

		public void TUpdate(CarDetail entity)
		{
			_carDetailDal.Update(entity);
		}
	}
}

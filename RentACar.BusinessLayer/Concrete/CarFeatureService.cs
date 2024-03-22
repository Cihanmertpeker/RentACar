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
	public class CarFeatureService : ICarFeatureService
	{
		private readonly IGenericDal<CarFeature> _carFeatureDal;
		private readonly RentACarContext _context;

        public CarFeatureService(IGenericDal<CarFeature> carFeatureDal, RentACarContext context)
        {
            _carFeatureDal = carFeatureDal;
            _context = context;
        }

        public List<CarFeature> GetFeaturesByCarId(int id)
		{
			
			return _context.CarFeatures.Include(x => x.Car).Where(x => x.CarId == id).ToList();
		}

		public void TDelete(int id)
		{
			_carFeatureDal.Delete(id);
		}

		public CarFeature TGetByID(int id)
		{
			return _carFeatureDal.GetByID(id);
		}

		public List<CarFeature> TGetList()
		{
			return _context.CarFeatures.Include(x=>x.Car).ThenInclude(x=>x.Brand).ToList();
		}

		public void TInsert(CarFeature entity)
		{
			_carFeatureDal.Insert(entity);
		}

		public void TUpdate(CarFeature entity)
		{
			_carFeatureDal.Update(entity);
		}
	}
}

using RentACar.BusinessLayer.Abstract;
using RentACar.DataAccessLayer.Abstract;
using RentACar.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.BusinessLayer.Concrete
{
    public class CarManager : ICarService
    {
        private readonly ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void TDelete(Car entity)
        {
            _carDal.Delete(entity);
        }

        public List<Car> TGetAllCarsWithBrands()
        {
            return _carDal.GetAllCarsWithBrands();
        }

        public Car TGetById(int id)
        {
            if (id!=null)
            {
                return _carDal.GetById(id);

            }
            return _carDal.GetById(0);
        }

        public List<Car> TGetListAll()
        {
         
            return _carDal.GetListAll();

        }

        public void TInsert(Car entity)
        {
            if (entity.Year>=2022 && entity.Prices.Count>0 && entity.Km <= 300000)
            {
                _carDal.Insert(entity);

            }            
        }

        public void TUpdate(Car entity)
        {
            _carDal.Update(entity);
        }
    }
}

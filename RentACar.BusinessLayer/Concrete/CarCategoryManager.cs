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
    public class CarCategoryManager : ICarCategoryService
    {
        private readonly ICarCategoryDal _carCategoryDal;

        public CarCategoryManager(ICarCategoryDal carCategoryDal)
        {
            _carCategoryDal = carCategoryDal;
        }

        public void TDelete(CarCategory entity)
        {
           _carCategoryDal.Delete(entity);
        }

        public CarCategory TGetById(int id)
        {
            return _carCategoryDal.GetById(id);
        }

        public List<CarCategory> TGetListAll()
        {
            return _carCategoryDal.GetListAll();
        }

        public void TInsert(CarCategory entity)
        {
           _carCategoryDal.Insert(entity);
        }

        public void TUpdate(CarCategory entity)
        {
            _carCategoryDal.Update(entity);
        }
    }
}

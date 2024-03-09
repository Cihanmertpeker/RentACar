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
    public class LocationManager : ILocationService
    {
        private readonly ILocationDal _locationDal;

        public LocationManager(ILocationDal locationDal)
        {
            _locationDal = locationDal;
        }

        public void TDelete(Location entity)
        {
            _locationDal.Delete(entity);
        }

        public Location TGetById(int id)
        {
            return _locationDal.GetById(id);
        }

        public List<Location> TGetListAll()
        {
            return _locationDal.GetListAll();
        }

        public void TInsert(Location entity)
        {
            _locationDal.Update(entity);
        }

        public void TUpdate(Location entity)
        {
           _locationDal.Update(entity);
        }
    }
}

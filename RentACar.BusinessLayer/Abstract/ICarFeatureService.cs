using RentACar.BusinessLayer.Dtos;
using RentACar.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.BusinessLayer.Abstract
{
    public interface ICarFeatureService : IGenericService<CarFeature>
    {
        List<CarFeature> GetFeaturesByCarId(int id);

    }
}

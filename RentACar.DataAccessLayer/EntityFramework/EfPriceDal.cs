using Microsoft.EntityFrameworkCore;
using RentACar.DataAccessLayer.Abstract;
using RentACar.DataAccessLayer.Concrete;
using RentACar.DataAccessLayer.Repositories;
using RentACar.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.DataAccessLayer.EntityFramework
{
    public class EfPriceDal:GenericRepository<Price>,IPriceDal
    {
        public List<Price> GetPricesWithCars()
        {
            var context = new RentACarContext();
            var values = context.Prices.Include(x => x.Car).ThenInclude(y => y.Brand).ToList();
            return values;
        }
    }
}

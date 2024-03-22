using RentACar.BusinessLayer.Abstract;
using RentACar.BusinessLayer.Dtos;
using RentACar.DataAccessLayer.Abstract;
using RentACar.DataAccessLayer.Concrete;
using RentACar.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.BusinessLayer.Concrete
{
    public class CarService : ICarService
    {
        private readonly IGenericDal<Car> _carDal;
        private readonly RentACarContext _context;

        public CarService(IGenericDal<Car> carDal, RentACarContext context)
        {
            _carDal = carDal;
            _context = context;
        }

        public void TDelete(int id)
        {
            _carDal.Delete(id);
        }

        public List<CategoryDto> GetCategoryCount()
        {
           
            var categories = _context.Categories.Select(x => new CategoryDto
            {
                CategoryName = x.CategoryName,
                Count = _context.Cars.Count(y => y.CategoryID == x.CategoryID)
            }).ToList();

            return categories;

        }

        public List<Car> TGetAll()
        {
            return _context.Cars.Include(x => x.Category).Include(x => x.Brand).Include(x => x.CarStatus).ToList();
        }

        public Car TGetByID(int id)
        {
            return _carDal.GetByID(id);
        }

        public List<Car> TGetList()
        {
            return _carDal.GetList();
        }

        public void TInsert(Car entity)
        {
            _carDal.Insert(entity);
        }

        public void TUpdate(Car entity)
        {
            _carDal.Update(entity);
        }

        public List<Car> GetLast5Cars()
        {
            

            return _context.Cars.Include(x=>x.Brand).OrderByDescending(x=>x.CarID).Take(5).ToList();
        }

        public List<Car> GetLast3Cars()
        {
            return _context.Cars.Include(x => x.Brand).OrderByDescending(x => x.CarID).Take(3).ToList();
        }
    }
}

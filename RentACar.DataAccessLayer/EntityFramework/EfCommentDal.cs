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
    public class EfCommentDal : GenericRepository<Comment>, ICommentDal
    {
        public List<Comment> GetCommentsByCar(int id)
        {
            var context = new RentACarContext();
            var values = context.Comments.Where(x=>x.CarID == id).ToList();
            return values;
        }
    }
}

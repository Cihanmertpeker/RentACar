using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.EntityLayer.Concrete
{
    public class Comment
    {
        public int CommentID { get; set; }
        public string NameSurname { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }=DateTime.Now;
        public int CarID { get; set; }
        public Car Car { get; set; }
    }
}

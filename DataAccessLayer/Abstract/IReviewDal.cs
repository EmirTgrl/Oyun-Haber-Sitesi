using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IReviewDal : IGenericDal<Review>
    {
        public Review GetReviewWithWriter(int id);
        public List<Review> GetLast3Reviews();
    }
}

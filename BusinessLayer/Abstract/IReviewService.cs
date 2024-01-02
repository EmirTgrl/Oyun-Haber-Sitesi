using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BusinessLayer.Abstract
{
    public interface IReviewService : IGenericService<Review>
    {
        public Review TGetReviewWithWriter(int id);
        public List<Review> TGetLast3Reviews();
    }
}

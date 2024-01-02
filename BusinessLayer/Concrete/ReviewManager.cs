using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ReviewManager : IReviewService
    {
        IReviewDal _reviewDal;

        public ReviewManager(IReviewDal reviewDal)
        {
            _reviewDal = reviewDal;
        }

        public void TAdd(Review t)
        {
            _reviewDal.Insert(t);
        }

        public void TDelete(Review t)
        {
            _reviewDal.Delete(t);
        }

        public Review TGetByID(int id)
        {
            return _reviewDal.GetById(id);
        }

        public List<Review> TGetLast3Reviews()
        {
            return _reviewDal.GetLast3Reviews();
        }

        public List<Review> TGetList()
        {
            return _reviewDal.GetList();
        }

        public Review TGetReviewWithWriter(int id)
        {
            return _reviewDal.GetReviewWithWriter(id);
        }

        public void TUpdate(Review t)
        {
            _reviewDal.Update(t);
        }
    }
}

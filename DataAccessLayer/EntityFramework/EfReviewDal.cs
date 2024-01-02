using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
namespace DataAccessLayer.EntityFramework
{
    public class EfReviewDal : GenericRepository<Review>, IReviewDal
    {
        public List<Review> GetLast3Reviews()
        {
            using (var context = new Context())
            {
                var values = context.Reviews.Take(3).OrderByDescending(x => x.ReviewId).ToList();
                return values;
            }
        }

        public Review GetReviewWithWriter(int id)
        {
            using (var c = new Context())
            {
                return c.Reviews.Where(x => x.ReviewId == id).Include(x => x.Testimonial).Include(x => x.AppUser).FirstOrDefault();
            }
        }
    }
}

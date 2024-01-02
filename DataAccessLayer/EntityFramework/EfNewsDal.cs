using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfNewsDal : GenericRepository<News>, INewsDal
    {
        public List<News> GetLast4News()
        {
            using (var context = new Context())
            {
                var values = context.News.Take(4).OrderByDescending(x => x.NewsId).ToList();
                return values;
            }
        }

        public News GetNewsWithWriter(int id)
        {
            using (var context = new Context())
            {
                return context.News.Where(x => x.NewsId == id).Include(x => x.AppUser).FirstOrDefault();
            }
        }

        public List<News> MostPopular5News()
        {
            using (var context = new Context())
            {
                var values= context.News.Include(n => n.Comments).OrderByDescending(n => n.Comments.Count).Take(5).ToList();
                return values;
            }
        }
    }
}

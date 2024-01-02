using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface INewsDal : IGenericDal<News>
    {
        public List<News> GetLast4News();
        public News GetNewsWithWriter(int id);
        public List<News> MostPopular5News();
    }
}

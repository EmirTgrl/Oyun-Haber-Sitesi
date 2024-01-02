using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BusinessLayer.Abstract
{
    public interface INewsService : IGenericService<News>
    {
        public List<News> TGetLast4News();
        public News TGetNewsWithWriter(int id);
        public List<News> TMostPopular5News();
    }
}

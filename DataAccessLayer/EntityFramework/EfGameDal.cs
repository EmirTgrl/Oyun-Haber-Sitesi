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
    public class EfGameDal : GenericRepository<Game>, IGameDal
    {
        public Game GetGameWithType(int id)
        {
            using (var c = new Context())
            {
                return c.Games.Where(x => x.Id == id).Include(x => x.GameType).FirstOrDefault();
            }
        }
    }
}

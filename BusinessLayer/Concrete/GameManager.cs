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
    public class GameManager : IGameService
    {
        IGameDal _gameDal;

        public GameManager(IGameDal gameDal)
        {
            _gameDal = gameDal;
        }

        public void TAdd(Game t)
        {
            _gameDal.Insert(t);
        }

        public void TDelete(Game t)
        {
            throw new NotImplementedException();
        }

        public Game TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public Game TGetGameWithType(int id)
        {
            return _gameDal.GetGameWithType(id);
        }

        public List<Game> TGetList()
        {
            return _gameDal.GetList();
        }

        public void TUpdate(Game t)
        {
            throw new NotImplementedException();
        }
    }
}
